using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PedidosFacturacion
{
    public partial class Assignment : Form
    {
        private Logic objLogic;

        private int accountantRows = 0;
        private int IdRow;
        private static int ValueRow;

        private int accountantRowsBasket = 0;


        public Assignment()
        {
            InitializeComponent();
        }

        private void AsignacionPedido_Load(object sender, EventArgs e)
        {
            fillCMB();
            timer();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            initializeOrder();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            initializeOrder();
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRow = dgvPedido.CurrentRow.Index;
            ValueRow = Convert.ToInt32(dgvPedido.Rows[IdRow].Cells[0].Value);
            getBaskets(dgvCanasto);
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignBasket assignBasket = new AssignBasket();
            assignBasket.Visible = true;

        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            if (accountantRows > 0)
                getBaskets(dgvCanasto);
        }

        public void updateRowBasket(String invoicer, String assignmer, DataGridView dgvCanasto, int idRow)
        {
            //actualizo datos de la grilla desde la base de datos
            dgvCanasto[8, idRow].Value = "Asignado";
            dgvCanasto[9, idRow].Value = DateTime.Now;
            dgvCanasto[10, idRow].Value = assignmer;
            dgvCanasto[11, idRow].Value = invoicer;

        }
        
        public void getBaskets(DataGridView dgvCanasto)
        {
            //limpio el dataGridView
            reset(dgvCanasto);
            objLogic = new Logic();
            //traigo los objetos de la DB
            List<Canasto> baskets = objLogic.getBasketsByOrder(ValueRow);
            //mapeo
            fillDataGrid(dgvCanasto, baskets);
        }

        private void fillDataGrid(DataGridView dgvCanasto, List<Canasto> baskets)
        {
            foreach (var item in baskets)
            {
                dgvCanasto.Rows.Insert(accountantRowsBasket, item.Id, ValueRow, item.Numero_local,
                    item.Descripcion_local, item.Legajo_vendedor,
                    item.Descripcion_vendedor, item.Segmento, item.Prioridad, item.Fecha, item.Estado, item.Fecha_asignacion,
                    item.Descripcion_asignador, item.Descripcion_facturista);
                //resalto fila segun el estado
                state(dgvCanasto, item);
                //resalto fila segun la prioridad
                priority(dgvCanasto, item);
            }
        }

        private void reset(DataGridView dgvCanasto)
        {
            dgvCanasto.Rows.Clear();
            dgvCanasto.Refresh();
            accountantRowsBasket = 0;
        }

        private void priority(DataGridView dgvCanasto, Canasto item)
        {
            if (item.Prioridad != null)
            {
                if (item.Prioridad.Trim().ToString() == "Prioridad")
                    dgvCanasto.Rows[accountantRowsBasket].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        
        private void state(DataGridView dgvCanasto, Canasto item)
        {
            if (item.Estado != null)
            {
                if (item.Estado.Trim().ToString().Equals("Asignado"))
                {
                    dgvCanasto.Rows[accountantRowsBasket].DefaultCellStyle.BackColor = Color.Yellow;
                    this.accountantRowsBasket = accountantRowsBasket + 1;
                }

                if (item.Estado.Trim().ToString().Equals("Facturado"))
                {
                    dgvCanasto.Rows[accountantRowsBasket].DefaultCellStyle.BackColor = Color.LightGreen;
                    this.accountantRowsBasket = accountantRowsBasket + 1;
                }
            }
        }

        private void initializeOrder()
        {
            reset(dgvPedido);
            objLogic = new Logic();
            //traigo desde la base de datos
            List<Pedido> orders = objLogic.getOrdersByDate(dtpFecha.Value);

            //los mapeo a la gilla
            foreach (var item in orders)
            {
                dgvPedido.Rows.Insert(accountantRows, item.Id, item.Descripcion_local);
                this.accountantRows = accountantRows + 1;
            }
        }

        private void timer()
        {
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
        }

        private void fillCMB()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> operators = objLogic.getOperators();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = operators;
                this.operarioBindingSource1.DataSource = operators;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

    }
}
