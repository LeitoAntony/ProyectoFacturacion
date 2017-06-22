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
        private Logica objLogica = new Logica();
        private int paginaActual = 1;
        private int tamañoPagina = 40;
        private Bitmap bmp;
        private int IdFila;
        private int ValueIdFila;

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
                paginaActual--;
                IPagedList<Pedidos> list = objLogica.listaPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
                btnSig.Enabled = list.IsFirstPage;
                btnPrev.Enabled = list.IsLastPage;
                lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
                pedidosBindingSource.DataSource = list.ToList();
            }

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (btnSig.Enabled)
            {
                paginaActual++;
                IPagedList<Pedidos> list = objLogica.listaPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
                btnSig.Enabled = list.IsFirstPage;
                btnPrev.Enabled = list.IsLastPage;
                lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
                pedidosBindingSource.DataSource = list.ToList();
            }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objLogica.comentar(ValueIdFila, txtComentario.Text);
            txtComentario.Text = String.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            txtPopUp.Visible = false;
            txtPopUp.Text = string.Empty;
            btnCerrar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            setPrioridad();
        }

        private void dgvPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                IdFila = dgvPedido.CurrentRow.Index;
                ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void listarPedidos()
        {
            IPagedList<Pedidos> list = objLogica.listaPedidosPorFecha(dtpFecha.Value, paginaActual, tamañoPagina);
            btnSig.Enabled = list.IsFirstPage;
            btnPrev.Enabled = list.IsLastPage;
            lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
            pedidosBindingSource.DataSource = list.ToList();
        }

        private void setPrioridad()
        {
            objLogica.setPrioridad(ValueIdFila);
            actualizarFila("Prioridad");
            dgvPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
        }

        private void actualizarFila(String pri)
        {
            dgvPedido[6, IdFila].Value = pri;
        }

        private void txtComentario_MouseEnter(object sender, EventArgs e)
        {
            txtComentario.Size = new System.Drawing.Size(557, 150);

        }

        private void txtComentario_MouseLeave(object sender, EventArgs e)
        {
            this.txtComentario.Size = new System.Drawing.Size(557, 20);
        }

    }
}
