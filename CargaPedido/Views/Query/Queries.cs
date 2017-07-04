using PagedList;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PedidosFacturacion
{
    public partial class Queries : Form
    {
        private Logic objLogic;
        private int actualPage = 1;
        private int sizePage = 40;
        private Bitmap bmp;
        private int IdRow;
        private int ValueRow;
        private int accountantRows = 0;
        private IPagedList<Canasto> list;

        public Queries()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            fillCmbSearch();
            fillCmbLocal();
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (btnPrev.Enabled)
            {
                objLogic = new Logic();
                actualPage--;
                list = objLogic.getOrdersByDate(dtpFecha.Value, actualPage, sizePage);
                setPage();
                initializeOrder(list);
            }

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (btnSig.Enabled)
            {
                objLogic = new Logic();
                actualPage++;
                list = objLogic.getOrdersByDate(dtpFecha.Value, actualPage, sizePage);
                setPage();
                initializeOrder(list);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int height = dgvPedido.Height;
            dgvPedido.Height = dgvPedido.RowCount * dgvPedido.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvPedido.Width, dgvPedido.Height);
            dgvPedido.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPedido.Width, dgvPedido.Height));
            dgvPedido.Height = height;
            printPreviewDialog1.ShowDialog();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            setComentary();
            txtComentario.Text = string.Empty;
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
            setPriority();
        }

        private void txtComentario_MouseEnter(object sender, EventArgs e)
        {
            txtComentario.Size = new System.Drawing.Size(557, 50);
        }

        private void txtComentario_MouseLeave(object sender, EventArgs e)
        {
            this.txtComentario.Size = new System.Drawing.Size(557, 20);
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.SelectedItem.ToString().Trim() == "Local")
            {
                cmbLocal.Enabled = true;
            }
            else
            {
                listaByPriority(dtpFecha.Value);
            }
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local local = (Local)cmbLocal.SelectedItem;
            if (cmbLocal.SelectedItem != null)
                listaByLocal(dtpFecha.Value, local);

        }

        private void btmConsultar_Click_1(object sender, EventArgs e)
        {
            cmbBusqueda.Text = string.Empty;
            cmbLocal.Text = string.Empty;
            listaByDate(dtpFecha.Value);
        }

        private void btnPrioridad_Click(object sender, EventArgs e)
        {
            setPriority();
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                //muestro el comentario en el caso que exista
                string comentary = objLogic.getComentary(ValueRow).ToString();
                if (comentary != string.Empty)
                {
                    txtPopUp.Text = comentary.ToString();
                    btnCerrar.Visible = true;
                    txtPopUp.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El pedido no contiene comentarios!");
            }
        }

        private void dgvPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                objLogic = new Logic();
                //capturo el id de la fila y su valor(Id de cada pedido)
                IdRow = dgvPedido.CurrentRow.Index;
                ValueRow = Convert.ToInt32(dgvPedido.Rows[IdRow].Cells[0].Value);   
            }
            catch (Exception)
            {
                MessageBox.Show("El pedido no contiene comentarios!");
            }
        }

        private void initializeOrder(IPagedList<Canasto> list)
        {
            //resetea la dataGrid
            reset();
            //completo la grilla 
            fillDataGrid(list);
        }

        private void fillDataGrid(IPagedList<Canasto> list)
        {
            foreach (var item in list)
            {
                dgvPedido.Rows.Insert(accountantRows, item.Id, item.Id_pedido, item.Numero_local, item.Descripcion_local, item.Legajo_vendedor, item.Descripcion_vendedor,
                   item.Estado, item.Prioridad, item.Segmento, item.Fecha, item.Fecha_asignacion, item.Fecha_facturacion, item.Descripcion_asignador, item.Descripcion_facturista);

                //resalto fila segun el estado
                state(item);
                //resalto fila segun la prioridad
                priorityCanasto(item);
                stateBellow(item);
                this.accountantRows = accountantRows + 1;
            }
        }

        private void stateBellow(Canasto item)
        {
            if (item.Prioridad != null && item.Estado != null)
            {
                if ((item.Prioridad.Trim().ToString() == "Prioridad") && (item.Estado.Trim().ToString().Equals("Facturado"))) 
                { 
                    dgvPedido.Rows[accountantRows].DefaultCellStyle.BackColor = Color.LightGreen;
                }      
            }
        }

        private void priorityCanasto(Canasto item)
        {
            if (item.Prioridad != null)
            {
                if (item.Prioridad.Trim().ToString() == "Prioridad")
                {
                    dgvPedido.Rows[accountantRows].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void state(Canasto item)
        {
            if (item.Estado != null)
            {
                if (item.Estado.Trim().ToString().Equals("Asignado"))
                {
                    dgvPedido.Rows[accountantRows].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (item.Estado.Trim().ToString().Equals("Facturado"))
                {
                    dgvPedido.Rows[accountantRows].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void reset()
        {
            accountantRows = 0;
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
        }

        private void listaByDate(DateTime fecha)
        {
            objLogic = new Logic();
            //traigo los objetos de la DB
            list = objLogic.getOrdersByDate(fecha.Date, actualPage, sizePage);
            setPage();
            //mapeo el pedido a la grilla
            initializeOrder(list);
        }

        private void listaByPriority(DateTime fecha)
        {
            objLogic = new Logic();
            //traigo los objetos de la DB
            list = objLogic.getOrderByPriority(fecha.Date, actualPage, sizePage);
            setPage();
            //mapeo el pedido a la grilla
            initializeOrder(list);
        }

        private void listaByLocal(DateTime fecha, Local local)
        {
            objLogic = new Logic();
            //traigo los objetos de la DB
            list = objLogic.getOrderByLocal(fecha.Date, actualPage, sizePage, local);
            setPage();
            //mapeo el pedido a la grilla
            initializeOrder(list);
        }

        private void setPage()
        {
            btnSig.Enabled = list.IsFirstPage;
            btnPrev.Enabled = list.IsLastPage;
            lblPagina.Text = string.Format("Página {0}/{1}", list.PageNumber, list.PageCount);
        }

        private void fillCmbSearch()
        {
            cmbBusqueda.Items.Add("Local");
            cmbBusqueda.Items.Add("Prioridad");
        }

        private void setPriority()
        {
            try
            {
                objLogic = new Logic();
                objLogic.setPriority(ValueRow);
                updateRow("Prioridad");
                dgvPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
            }
            catch (Exception e )
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void updateRow(String priority)
        {
            dgvPedido[7, IdRow].Value = priority;   
        }

        private void setComentary()
        {
            try
            {
                objLogic = new Logic();
                objLogic.setComentary(ValueRow, txtComentario.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
            
        }

        private void fillCmbLocal()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los locales del context a una lista
                var locales = objLogic.getLocals();
                //agrega los locales al combobox definido por el objeto localBindngSource
                this.localBindingSource.DataSource = locales;
                cmbLocal.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        } 
    }
}
