namespace PedidosFacturacion
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtPopUp = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrioridad = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.localBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvPedido.Location = new System.Drawing.Point(12, 193);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.Size = new System.Drawing.Size(1340, 420);
            this.dgvPedido.TabIndex = 2;
            this.dgvPedido.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedido_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Id Pedido";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero Local";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Local";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Legajo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vendedor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prioridad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Segmento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fecha creación";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Fecha asignación";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Fecha facturación";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Asignador";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Facturista";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(1027, 619);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(1197, 619);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(75, 23);
            this.btnSig.TabIndex = 4;
            this.btnSig.Text = ">";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1278, 619);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(1130, 624);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(40, 13);
            this.lblPagina.TabIndex = 6;
            this.lblPagina.Text = "Página";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtPopUp
            // 
            this.txtPopUp.Enabled = false;
            this.txtPopUp.Location = new System.Drawing.Point(715, 228);
            this.txtPopUp.Multiline = true;
            this.txtPopUp.Name = "txtPopUp";
            this.txtPopUp.ReadOnly = true;
            this.txtPopUp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPopUp.Size = new System.Drawing.Size(557, 200);
            this.txtPopUp.TabIndex = 13;
            this.txtPopUp.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1234, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 23);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "✓";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(955, 67);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtComentario
            // 
            this.txtComentario.AcceptsReturn = true;
            this.txtComentario.AcceptsTab = true;
            this.txtComentario.Location = new System.Drawing.Point(380, 69);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(557, 20);
            this.txtComentario.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Comentario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Marcar como prioridad:";
            // 
            // btnPrioridad
            // 
            this.btnPrioridad.Location = new System.Drawing.Point(515, -1);
            this.btnPrioridad.Name = "btnPrioridad";
            this.btnPrioridad.Size = new System.Drawing.Size(75, 23);
            this.btnPrioridad.TabIndex = 21;
            this.btnPrioridad.Text = "Prioridad";
            this.btnPrioridad.UseVisualStyleBackColor = true;
            this.btnPrioridad.Click += new System.EventHandler(this.btnPrioridad_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 23;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Location = new System.Drawing.Point(12, 92);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(200, 21);
            this.cmbBusqueda.TabIndex = 25;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Criterio de busqueda:";
            // 
            // btmConsultar
            // 
            this.btmConsultar.Location = new System.Drawing.Point(218, 33);
            this.btmConsultar.Name = "btmConsultar";
            this.btmConsultar.Size = new System.Drawing.Size(75, 23);
            this.btmConsultar.TabIndex = 24;
            this.btmConsultar.Text = "Consultar";
            this.btmConsultar.UseVisualStyleBackColor = true;
            this.btmConsultar.Click += new System.EventHandler(this.btmConsultar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha de consulta:";
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataSource = typeof(PedidosFacturacion.Pedido);
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = typeof(PedidosFacturacion.Estado);
            // 
            // cmbLocal
            // 
            this.cmbLocal.DataSource = this.localBindingSource;
            this.cmbLocal.DisplayMember = "Descripcion";
            this.cmbLocal.Enabled = false;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(12, 151);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(199, 21);
            this.cmbLocal.TabIndex = 28;
            this.cmbLocal.ValueMember = "Id";
            this.cmbLocal.SelectedIndexChanged += new System.EventHandler(this.cmbLocal_SelectedIndexChanged);
            // 
            // localBindingSource
            // 
            this.localBindingSource.DataSource = typeof(PedidosFacturacion.Local);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrioridad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtPopUp);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvPedido);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblPagina;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private System.Windows.Forms.TextBox txtPopUp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrioridad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.BindingSource localBindingSource;
    }
}