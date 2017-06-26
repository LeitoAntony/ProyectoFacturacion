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
        private Asignacion objAsignacion = new Asignacion();
        private int IdFilaCanasto;
        private int ValueIdFilaCanasto;


        public AsignarCanasto()
        {
            InitializeComponent();
        }
        
        private void AsignarCanasto_Load(object sender, EventArgs e)
        {
            llenarCmbAsignador();
            llenarCmbFacturista();
            resetearCampos();
            objAsignacion.getCanastos(dgvCanasto);
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
            actualizarAsignacion();
            cmbFacturista.SelectedIndex = -1;            
            txtFacturista.Text = String.Empty;
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

        private void actualizarAsignacion()
        {
            try
            {
                Operario facturista = (Operario)cmbFacturista.SelectedItem;
                Operario asignador = (Operario)cmbAsignador.SelectedItem;
                objLogica = new Logica();
                //actualizo la DB con el facturista y la fecha/hora
                objLogica.setFacturista(ValueIdFilaCanasto, facturista, asignador, DateTime.Now);
                //actualizo el estado del pedido
                objLogica.actualizarEstado(ValueIdFilaCanasto, "Asignado");
               objAsignacion.actualizarFila(facturista.Descripcion, asignador.Descripcion, dgvCanasto, IdFilaCanasto);
               dgvCanasto.Rows[IdFilaCanasto].DefaultCellStyle.BackColor = Color.Yellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvCanasto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFilaCanasto = dgvCanasto.CurrentRow.Index;
            ValueIdFilaCanasto = Convert.ToInt32(dgvCanasto.Rows[IdFilaCanasto].Cells[0].Value);
            //dgvCanasto.Rows[IdFilaCanasto].DefaultCellStyle.BackColor = Color.LightGreen;
            MessageBox.Show("Fila " + IdFilaCanasto + " valor " + ValueIdFilaCanasto);

        }

        private void resetearCampos()
        {
            cmbAsignador.SelectedIndex = -1;
            cmbFacturista.SelectedIndex = -1;
            txtAsignador.Text = String.Empty;
            txtFacturista.Text = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


    }
}
