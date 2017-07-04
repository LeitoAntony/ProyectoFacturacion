using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PedidosFacturacion
{
    public partial class AddBasket : Form
    {
        private Logic objLogic;
        private Order objOrder = new Order();        


        public AddBasket()
        {
            InitializeComponent();
        }

        private void AgregarCanasto_Load(object sender, EventArgs e)
        {
            fillCmbSeller();
            resetFields();
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            if (cmbVendedor.SelectedItem != null)
                txtVenedor.Text = vendedor.Legajo.ToString();
        }

        private void btnAgregarCanasto_Click_1(object sender, EventArgs e)
        {
            if (cmbVendedor.SelectedItem != null && (rbHombre.Checked || rbMujer.Checked || rbKids.Checked))
            {
                int idOrder = objOrder.getValueOrder();
                insertBasketDB(idOrder);
                resetFields();
                MessageBox.Show("Agregado correctamente!");
            }
            else
                MessageBox.Show("Complete todos los campos! ", "Advertencia!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetFields();
        }
 
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillCmbSeller()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> vendedores = objLogic.getOperators();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = vendedores;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void insertBasketDB(int IdPedido)
        {
            objLogic = new Logic();
            //recupero los datos de local, vendedor y segmento
            Pedido order = objLogic.getOrder(objOrder.getValueOrder());
            Local local = objLogic.getLocal(order.Descripcion_local);
            Operario seller = (Operario)cmbVendedor.SelectedItem;
            insertBasket(IdPedido,seller, local);
        }

        private void insertBasket(int idPedido, Operario seller, Local local)
        {
            string hombre = "", mujer = "", kids = "";
            if (rbHombre.Checked)
            {
                hombre = rbHombre.Text;
                objLogic.insertBasket(idPedido, local, seller, hombre);
            }
            if (rbMujer.Checked)
            {
                mujer = rbMujer.Text;
                objLogic.insertBasket(idPedido, local, seller, mujer);
            }
            if (rbKids.Checked)
            {
                kids = rbKids.Text;
                objLogic.insertBasket(idPedido, local, seller, kids);
            }
        }

        private void setRButton()
        {
            objLogic = new Logic();
            Segmento[] array = objLogic.getSegments();
            rbHombre.Text = array[0].Descripcion;
            rbMujer.Text = array[1].Descripcion;
            rbKids.Text = array[2].Descripcion;
        }

        private void resetFields()
        {
            cmbVendedor.SelectedIndex = -1;
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbKids.Checked = false;
            txtVenedor.Text = String.Empty;
            cmbVendedor.Focus();
        }
    }
}
