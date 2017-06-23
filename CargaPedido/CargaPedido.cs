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
            setRButton();
            inicializarPedidos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //chequeo de campos completos
            if (cmbVendedor.SelectedItem != null && cmbLocal.SelectedItem != null)
            //&& (rbHombre.Checked || rbMujer.Checked || rbKids.Checked))
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
            //actualizarPedido();
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
                objLogica = new Logica();
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

        private void setRButton()
        {
            objLogica = new Logica();
            objLogica = new Logica();
            Segmentos[] array = objLogica.getSegmentos();
            rbHombre.Text = array[0].Descripcion;
            rbMujer.Text = array[1].Descripcion;
            rbKids.Text = array[2].Descripcion;
        }

        //private void inicializarPedidos()
        //{
        //    objLogica = new Logica();
        //    //traigo desde la base de datos
        //    List<Pedidos> pedidos = objLogica.getPedidosPorFecha(DateTime.Now);
        //    //los mapeo a la gilla
        //    foreach (var item in pedidos)
        //    {
        //        dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
        //           item.Legajo_Vendedor, item.Descripcion_Vendedor, item.Hombre, item.Mujer, item.Kids
        //            , item.Fecha_creacion);
        //        this.contadorFilas = contadorFilas + 1;
        //    }
        //}

        private void cargarPedido(int conFilas)
        {
            //se carga en el dataGrdView los elemenos 
            dgvPedido.Rows.Insert(conFilas, Id, DateTime.Now);
            contadorFilas = contadorFilas + 1;

            //String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Today)
        }

        private void cargarCanasto()
        {
            objLogica = new Logica();
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (rbHombre.Checked)
                hombre = rbHombre.Text;
            if (rbMujer.Checked)
                mujer = rbMujer.Text;
            if (rbKids.Checked)
                kids = rbKids.Text;
            actualizarPedido(local, vendedor, hombre, mujer, kids);
        }

        private void actualizarPedido(Local local, Operario vendedor, String hombre, String mujer, String kids)
        {
            dgvPedido[2, IdFila].Value = local.Numero;
            dgvPedido[3, IdFila].Value = local.Descripcion;
            dgvPedido[4, IdFila].Value = vendedor.Legajo;
            dgvPedido[5, IdFila].Value = vendedor.Descripcion;
            dgvPedido[6, IdFila].Value = hombre;
            dgvPedido[7, IdFila].Value = mujer;
            dgvPedido[8, IdFila].Value = kids;

        }

        private void insertarPedidoDB()
        {
            objLogica = new Logica();

            //inserto los datos en la DB y me guardo el id de ese pedido
            Id = objLogica.insertarPedido();
        }

        private void insertarCanastoDB()
        {
            //recupero los datos de local, vendedor y segmento
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (rbHombre.Checked){
                hombre = rbHombre.Text;
            if (rbMujer.Checked)
                mujer = rbMujer.Text;
            if (rbKids.Checked)
                kids = rbKids.Text;

            objLogica.insertarCanasto(Id, local, vendedor, txtLocal.Text, txtVenedor.Text, hombre);


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

        private void resetearCampos()
        {
            cmbVendedor.SelectedIndex = -1;
            cmbLocal.SelectedIndex = -1;
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbKids.Checked = false;
            txtLocal.Text = String.Empty;
            txtVenedor.Text = String.Empty;
            cmbVendedor.Focus();
        }

        private void btnAgregarCanasto_Click(object sender, EventArgs e)
        {

        }



    }
}
