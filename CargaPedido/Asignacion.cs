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
    public partial class Asignacion : Form
    {
        private Logica objLogica;
      //  private List<Pedidos> pedidos = new List<Pedidos>();
      //  private List<Canasto> canastos = new List<Canasto>();

        private int contadorFilas = 0;
        private int IdFila;
        private int ValueIdFila;
        private bool bandera = false;

        private int contadorFilasCanasto = 0;
        private int IdFilaCanasto;
        private int ValueIdFilaCanasto;
        private bool banderaCanasto = false;


        public Asignacion()
        {
            InitializeComponent();
        }

        private void AsignacionPedido_Load(object sender, EventArgs e)
        {
            llenarComboBox();
            actualizarListaTimer();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            inicializarPedidos(); 
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //actualizarAsignacion();
        }


        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
            getCanastos();
            //dgvPedido.Rows[IdFila].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void dgvCanasto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            banderaCanasto = true;
            IdFilaCanasto = dgvCanasto.CurrentRow.Index;
            ValueIdFilaCanasto = Convert.ToInt32(dgvCanasto.Rows[IdFilaCanasto].Cells[0].Value);
            //dgvCanasto.Rows[IdFilaCanasto].DefaultCellStyle.BackColor = Color.LightGreen;

        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            inicializarPedidos();
            getCanastos();
        }

        private void getCanastos()
        {
            dgvCanasto.Rows.Clear();
            dgvCanasto.Refresh();
            contadorFilasCanasto = 0;
            objLogica = new Logica();
            List<Canasto> canastos = objLogica.getCanastosPorIdPedido(ValueIdFila);
            
            foreach (var item in canastos)
            {
                dgvCanasto.Rows.Insert(contadorFilasCanasto, item.Id, ValueIdFila, item.Numero_local, 
                    item.Descripcion_local, item.Legajo_vendedor,
                    item.Descripcion_vendedor, item.Segmento, item.Fecha, item.Estado, item.Fecha_asignacion,
                    item.Descripcion_asignador, item.Descripcion_facturista);
                if (item.Estado != null)
                {
                    if (item.Estado.Trim().ToString().Equals("Asignado"))
                    { 
                    dgvCanasto.Rows[contadorFilasCanasto].DefaultCellStyle.BackColor = Color.Yellow;
                    this.contadorFilasCanasto = contadorFilasCanasto + 1;
                    }
                        
                    if (item.Estado.Trim().ToString().Equals("Facturado"))
                    { 
                        dgvCanasto.Rows[contadorFilasCanasto].DefaultCellStyle.BackColor = Color.LightGreen;
                        
                        this.contadorFilasCanasto = contadorFilasCanasto + 1;
                    }
                        
                    
                }
                
                //this.contadorFilasCanasto = contadorFilasCanasto + 1;
            }
            if(contadorFilasCanasto == dgvCanasto.Rows.Count)
                            dgvPedido.Rows[IdFila].DefaultCellStyle.BackColor = Color.LightGreen;
                
        }

        private void inicializarPedidos()
        {
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
            contadorFilas = 0;
            objLogica = new Logica();
            //traigo desde la base de datos
            List<Pedidos> pedidos = objLogica.getPedidosPorFecha(DateTime.Now);

            //los mapeo a la gilla
            foreach (var item in pedidos)
            {
                dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Descripcion_local, item.Prioridad);
                if (item.Prioridad != null)
                {
                    if (item.Prioridad.Trim().ToString() == "Prioridad")
                       dgvPedido.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;
                }
                
                this.contadorFilas = contadorFilas + 1;
            }
        }

        //private void inicializarPedidos()
        //{
        //    //Limpio mi grilla y reseteo el contador
        //    contadorFilas = 0;
        //    dgvPedidosCargados.Rows.Clear();
        //    dgvPedidosCargados.Refresh();
        //    pedidos.Clear();

        //    objLogica = new Logica();

        //    //traigo los objetos de la DB
        //   // pedidos = objLogica.getPedidosPorFecha(dtpFecha.Value.Date);
        //    //completo la grilla 
        //    //foreach (var item in pedidos)
        //    //{
        //    //    dgvPedidosCargados.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
        //    //         item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Estado, item.Prioridad_, item.Hombre, item.Mujer, item.Kids
        //    //          , item.Fecha_creacion, item.Fecha_Asignacion, item.Descripcion_Facturista, item.Descripcion_Asignador);
        //    //    //por cada fila verifica su estado y prioridad
        //    //    if (item.Prioridad_ != null)
        //    //    {
        //    //        if (item.Prioridad_.Trim().ToString() == "Prioridad")
        //    //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;

        //    //    }
        //    //    if (item.Estado != null)
        //    //    {
        //    //        if (item.Estado.Trim().ToString().Equals("Asignado"))
        //    //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Yellow;
        //    //        if (item.Estado.Trim().ToString().Equals("Facturado"))
        //    //            dgvPedidosCargados.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.LightGreen;
        //    //    }
        //    //    this.contadorFilas = contadorFilas + 1;
        //    //}
        //}

        private void actualizarListaTimer()
        {
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
        }

        //private void actualizarAsignacion()
        //{
        //    try
        //    {
        //        Operario facturista = (Operario)cmbFacturista.SelectedItem;
        //        Operario asignador = (Operario)cmbAsignador.SelectedItem;
        //        objLogica = new Logica();
        //        //actualizo la DB con el facturista y la fecha/hora
        //        objLogica.setFacturista(ValueIdFilaCanasto, facturista, asignador, DateTime.Now);
        //        //actualizo el estado del pedido
        //        objLogica.actualizarEstado(ValueIdFilaCanasto, "Asignado");
        //        actualizarFila(facturista.Descripcion, asignador.Descripcion);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void actualizarFila(String facturista, String asignador)
        {
            //actualizo datos de la grilla
            dgvCanasto[8, IdFilaCanasto].Value = "Asignado";
            dgvCanasto[9, IdFilaCanasto].Value = DateTime.Now;
            dgvCanasto[10, IdFilaCanasto].Value = asignador;
            dgvCanasto[11, IdFilaCanasto].Value = facturista;
            
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

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form asignarcanasto = new AsignarCanasto();
            asignarcanasto.Visible = true;

        }

  

    }
}
