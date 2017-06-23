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
    public partial class CargaPedido : Form
    {
        private Logica objLogica;
        private Local local = new Local();

        private int contadorFilas = 0;
        private int IdPedido;
        private static int IdFila;
        private static int ValueIdFila;
        private bool bandera = false;

        private int contadorFilasCanasto = 0;
        private int IdCanasto;
        private int IdFilaCanasto;
        private int ValueIdFilaCanasto;
        private bool banderaCanasto = false;

        Form frmCargaCanasto;
        public CargaPedido()
        {
            InitializeComponent();
        }

        private void CargaPedido_Load(object sender, EventArgs e)
        {
            llenarCombo();
            setRButton();
            inicializarPedidos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //chequeo de campos completos
            if (cmbLocal.SelectedItem != null)
            {
                //inserto los objetos en la base
                insertarPedidoDB();
                //cargo el pedido en los comboBox
                cargarPedido();

            }
            else
            {
                MessageBox.Show("Complete el campo Local! ");
            }
        }

        private void btnAgregarCanasto_Click(object sender, EventArgs e)
        {
            if (rbHombre.Checked || rbMujer.Checked || rbKids.Checked)
            {
                insertarCanastoDB();
                cargarCanasto();
            }
            else
                MessageBox.Show("Complete todos los campos! ", "Advertencia!");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (contadorFilas > 0 && bandera)
                if (contadorFilasCanasto == 0)
                {
                    if (MessageBox.Show("Estas seguro que desas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        eliminarPedido();
                        eliminarPedidoDB();
                    }
                }
                else
                    MessageBox.Show("Tiene canastos relacionados. Eliminelos primero!", "Advertencia!");
            else
                MessageBox.Show("Debe seleccionar un pedido para borrar! ", "Advertencia!");
            bandera = false;
        }

        private void btnBorrarCanasto_Click(object sender, EventArgs e)
        {
            if(bandera && banderaCanasto)
            {
                eliminarCanasto();
                eliminarCanastoDB();
            }
            banderaCanasto = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizarPedido();
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
            getCanastos();
            //dgvPedido.Rows[IdFila].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void dgvCanasto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            banderaCanasto = true;
            IdFilaCanasto = dgvCanasto.CurrentRow.Index;
            ValueIdFilaCanasto = Convert.ToInt32(dgvCanasto.Rows[IdFilaCanasto].Cells[0].Value);
            //dgvCanasto.Rows[IdFilaCanasto].DefaultCellStyle.BackColor = Color.LightGreen;
            
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local local = (Local)cmbLocal.SelectedItem;
            if (cmbLocal.SelectedItem != null)
                txtLocal.Text = local.Numero.ToString();

        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            if (cmbVendedor.SelectedItem != null)
                txtVenedor.Text = vendedor.Legajo.ToString();
        }

        private void llenarCombo()
        {
            //completo los ComboBox
            llenarCmbVendedor();
            llenarCmbLocales();

            resetearCampos();
        }

        private void llenarCmbVendedor()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los vendedores del context a una lista
                List<Operario> vendedores = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = vendedores;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void llenarCmbLocales()
        {
            try
            {
                objLogica = new Logica();
                //hace un bindig de los locales del context a una lista
                var locales = objLogica.getLocales();
                //agrega los locales al combobox definido por el objeto localBindngSource
                this.localBindingSource.DataSource = locales;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }

        }

        private void setRButton()
        {
            objLogica = new Logica();
            Segmento[] array = objLogica.getSegmentos();
            rbHombre.Text = array[0].Descripcion;
            rbMujer.Text = array[1].Descripcion;
            rbKids.Text = array[2].Descripcion;
        }

        private void inicializarPedidos()
        {
            objLogica = new Logica();
            //traigo desde la base de datos
            List<Pedidos> pedidos = objLogica.getPedidosPorFecha(DateTime.Now);
            
            //los mapeo a la gilla
            foreach (var item in pedidos)
            {
                dgvPedido.Rows.Insert(contadorFilas, item.Id, item.Descripcion_local);
                this.contadorFilas = contadorFilas + 1;
            }   
        }
        private void getCanastos()
        {
            dgvCanasto.Rows.Clear();
            dgvCanasto.Refresh();
            contadorFilasCanasto = 0;
            objLogica = new Logica();
            List<Canasto> canastos = objLogica.getCanastosPorIdPedido(ValueIdFila);
            foreach (var item in canastos)
            {
                dgvCanasto.Rows.Insert(contadorFilasCanasto,item.Id, ValueIdFila, item.Numero_local, item.Descripcion_local, item.Legajo_vendedor,
                    item.Descripcion_vendedor, item.Segmento, item.Fecha);
                this.contadorFilasCanasto = contadorFilasCanasto + 1;
            }
        }

        private void cargarPedido()
        {
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;

            //se carga en el dataGrdView los elemenos 
            dgvPedido.Rows.Insert(contadorFilas, IdPedido, local.Descripcion);
            contadorFilas++;
        }

        private void cargarCanasto()
        {
            objLogica = new Logica();
            Canasto canasto = objLogica.getCanastoPorIdPedido(IdPedido);

                dgvCanasto.Rows.Insert(contadorFilasCanasto, canasto.Id, canasto.Numero_local, canasto.Descripcion_local, canasto.Legajo_vendedor
                    ,canasto.Descripcion_vendedor, canasto.Segmento, canasto.Fecha);
            contadorFilasCanasto++;
        }


        private void insertarPedidoDB()
        {
            objLogica = new Logica();
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            //inserto los datos en la DB y me guardo el id de ese pedido
            IdPedido = objLogica.insertarPedido(local, vendedor);
        }

        private void insertarCanastoDB()
        {
            //recupero los datos de local, vendedor y segmento
            Local local = (Local)cmbLocal.SelectedItem;
            Operario vendedor = (Operario)cmbVendedor.SelectedItem;
            string hombre = "", mujer = "", kids = "";
            if (rbHombre.Checked)
            {
                hombre = rbHombre.Text;
                IdCanasto = objLogica.insertarCanasto(IdPedido, local, vendedor, hombre);
            }
            if (rbMujer.Checked)
            {
                mujer = rbMujer.Text;
                IdCanasto = objLogica.insertarCanasto(IdPedido, local, vendedor, mujer);
            }
            if (rbKids.Checked)
            {
                kids = rbKids.Text;
                IdCanasto = objLogica.insertarCanasto(IdPedido, local, vendedor, kids);
            }
        }

        private void eliminarPedido()
        {
            //elimino la fila por su id
            dgvPedido.Rows.RemoveAt(IdFila);
            contadorFilas--;
        }

        private void eliminarPedidoDB()
        {
            objLogica = new Logica();
            //elimino los datos de la base de datos
            objLogica.eliminarPedido(ValueIdFila);
        }

        private void eliminarCanasto()
        {
            //elimino la fila por su id
            dgvCanasto.Rows.RemoveAt(IdFilaCanasto);
            contadorFilasCanasto--;
        }

        private void eliminarCanastoDB()
        {
            objLogica = new Logica();
            //elimino los datos de la base de datos
            objLogica.eliminarCanasto(ValueIdFilaCanasto);
        }

        //private void actualizarPedido()
        //{
        //    objLogica = new Logica();
        //    //recupero los datos de local, vendedor y segmento
        //    Local local = (Local)cmbLocal.SelectedItem;
        //    Operario vendedor = (Operario)cmbVendedor.SelectedItem;
        //    string hombre = "", mujer = "", kids = "";
        //    if (rbHombre.Checked)
        //        hombre = rbHombre.Text;
        //    if (rbMujer.Checked)
        //        mujer = rbMujer.Text;
        //    if (rbKids.Checked)
        //        kids = rbKids.Text;
        //    objLogica.actualizarPedido(ValueIdFila, local, vendedor, txtLocal.Text,
        //        txtVenedor.Text, hombre, mujer, kids);

        //    eliminarPedido();
        //    cargarPedido(IdFila);
        //    resetearCampos();
        //}

        private void resetearCampos()
        {
            cmbVendedor.SelectedIndex = -1;
            cmbLocal.SelectedIndex = -1;
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbKids.Checked = false;
            txtLocal.Text = String.Empty;
            txtVenedor.Text = String.Empty;
            cmbVendedor.Focus();
        }

        public int getValuePedido()
        {
            return ValueIdFila;    
        }

        public int getIdPedido()
        {
            return IdPedido;
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            IdFila = dgvPedido.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dgvPedido.Rows[IdFila].Cells[0].Value);
            MessageBox.Show("IdFila " + IdFila + "ValueIdFila " +ValueIdFila);

            frmCargaCanasto = new AgregarCanasto();
            frmCargaCanasto.Visible = true;
        }
    }
}
