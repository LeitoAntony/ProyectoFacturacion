﻿using System;
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
    public partial class FacturacionPedido : Form
    {
        private Logica objLogica = new Logica();
        private int IdFila;
        private int ValueIdFila;
        private int contadorFilas = 0;


        public FacturacionPedido()
        {
            InitializeComponent();
        }

        private void FacturacionPedido_Load(object sender, EventArgs e)
        {
            llenarComboBox();
        }

        private void btnFacturado_Click(object sender, EventArgs e)
        {
            //colocar como facturado el pedido
            objLogica.actualizarEstadoPorFecha(ValueIdFila, "Facturado");
            actualizarFila();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFila = dataGridView1.CurrentRow.Index;
            ValueIdFila = Convert.ToInt32(dataGridView1.Rows[IdFila].Cells[0].Value);
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            inicializarPedidos();
        }
        
        private void actualizarFila()
        {
            dataGridView1[4, IdFila].Value = "Facturado";
            dataGridView1[11, IdFila].Value = DateTime.Today.Date;
            dataGridView1.Rows[IdFila].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void llenarComboBox()
        {
            try
            {
                //hace un bindig de los vendedores del context a una lista
                List<Operario> operarios = objLogica.getOperarios();
                //agrega los vendedores al combobox definido por el objeto vendedorBindngSource
                this.operarioBindingSource.DataSource = operarios;

            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede generar la lista: " + e.Message);
            }
        }

        private void inicializarPedidos()
        {
            //Limpio mi grilla y reseteo el contador
            contadorFilas = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            

            Operario facturista = (Operario)cmbFacturista.SelectedItem;
            List<Pedidos> lista = new List<Pedidos>();
            //traigo desde la base de datos
            lista = objLogica.getPedidosPorFacturista(facturista);

            foreach (var item in lista)
            {
                dataGridView1.Rows.Insert(contadorFilas, item.Id, item.Numero_Local, item.Descripcion_Local,
                      item.Descripcion_Vendedor, item.Estado, item.Prioridad_, item.Hombre, item.Mujer, item.Kids
                      , item.Fecha_creacion, item.Fecha_Asignacion, item.Fecha_Facturacion,
                      item.Descripcion_Facturista, item.Descripcion_Asignador);

                if (item.Prioridad_ != null)
                {
                    if (item.Prioridad_.Trim().ToString() == "Prioridad")
                        dataGridView1.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.Red;
                }
                if (item.Estado != null)
                {
                    if (item.Estado.Trim().ToString() == "Facturado")                    
                        dataGridView1.Rows[contadorFilas].DefaultCellStyle.BackColor = Color.LightGreen;                   
                }
                this.contadorFilas = contadorFilas + 1;
            }

        }

    }
}
