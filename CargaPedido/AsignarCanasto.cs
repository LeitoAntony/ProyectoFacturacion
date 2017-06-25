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
    public partial class AsignarCanasto : Form
    {
        private Logica objLogica;

        public AsignarCanasto()
        {
            InitializeComponent();
        }
        
        private void AsignarCanasto_Load(object sender, EventArgs e)
        {
            llenarCmbAsignador();
            llenarCmbFacturista();
            cmbAsignador.SelectedIndex = -1;
            cmbFacturista.SelectedIndex = -1;
        }

        private void cmbFacturista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario facturista = (Operario)cmbFacturista.SelectedItem;
            if (cmbFacturista.SelectedItem != null)
                txtFacturista.Text = facturista.Legajo.ToString();
        }

        private void cmbAsignador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario asignador = (Operario)cmbAsignador.SelectedItem;
            if (cmbAsignador.SelectedItem != null)
                txtAsignador.Text = asignador.Legajo.ToString();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        private void llenarCmbAsignador()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> asignador = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = asignador;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void llenarCmbFacturista()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> facturista = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource1.DataSource = facturista;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        
    }
}
