using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PedidosFacturacion
{
    public partial class AssignBasket : Form
    {
        private Logic objLogic;
        private Assignment objAssignment = new Assignment();
        private Operario invoicer;
        private Operario assignmer;

        private int IdRow;
        private int ValueRow;


        public AssignBasket()
        {
            InitializeComponent();
        }
        
        private void AsignarCanasto_Load(object sender, EventArgs e)
        {
            fillcmbAssignmer();
            fillCmbInvoicer();
            resetFilds();
            objAssignment.getBaskets(dgvCanasto);
        }

        private void cmbFacturista_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoicer = (Operario)cmbFacturista.SelectedItem;
            if (cmbFacturista.SelectedItem != null)
                txtFacturista.Text = invoicer.Legajo.ToString();
        }

        private void cmbAsignador_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignmer = (Operario)cmbAsignador.SelectedItem;
            if (cmbAsignador.SelectedItem != null)
                txtAsignador.Text = assignmer.Legajo.ToString();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            updateAssignment();
            cmbFacturista.SelectedIndex = -1;            
            txtFacturista.Text = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetFilds();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvCanasto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRow = dgvCanasto.CurrentRow.Index;           
            ValueRow = Convert.ToInt32(dgvCanasto.Rows[IdRow].Cells[0].Value);
        }

        private void fillcmbAssignmer()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los asignadores del context a una lista
                List<Operario> assignmer = objLogic.getOperators();
                //agrega los asignadores al combobox
                this.operarioBindingSource.DataSource = assignmer;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void fillCmbInvoicer()
        {
            try
            {
                objLogic = new Logic();
                //hace un bindig de los facturistas del context a una lista
                List<Operario> invoicer = objLogic.getOperators();
                //agrega los facturistas al combobox 
                this.operarioBindingSource1.DataSource = invoicer;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void updateAssignment()
        {
            try
            {
                invoicer = (Operario)cmbFacturista.SelectedItem;
                assignmer = (Operario)cmbAsignador.SelectedItem;
                objLogic = new Logic();
                //actualizo la DB
                objLogic.setInvoces(ValueRow, invoicer, assignmer, DateTime.Now);
                //actualizo el estado del pedido
                objLogic.updateStates(ValueRow, "Asignado");
                objAssignment.updateRowBasket(invoicer.Descripcion, assignmer.Descripcion, dgvCanasto, IdRow);
                dgvCanasto.Rows[IdRow].DefaultCellStyle.BackColor = Color.Yellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetFilds()
        {
            cmbAsignador.SelectedIndex = -1;
            cmbFacturista.SelectedIndex = -1;
            txtAsignador.Text = String.Empty;
            txtFacturista.Text = String.Empty;
        }

    }
}
