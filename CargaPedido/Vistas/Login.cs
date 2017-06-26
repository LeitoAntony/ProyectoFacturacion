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
                Form frmVentas = new CargaPedido();               
                frmVentas.Show();
            }
                
        }


    }
}
