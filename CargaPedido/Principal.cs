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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConsultas = new Consultas();
            frmConsultas.MdiParent = this;
            frmConsultas.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCarga = new CargaPedido();
            frmCarga.MdiParent = this;
            frmCarga.Show();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAsignacion = new AsignacionPedido();
            frmAsignacion.MdiParent = this;
            frmAsignacion.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFacturacion = new FacturacionPedido();
            frmFacturacion.MdiParent = this;
            frmFacturacion.Show();
        }


    }
}

