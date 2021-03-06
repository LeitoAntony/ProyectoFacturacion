﻿using PedidosFacturacion.Views;
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
            Queries frmConsultas = new Queries();
            frmConsultas.MdiParent = this;
            frmConsultas.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order frmCarga = new Order();
            frmCarga.MdiParent = this;
            frmCarga.Show();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assignment frmAsignacion = new Assignment();
            frmAsignacion.MdiParent = this;
            frmAsignacion.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoicing frmFacturacion = new Invoicing();
            frmFacturacion.MdiParent = this;
            frmFacturacion.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            menuStrip1.Visible = false;
            Login frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.Show();
            
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM frmABM = new ABM();
            frmABM.MdiParent = this;
            frmABM.Show();
        }


    }
}

