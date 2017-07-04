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
        private Logic objLogic;

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
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            if (checkData(user, pass))
            {
                if (user == "ventas")
                {
                    Order frmVentas = new Order();
                    frmVentas.Show();
                    this.Close();
                }
                else if (user == "asignacion")
                {
                    Assignment frmAsignador = new Assignment();
                    frmAsignador.Show();
                    this.Close();
                }
                else if (user == "facturista")
                {
                    Invoicing frmFacturista = new Invoicing();
                    frmFacturista.Show();
                    this.Close();
                }
                else if (user == "consultas")
                {
                    Queries frmConsultas = new Queries();
                    frmConsultas.Show();
                    this.Close();
                }
                else if (user == "admin")
                {
                    MdiParent.MainMenuStrip.Enabled = true;
                    MdiParent.MainMenuStrip.Visible = true;
                    this.Close();
                }

            }
        }

        private bool checkData(string user, string pass)
        {
            return objLogic.chackDataLoguin(user, pass);
        }
    }
}
