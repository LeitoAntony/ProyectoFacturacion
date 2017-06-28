using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PedidosFacturacion
{
    public partial class Invoicing : Form
    {
        private Logic objLogic = new Logic();
        private int IdRow;
        private int ValueRow;
        private int accountantRows = 0;


        public Invoicing()
        {
            InitializeComponent();
        }

        private void FacturacionPedido_Load(object sender, EventArgs e)
        {
            fillCMB();
            cmbFacturista.SelectedIndex = -1;
        }

        private void btnFacturado_Click(object sender, EventArgs e)
        {
            //colocar como facturado el pedido
            objLogic.updateStateByDate(ValueRow, "Facturado");
            updateRow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRow = dataGridView1.CurrentRow.Index;
            ValueRow = Convert.ToInt32(dataGridView1.Rows[IdRow].Cells[0].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            initializeOrder();
        }

        private void updateRow()
        {
            dataGridView1[4, IdRow].Value = "Facturado";
            dataGridView1[8, IdRow].Value = DateTime.Now;
            dataGridView1.Rows[IdRow].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void fillCMB()
        {
            try
            {
                //hace un bindig de los vendedores del context a una lista
                List<Operario> invoices = objLogic.getOperators();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = invoices;

            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void initializeOrder()
        {
            //Limpio mi grilla y reseteo el contador
            reset();

            Operario invoicer = (Operario)cmbFacturista.SelectedItem;
            //traigo desde la base de datos
            List<Canasto> list = objLogic.getOrderByInvoce(invoicer);
            //mapeo
            fillDataGrid(list);
        }

        private void fillDataGrid(List<Canasto> list)
        {
            foreach (var item in list)
            {
                dataGridView1.Rows.Insert(accountantRows, item.Id, item.Numero_local, item.Descripcion_local,
                      item.Descripcion_vendedor, item.Estado, item.Segmento
                      , item.Fecha, item.Fecha_asignacion, item.Fecha_facturacion,
                       item.Descripcion_asignador, item.Descripcion_facturista);
                //resalto segun el estado
                state(item);
                this.accountantRows = accountantRows + 1;
            }
        }

        private void state(Canasto item)
        {
            if (item.Estado != null)
            {
                if (item.Estado.Trim().ToString() == "Facturado")
                    dataGridView1.Rows[accountantRows].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void reset()
        {
            accountantRows = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
    }
}
