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
        Logic objLogic = new Logic();

        public ABM()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty && txtConfirmacion.Text != string.Empty)
            {
                string pass = txtContraseña.Text;
                string confi = txtConfirmacion.Text;                
                if (pass == confi)
                {
                    string encode = Encode(pass);
                    saveUser(txtUsuario.Text, encode);
                    MessageBox.Show("Usuario creado correctamente!");
                    resetFields();
                }
                else
                    MessageBox.Show("Los datos de confirmación no corresponden!");
            }
            else
                MessageBox.Show("Complete todos los campos!");
        }

        private void resetFields()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtConfirmacion.Text = string.Empty;
            
        }

        private void saveUser(string txtUsuario, string encode)
        {
            objLogic.saveUserDB(txtUsuario, encode);
        }

        private string Decoder(string encode)
        {           
            return objLogic.Decode(encode);
        }

        private string Encode(string pass)
        {
            return objLogic.Encode(pass);
        }


        
    }
}
