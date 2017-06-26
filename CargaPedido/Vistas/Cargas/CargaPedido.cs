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
    public partial class CargaPedido : Form
    {
        private Logica objLogica;
        private Local local = new Local();

        private int contadorFilas = 0;
        private int IdPedido;
        private static int IdFila;
        private static int ValueIdFila;
        private bool bandera = false;

        private int contadorFilasCanasto = 0;
        private int IdCanasto;
        private int IdFilaCanasto = 0;
        private static int ValueIdFilaCanasto = 0;
        private bool banderaCanasto = false;

        Form frmCargaCanasto;
        public CargaPedido()
        {
            InitializeComponent();
        }

        private void CargaPedido_Load(object sender, EventArgs e)
        {
            llenarCombo();
            inicializarPedidos();
        }
         
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //chequeo de campos completos
            if (cmbLocal.SelectedItem != null)
            {
                //inserto los objetos en la base
                insertarPedidoDB();
                //cargo el pedido en los comboBox
                cargarPedido();
                resetearCampos();
            }
            else
            {
                MessageBox.Show("Complete el campo Local! ");
            }
        }
        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (contadorFilas > 0 && bandera)
                if (contadorFilasCanasto == 0)
                {
                    if (MessageBox.Show("Estas seguro que desas eliminar?", "AVISO", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        eliminarPedido();
                        eliminarPedidoDB();
                    }
                }
                else
                    MessageBox.Show("Tiene canastos relacionados. Eliminelos primero!", "Advertencia!");
            else
                MessageBox.Show("Debe seleccionar un pedido para borrar! ", "Advertencia!");
            bandera = false;
        }
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizarPedido();
        }

        private void dgvPedido_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
            if(contadorFilas > 0)
            getCanastos();
            //dgvPedido.Rows[IdFila].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bandera = true;
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
            frmCargaCanasto = new AgregarCanasto();
            frmCargaCanasto.Visible = true;
        }

        private void dgvCanasto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFilaCanasto = dgvCanasto.CurrentRow.Index;
            ValueIdFilaCanasto = Convert.ToInt32(dgvCanasto.Rows[IdFilaCanasto].Cells[0].Value);
            eliminarCanasto();
            eliminarCanastoDB();
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local local = (Local)cmbLocal.SelectedItem;
            if (cmbLocal.SelectedItem != null)
                txtLocal.Text = local.Numero.ToString();

        }

        private void resetearCampos()
        {
            cmbLocal.SelectedIndex = -1;
            txtLocal.Text = String.Empty;
        }

        private void llenarCombo()
        {
            //completo los ComboBox
            llenarCmbLocales();

            resetearCampos();
        }

        private void llenarCmbLocales()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los locales del context a una lista
                var locales = objLogica.getLocales();
                //agrega los locales al combobox definido por el objeto localBindngSource
                this.localBindingSource.DataSource = locales;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }

        }     
        
        private void inicializarPedidos()
        {
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
            contadorFilas = 0;
            objLogica = new Logica();
            //traigo desde la base de datos
            List<Pedido> pedidos = objLogica.getPedidosPorFecha(DateTime.Now);
            
            //los mapeo a la gilla
            foreach (var item in pedidos)
            {
                dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Descripcion_local);
                this.contadorFilas = contadorFilas + 1;
            }   
        }
        
        private void cargarPedido()
        {
            Local local = (Local)cmbLocal.SelectedItem;          
            //se carga en el dataGrdView los elemenos 
            dgvPedido.Rows.Insert(contadorFilas, IdPedido, local.Descripcion);
            contadorFilas++;
        }
        
        private void insertarCanasto()
        {
            objLogica = new Logica();
            Canasto canasto = objLogica.getCanastoPorIdPedido(IdPedido);

                dgvCanasto.Rows.Insert(contadorFilasCanasto, canasto.Id, canasto.Numero_local, 
                    canasto.Descripcion_local, canasto.Legajo_vendedor,canasto.Descripcion_vendedor, canasto.Segmento, canasto.Fecha);
            contadorFilasCanasto++;
        }
        
        private void insertarPedidoDB()
        {
            objLogica = new Logica();
            Local local = (Local)cmbLocal.SelectedItem;           
            //inserto los datos en la DB y me guardo el id de ese pedido
           IdPedido = objLogica.insertarPedido(local);
        }

        private void eliminarPedido()
        {
            //elimino la fila por su id
            dgvPedido.Rows.RemoveAt(IdFila);
            contadorFilas--;
        }
        
        private void eliminarPedidoDB()
        {
            objLogica = new Logica();
            //elimino los datos de la base de datos
            objLogica.eliminarPedido(ValueIdFila);
        }
        
        public void getCanastos()
        {
            dgvCanasto.Rows.Clear();
            dgvCanasto.Refresh();
            contadorFilasCanasto = 0;
            objLogica = new Logica();
            List<Canasto> canastos = objLogica.getCanastosPorIdPedido(ValueIdFila);
            foreach (var item in canastos)
            {
                dgvCanasto.Rows.Insert(contadorFilasCanasto,item.Id, ValueIdFila, item.Numero_local, 
                    item.Descripcion_local, item.Legajo_vendedor, item.Descripcion_vendedor, item.Segmento, item.Fecha);
                this.contadorFilasCanasto = contadorFilasCanasto + 1;
            }
        }

        private void eliminarCanasto()
        {
            //elimino la fila por su id
            dgvCanasto.Rows.RemoveAt(IdFilaCanasto);
            contadorFilasCanasto--;
        }
       
        private void eliminarCanastoDB()
        {
            MessageBox.Show("id fila caasto " + ValueIdFilaCanasto);
            objLogica = new Logica();
            //elimino los datos de la base de datos
            objLogica.eliminarCanasto(ValueIdFilaCanasto);
        }

        public int getValuePedido()
        {
            return ValueIdFila;    
        }

        public int getIdPedido()
        {
            return IdPedido;
        }

        //private void actualizarPedido()
        //{
        //    objLogica = new Logica();
        //    //recupero los datos de local, vendedor y segmento
        //    Local local = (Local)cmbLocal.SelectedItem;
        //    Operario vendedor = (Operario)cmbVendedor.SelectedItem;
        //    string hombre = "", mujer = "", kids = "";
        //    if (rbHombre.Checked)
        //        hombre = rbHombre.Text;
        //    if (rbMujer.Checked)
        //        mujer = rbMujer.Text;
        //    if (rbKids.Checked)
        //        kids = rbKids.Text;
        //    objLogica.actualizarPedido(ValueIdFila, local, vendedor, txtLocal.Text,
        //        txtVenedor.Text, hombre, mujer, kids);

        //    eliminarPedido();
        //    cargarPedido(IdFila);
        //    resetearCampos();
        //}

        

        

        

        


       
    }
}
