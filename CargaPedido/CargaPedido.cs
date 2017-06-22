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
        private Logica objLogica = new Logica();
        private int contadorFilas = 0;
        private int Id;
        private int IdFila;
        private int ValueIdFila;


        public CargaPedido()
        {
            InitializeComponent();
        }

        private void CargaPedido_Load(object sender, EventArgs e)
        {
            llenarCombo();
            inicializarPedidos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //chequeo de campos completos
            if (cmbVendedor.SelectedItem != null && cmbLocal.SelectedItem != null &&
                (chkHombre.Checked || chkMujer.Checked || chkKids.Checked))
            {
                //inserto los objetos en la base
                insertarPedidoDB();
                //cargo el pedido en los comboBox
                cargarPedido(contadorFilas);

            }
            else
            {
                MessageBox.Show("Complete todos los campos! ", "Advertencia!");
            }
            resetearCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            eliminarPedido();
            eliminarPedidoDB();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarPedido();
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local local = (Local)cmbLocal.SelectedItem;
            if (cmbLocal.SelectedItem != null)
                txtLocal.Text = local.Numero.ToString();

        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            if (cmbVendedor.SelectedItem != null)
                txtVenedor.Text = vendedor.Legajo.ToString();
        }
        
        private void llenarCombo()
        {
            //completo los ComboBox
            llenarCmbVendedor();
            llenarCmbLocales();

            resetearCampos();
        }

        private void llenarCmbVendedor()
        {
            try
            {
                //hace un bindig de los vendedores del context a una lista
                List<Operario> vendedores = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = vendedores;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void llenarCmbLocales()
        {
            try
            {
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
            //traigo desde la base de datos
            List<Pedidos> pedidos = objLogica.getPedidosPorFecha(DateTime.Today.Date);
            //los mapeo a la gilla
            foreach (var item in pedidos)
            {
                dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
                   item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Hombre, item.Mujer, item.Kids
                    , item.Fecha_creacion);
                this.contadorFilas = contadorFilas + 1;
            }
        }

        private void cargarPedido(int conFilas)
        {
            //elementos selecionados de los comboBox
            Local local = (Local)cmbLocal.SelectedItem; 
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (chkHombre.Checked)
                hombre = chkHombre.Text;
            if (chkMujer.Checked)
                mujer = chkMujer.Text;
            if (chkKids.Checked)
                kids = chkKids.Text;

            //se carga en el dataGrdView los elemenos 
            dgvPedido.Rows.Insert(conFilas, Id, local.Numero, local.Descripcion, vendedor.Legajo
                , vendedor.Descripcion, hombre, mujer, kids,
                String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Today));
            contadorFilas = contadorFilas + 1;
        }

        private void insertarPedidoDB()
        {
            //recupero los datos de local, vendedor y segmento
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (chkHombre.Checked)
                hombre = chkHombre.Text;
            if (chkMujer.Checked)
                mujer = chkMujer.Text;
            if (chkKids.Checked)
                kids = chkKids.Text;
            //inserto los datos en la DB y me guardo el id de ese pedido
            Id = objLogica.insertarPedido(local, vendedor, txtLocal.Text,
                txtVenedor.Text, hombre, mujer, kids);
        }

        private void eliminarPedido()
        {
            //elimino la fila por su id
            dgvPedido.Rows.RemoveAt(IdFila);
            contadorFilas--;
        }

        private void eliminarPedidoDB()
        { 
            //elimino los datos de la base de datos
            objLogica.eliminarPedido(ValueIdFila);
        }

        private void actualizarPedido()
        {
            //recupero los datos de local, vendedor y segmento
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (chkHombre.Checked)
                hombre = chkHombre.Text;
            if (chkMujer.Checked)
                mujer = chkMujer.Text;
            if (chkKids.Checked)
                kids = chkKids.Text;
            objLogica.actualizarPedido(ValueIdFila, local, vendedor, txtLocal.Text,
                txtVenedor.Text, hombre, mujer, kids);
         
            eliminarPedido();
            cargarPedido(IdFila);
            resetearCampos();
        }

        private void resetearCampos()
        {
            cmbVendedor.SelectedIndex = -1;
            cmbLocal.SelectedIndex = -1;
            chkHombre.Checked = false;
            chkMujer.Checked = false;
            chkKids.Checked = false;
            txtLocal.Text = String.Empty;
            txtVenedor.Text = String.Empty;
            cmbVendedor.Focus();
        }

        

    }
}
