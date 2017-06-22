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
        private Logica objLogica= new Logica();
        private int contadorFilas = 0;
        private int IdFila;
        private int ValueIdFila;
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

        private void actualizarListaTimer()
        {
            
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            timer1.Enabled = true;


        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            //inicializarPedidos();
        }

        private void inicializarPedidos()
        {
            //Limpio mi grilla y reseteo el contador
            contadorFilas = 0;
            dgvPedidosCargados.Rows.Clear();
            dgvPedidosCargados.Refresh();
            //traigo desde la base de datos

            
            IQueryable<Pedidos> pedidos = objLogica.getPedidos();
            var query = (from p in pedidos.Where( p => p.Fecha_creacion == dtpFecha.Value.Date)
                         orderby p.Prioridad_ descending
                         select new
                         {
                             p.Id,
                             p.Numero_Local,
                             p.Descripcion_Local,
                             p.Legajo_Vendedor,
                             p.Descripcion_Vendedor,
                             p.Estado,
                             p.Prioridad_,
                             p.Hombre,
                             p.Mujer,
                             p.Kids,
                             p.Fecha_creacion,
                             p.Fecha_Asignacion,
                             p.Descripcion_Facturista,
                             p.Descripcion_Asignador
                         }).ToList();
            foreach (var item in query)
            {
                
                dgvPedidosCargados.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
                     item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Estado,item.Prioridad_, item.Hombre, item.Mujer, item.Kids
                      , item.Fecha_creacion, item.Fecha_Asignacion, item.Descripcion_Facturista, item.Descripcion_Asignador);
                
                if (item.Prioridad_ != null) {
                    if (item.Prioridad_.Trim().ToString() == "Prioridad")
                    {
                        dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;                     
                    }              
                }
                this.contadorFilas = contadorFilas + 1;  
            }
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
            IdFila = dgvPedidosCargados.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedidosCargados.Rows[IdFila].Cells[0].Value);              
        }

        private void actualizarAsignacion()
        {
            Operario facturista = (Operario)cmbFacturista.SelectedItem;
            Operario asignador = (Operario)cmbAsignador.SelectedItem;

            objLogica.asignarFacturista(ValueIdFila, facturista, asignador,DateTime.Today.Date);
            
            objLogica.cambiarEstado(ValueIdFila, "Asignado");
            actualizarFila(facturista.Descripcion, asignador.Descripcion); 
        }

        private void actualizarFila(String facturista, string asignador)
        {
            dgvPedidosCargados[5, IdFila].Value = "Asignado";
            dgvPedidosCargados[11, IdFila].Value = DateTime.Today.Date.ToString();
            dgvPedidosCargados[12, IdFila].Value = facturista;
            dgvPedidosCargados[13, IdFila].Value = asignador;
        }

        private void llenarComboBox()
        {
            try
            {
                //hace un bindig de los vendedores del context a una lista
                List<Operario> operarios = objLogica.operarios();
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
