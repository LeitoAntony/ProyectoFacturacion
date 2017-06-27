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
        private Logica objLogica;

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
            objLogica = new Logica();
            if (txtUsuario.Text == objLogica.getUsuarioVendedor() && txtContraseña.Text == objLogica.getPassVendedor())
            {
                CargaPedido frmVentas = new CargaPedido();               
                frmVentas.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioAsignador() && txtContraseña.Text == objLogica.getPassAsignador())
            {
                Asignacion frmAsignador = new Asignacion();
                frmAsignador.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioFacturista() && txtContraseña.Text == objLogica.getPassFacturista())
            {
                FacturacionPedido frmFacturista = new FacturacionPedido();
                frmFacturista.Show();
                this.Close();
            }
            else if (txtUsuario.Text == objLogica.getUsuarioConsultas() && txtContraseña.Text == objLogica.getPassConsultas())
            {
                Consultas frmConsultas = new Consultas();
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
