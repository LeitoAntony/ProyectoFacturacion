using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using System.Threading;

namespace PedidosFacturacion
{
    public partial class Consultas : Form
    {
        private Logica objLogica;
        private int paginaActual = 1;
        private int tamañoPagina = 40;
        private Bitmap bmp;
        private int IdFila;
        private int ValueIdFila;
        private int contadorFilas = 0;
        private IPagedList<Pedido> list;

        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btmConsultar_Click(object sender, EventArgs e)
        {
            listarPedidos();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (btnPrev.Enabled)
            {
                objLogica = new Logica();
                paginaActual--;
                //list = objLogica.getPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
                btnSig.Enabled = list.IsFirstPage;
                btnPrev.Enabled = list.IsLastPage;
                lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
                cargarPedido();
            }

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (btnSig.Enabled)
            {
                objLogica = new Logica();
                paginaActual++;
                //list = objLogica.getPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
                btnSig.Enabled = list.IsFirstPage;
                btnPrev.Enabled = list.IsLastPage;
                lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
                cargarPedido();
            }

        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            setPrioridad();
        }

        private void txtComentario_MouseEnter(object sender, EventArgs e)
        {
            txtComentario.Size = new System.Drawing.Size(557, 150);

        }

        private void txtComentario_MouseLeave(object sender, EventArgs e)
        {
            this.txtComentario.Size = new System.Drawing.Size(557, 20);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objLogica = new Logica();
           // objLogica.setComentario(ValueIdFila, txtComentario.Text);
            txtComentario.Text = String.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            txtPopUp.Visible = false;
            txtPopUp.Text = string.Empty;
            btnCerrar.Visible = false;
        }
        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int altura = dgvPedido.Height;
            dgvPedido.Height = dgvPedido.RowCount * dgvPedido.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvPedido.Width, dgvPedido.Height);
            dgvPedido.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPedido.Width, dgvPedido.Height));
            dgvPedido.Height = altura;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dgvPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                objLogica = new Logica();
                //capturo el id de la fila y su valor(Id de cada pedido)
                IdFila = dgvPedido.CurrentRow.Index;
                ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
                //muestro el comentario en el caso que exista
                Thread.Sleep(500);
                string comentario = objLogica.getComentario(ValueIdFila).ToString();
                txtPopUp.Text = comentario.ToString();
                btnCerrar.Visible = true;
                txtPopUp.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("El pedido no contiene comentarios!");
            }
        }
        
        private void cargarPedido()
        {
            contadorFilas = 0;
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
            //completo la grilla 
            //foreach (var item in list)
            //{
            //    dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
            //             item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Estado, item.Prioridad_, item.Hombre, item.Mujer, item.Kids
            //              , item.Fecha_creacion, item.Fecha_Asignacion, item.Fecha_Facturacion, item.Descripcion_Asignador, item.Descripcion_Facturista);
            //    if (item.Prioridad_ != null)
            //    {
            //        if (item.Prioridad_.Trim().ToString() == "Prioridad")
            //            dgvPedido.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    if (item.Estado != null)
            //    {
            //        if (item.Estado.Trim().ToString() == "Asignado")
            //            dgvPedido.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Yellow;
            //        if (item.Estado.Trim().ToString() == "Facturado")
            //            dgvPedido.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.LightGreen;
            //    }
            //    this.contadorFilas = contadorFilas + 1;
            //}
        }

        private void listarPedidos()
        {
            objLogica = new Logica();
            //traigo los objetos de la DB
            list = objLogica.getPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
            btnSig.Enabled = list.IsFirstPage;
            btnPrev.Enabled = list.IsLastPage;
            lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
            //mapeo el pedido a la grilla
            cargarPedido();
        }
        
        private void setPrioridad()
        {
            objLogica = new Logica();
            objLogica.setPrioridad(ValueIdFila);

            actualizarFila("Prioridad");
            dgvPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
        }

        private void actualizarFila(String pri)
        {
            dgvPedido[6, IdFila].Value = pri;
        }

    }
}
