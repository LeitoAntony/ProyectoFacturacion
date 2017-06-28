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
    public partial class Login : Form
    {
        private Logic objLogica;

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objLogica = new Logic();
            if (txtUsuario.Text == objLogica.getUsuarioVendedor() && txtContraseña.Text == objLogica.getPassVendedor())
            {
                Order frmVentas = new Order();               
                frmVentas.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioAsignador() && txtContraseña.Text == objLogica.getPassAsignador())
            {
                Assignment frmAsignador = new Assignment();
                frmAsignador.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioFacturista() && txtContraseña.Text == objLogica.getPassFacturista())
            {
                Invoicing frmFacturista = new Invoicing();
                frmFacturista.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioConsultas() && txtContraseña.Text == objLogica.getPassConsultas())
            {
                Queries frmConsultas = new Queries();
                frmConsultas.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioAdmin() && txtContraseña.Text == objLogica.getPassAdmin())
            {
                MdiParent.MainMenuStrip.Enabled = true;
                MdiParent.MainMenuStrip.Visible = true;
                this.Close();
            }
        }

    }
}
