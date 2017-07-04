using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosFacturacion.Views
{
    public partial class ABM : Form
    {
        ABMLogic objLogic = new ABMLogic();

        public ABM()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                string encode = Encode();
                MessageBox.Show("Pass " + encode);
            }
        }

        private string Encode()
        {
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            
            return objLogic.Encode(pass);
        }


        
    }
}
