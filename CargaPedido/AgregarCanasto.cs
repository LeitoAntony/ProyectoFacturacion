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
    public partial class AgregarCanasto : Form
    {
        private Logica objLogica;
        private CargaPedido objCargaPedido = new CargaPedido();
        private int IdCanasto;
        
        

        public AgregarCanasto()
        {
            InitializeComponent();
        }

        private void AgregarCanasto_Load(object sender, EventArgs e)
        {
            llenarCmbVendedor();
            cmbVendedor.SelectedIndex = -1;
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


        private void insertarCanastoDB()
        {
            objLogica = new Logica();

            

            //recupero los datos de local, vendedor y segmento
            Pedidos nombreLocal = objLogica.getPedido(objCargaPedido.getValuePedido());
            Local local = objLogica.getLocal(nombreLocal.Descripcion_local);
            MessageBox.Show(nombreLocal.Descripcion_local + "   " +local.Descripcion );
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            int IdPedido = objCargaPedido.getIdPedido();
            string hombre = "", mujer = "", kids = "";
            if (rbHombre.Checked)
            {
                hombre = rbHombre.Text;
                IdCanasto = objLogica.insertarCanasto(nombreLocal.Id, local, vendedor, hombre);
            }
            if (rbMujer.Checked)
            {
                mujer = rbMujer.Text;
                IdCanasto = objLogica.insertarCanasto(nombreLocal.Id, local, vendedor, mujer);
            }
            if (rbKids.Checked)
            {
                kids = rbKids.Text;
                IdCanasto = objLogica.insertarCanasto(nombreLocal.Id, local, vendedor, kids);
            }
        }

        private void btnAgregarCanasto_Click_1(object sender, EventArgs e)
        {
            //if (cmbVendedor.SelectedItem != null && (rbHombre.Checked || rbMujer.Checked || rbKids.Checked))
            //{
                insertarCanastoDB();
                this.Close();
            //}
            //else
            //    MessageBox.Show("Complete todos los campos! ", "Advertencia!");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbVendedor.SelectedIndex = -1;
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbKids.Checked = false;           
            txtVenedor.Text = String.Empty;
            cmbVendedor.Focus();
        }

        private void setRButton()
        {
            objLogica = new Logica();
            Segmento[] array = objLogica.getSegmentos();
            rbHombre.Text = array[0].Descripcion;
            rbMujer.Text = array[1].Descripcion;
            rbKids.Text = array[2].Descripcion;
        }


        //devuelve el vendedor seleccionado
        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            if (cmbVendedor.SelectedItem != null)
                txtVenedor.Text = vendedor.Legajo.ToString();
        }

    }
}
