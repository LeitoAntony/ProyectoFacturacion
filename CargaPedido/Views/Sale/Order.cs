using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PedidosFacturacion
{
    public partial class Order : Form
    {
        private Logic objLogic;
        private AddBasket frmAddBasket;
        private int accountantRows = 0;
        private static int Id;
        private static int IdRow;
        private static int ValueRow;
        private bool flag = false;

        private int accountantBasketRows = 0;
        private int IdBasketRow = 0;
        private static int ValueBasketRow = 0;


        public Order()
        {
            InitializeComponent();
        }

        private void CargaPedido_Load(object sender, EventArgs e)
        {
            fillCombo();
            initializeorder();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //chequeo de campos completos
            if (cmbLocal.SelectedItem != null)
            {
                //inserto los objetos en la base
                insertOrderDB();
                //cargo el pedido en los comboBox
                insertOrder();
                resetFields();
            }
            else
            {
                MessageBox.Show("Complete el campo Local! ");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (accountantRows > 0 && flag)
                if (accountantBasketRows == 0)
                {
                    if (MessageBox.Show("Estas seguro que desas eliminar?", "AVISO", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteOrder();
                        deleteOrderDB();
                    }
                }
                else
                    MessageBox.Show("Tiene canastos relacionados. Eliminelos primero!", "Advertencia!");
            else
                MessageBox.Show("Debe seleccionar un pedido para borrar! ", "Advertencia!");
            flag = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            updateOrder();
        }

        private void dgvPedido_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            flag = true;
            IdRow = dgvPedido.CurrentRow.Index;
            ValueRow = Convert.ToInt32(dgvPedido.Rows[IdRow].Cells[0].Value);
            if (accountantRows > 0)
                initializeBasket();
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            flag = true;
            IdRow = dgvPedido.CurrentRow.Index;
            ValueRow = Convert.ToInt32(dgvPedido.Rows[IdRow].Cells[0].Value);
            frmAddBasket = new AddBasket();
            frmAddBasket.Visible = true;
        }

        private void dgvCanasto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdBasketRow = dgvCanasto.CurrentRow.Index;
            ValueBasketRow = Convert.ToInt32(dgvCanasto.Rows[IdBasketRow].Cells[0].Value);
            deleteBasket();
            deleteBasketDB();
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local local = (Local)cmbLocal.SelectedItem;
            if (cmbLocal.SelectedItem != null)
                txtLocal.Text = local.Numero.ToString();
        }


        private void initializeorder()
        {
            resetOrder();
            objLogic = new Logic();
            //traigo desde la base de datos
            List<Pedido> pedidos = objLogic.getOrdersByDate(DateTime.Now);

            //los mapeo a la gilla
            fillDataGridOrder(pedidos);
        }

        private void fillDataGridOrder(List<Pedido> pedidos)
        {
            foreach (var item in pedidos)
            {
                dgvPedido.Rows.Insert(accountantRows, item.Id, item.Descripcion_local);
                this.accountantRows = accountantRows + 1;
            }
        }

        private void insertOrder()
        {
            Local local = (Local)cmbLocal.SelectedItem;
            //se carga en el dataGrdView los elemenos 
            dgvPedido.Rows.Insert(accountantRows, Id, local.Descripcion);
            accountantRows++;
        }
        
        private void insertOrderDB()
        {
            objLogic = new Logic();
            Local local = (Local)cmbLocal.SelectedItem;
            //inserto los datos en la DB y me guardo el id de ese pedido
            Id = objLogic.insertOrder(local);
        }
        
        private void deleteOrder()
        {
            //elimino la fila por su id
            dgvPedido.Rows.RemoveAt(IdRow);
            accountantRows--;
        }
        
        private void deleteOrderDB()
        {
            objLogic = new Logic();
            //elimino los datos de la base de datos
            objLogic.deleteOrder(ValueRow);
        }
        
        public int getValueOrder()
        {
            return ValueRow;
        }

        public int getIdOrder()
        {
            return Id;
        }

        private void updateOrder()
        {

        }

        public void initializeBasket()
        {
            resetBasket();
            objLogic = new Logic();
            List<Canasto> canastos = objLogic.getBasketsByOrder(ValueRow);
            fillDataGridBasket(canastos);
        }

        private void fillDataGridBasket(List<Canasto> canastos)
        {
            foreach (var item in canastos)
            {
                dgvCanasto.Rows.Insert(accountantBasketRows, item.Id, ValueRow, item.Numero_local,
                    item.Descripcion_local, item.Legajo_vendedor, item.Descripcion_vendedor, item.Segmento, item.Fecha);
                this.accountantBasketRows = accountantBasketRows + 1;
            }
        }

        private void insertBasket()
        {
            objLogic = new Logic();
            Canasto canasto = objLogic.getBasketByOrder(Id);

            dgvCanasto.Rows.Insert(accountantBasketRows, canasto.Id, canasto.Numero_local,
                canasto.Descripcion_local, canasto.Legajo_vendedor, canasto.Descripcion_vendedor, canasto.Segmento, canasto.Fecha);
            accountantBasketRows++;
        }
        
        private void deleteBasket()
        {
            //elimino la fila por su id
            if (IdBasketRow > 0)
            {
                dgvCanasto.Rows.RemoveAt(IdBasketRow);
                accountantBasketRows--;
            }
        }

        private void deleteBasketDB()
        {
            objLogic = new Logic();
            //elimino los datos de la base de datos
            objLogic.deleteBasket(ValueBasketRow);
        }
        
        private void resetFields()
        {
            cmbLocal.SelectedIndex = -1;
            txtLocal.Text = String.Empty;
        }

        private void resetOrder()
        {
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
            accountantRows = 0;
        }

        private void resetBasket()
        {
            dgvCanasto.Rows.Clear();
            dgvCanasto.Refresh();
            accountantBasketRows = 0;
        }

        private void fillCombo()
        {
            //completo los ComboBox
            fillCmbLocals();

            resetFields();
        }

        private void fillCmbLocals()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los locales del context a una lista
                var locales = objLogic.getLocals();
                //agrega los locales al combobox definido por el objeto localBindngSource
                this.localBindingSource.DataSource = locales;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }
   
    }
}
