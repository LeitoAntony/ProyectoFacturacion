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
    public partial class AsignacionPedido : Form
    {
        private Logica objLogica;
        private int contadorFilas = 0;
        private int IdFila;
        private int ValueIdFila;
        private List<Pedidos> pedidos = new List<Pedidos>();


        public AsignacionPedido()
        {
            InitializeComponent();
        }

        private void AsignacionPedido_Load(object sender, EventArgs e)
        {
            llenarComboBox();
            cmbAsignador.SelectedIndex = -1;
            cmbFacturista.SelectedIndex = -1;
            actualizarListaTimer();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            inicializarPedidos();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            actualizarAsignacion();
            cmbFacturista.SelectedIndex = -1;
        }

        private void dgvPedidosCargados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturo el id de la fila y su valor(Id de cada pedido)
            IdFila = dgvPedidosCargados.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedidosCargados.Rows[IdFila].Cells[0].Value);
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            inicializarPedidos();
        }

        private void inicializarPedidos()
        {
            //Limpio mi grilla y reseteo el contador
            contadorFilas = 0;
            dgvPedidosCargados.Rows.Clear();
            dgvPedidosCargados.Refresh();
            pedidos.Clear();

            objLogica = new Logica();

            //traigo los objetos de la DB
           // pedidos = objLogica.getPedidosPorFecha(dtpFecha.Value.Date);
            //completo la grilla 
            //foreach (var item in pedidos)
            //{
            //    dgvPedidosCargados.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
            //         item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Estado, item.Prioridad_, item.Hombre, item.Mujer, item.Kids
            //          , item.Fecha_creacion, item.Fecha_Asignacion, item.Descripcion_Facturista, item.Descripcion_Asignador);
            //    //por cada fila verifica su estado y prioridad
            //    if (item.Prioridad_ != null)
            //    {
            //        if (item.Prioridad_.Trim().ToString() == "Prioridad")
            //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;

            //    }
            //    if (item.Estado != null)
            //    {
            //        if (item.Estado.Trim().ToString().Equals("Asignado"))
            //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Yellow;
            //        if (item.Estado.Trim().ToString().Equals("Facturado"))
            //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.LightGreen;
            //    }
            //    this.contadorFilas = contadorFilas + 1;
            //}
        }

        private void actualizarListaTimer()
        {
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
        }

        private void actualizarAsignacion()
        {
            try
            {
                Operario facturista = (Operario)cmbFacturista.SelectedItem;
                Operario asignador = (Operario)cmbAsignador.SelectedItem;
                objLogica = new Logica();
                //actualizo la DB con el facturista y la fecha/hora
                objLogica.setFacturista(ValueIdFila, facturista, asignador, DateTime.Today.Date);
                //actualizo el estado del pedido
                //objLogica.actualizarEstado(ValueIdFila, "Asignado");
                actualizarFila(facturista.Descripcion, asignador.Descripcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void actualizarFila(String facturista, string asignador)
        {
            //actualizo datos de la grilla
            dgvPedidosCargados[5, IdFila].Value = "Asignado";
            dgvPedidosCargados[11, IdFila].Value = DateTime.Today.Date.ToString();
            dgvPedidosCargados[12, IdFila].Value = facturista;
            dgvPedidosCargados[13, IdFila].Value = asignador;
        }

        private void llenarComboBox()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> operarios = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = operarios;
                this.operarioBindingSource1.DataSource = operarios;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

    }
}
