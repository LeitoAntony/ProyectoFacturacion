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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btmConsultar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mujerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoAsignadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAsignadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoFacturistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionFacturistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrioridad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopUp = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(7, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btmConsultar
            // 
            this.btmConsultar.Location = new System.Drawing.Point(213, 30);
            this.btmConsultar.Name = "btmConsultar";
            this.btmConsultar.Size = new System.Drawing.Size(75, 23);
            this.btmConsultar.TabIndex = 1;
            this.btmConsultar.Text = "Consultas";
            this.btmConsultar.UseVisualStyleBackColor = true;
            this.btmConsultar.Click += new System.EventHandler(this.btmConsultar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numeroLocalDataGridViewTextBoxColumn,
            this.descripcionLocalDataGridViewTextBoxColumn,
            this.legajoVendedorDataGridViewTextBoxColumn,
            this.descripcionVendedorDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Prioridad,
            this.fechacreacionDataGridViewTextBoxColumn,
            this.fechaAsignacionDataGridViewTextBoxColumn,
            this.fechaFacturacionDataGridViewTextBoxColumn,
            this.hombreDataGridViewTextBoxColumn,
            this.mujerDataGridViewTextBoxColumn,
            this.kidsDataGridViewTextBoxColumn,
            this.legajoAsignadorDataGridViewTextBoxColumn,
            this.descripcionAsignadorDataGridViewTextBoxColumn,
            this.legajoFacturistaDataGridViewTextBoxColumn,
            this.descripcionFacturistaDataGridViewTextBoxColumn});
            this.dgvPedido.DataSource = this.pedidosBindingSource;
            this.dgvPedido.Location = new System.Drawing.Point(12, 76);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.Size = new System.Drawing.Size(1340, 537);
            this.dgvPedido.TabIndex = 2;
            this.dgvPedido.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedido_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // numeroLocalDataGridViewTextBoxColumn
            // 
            this.numeroLocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroLocalDataGridViewTextBoxColumn.DataPropertyName = "Numero_Local";
            this.numeroLocalDataGridViewTextBoxColumn.HeaderText = "Numero Local";
            this.numeroLocalDataGridViewTextBoxColumn.Name = "numeroLocalDataGridViewTextBoxColumn";
            this.numeroLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionLocalDataGridViewTextBoxColumn
            // 
            this.descripcionLocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionLocalDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Local";
            this.descripcionLocalDataGridViewTextBoxColumn.HeaderText = "Descripcion Local";
            this.descripcionLocalDataGridViewTextBoxColumn.Name = "descripcionLocalDataGridViewTextBoxColumn";
            this.descripcionLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoVendedorDataGridViewTextBoxColumn
            // 
            this.legajoVendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.legajoVendedorDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Vendedor";
            this.legajoVendedorDataGridViewTextBoxColumn.HeaderText = "Legajo Vendedor";
            this.legajoVendedorDataGridViewTextBoxColumn.Name = "legajoVendedorDataGridViewTextBoxColumn";
            this.legajoVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionVendedorDataGridViewTextBoxColumn
            // 
            this.descripcionVendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionVendedorDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Vendedor";
            this.descripcionVendedorDataGridViewTextBoxColumn.HeaderText = "Descripcion Vendedor";
            this.descripcionVendedorDataGridViewTextBoxColumn.Name = "descripcionVendedorDataGridViewTextBoxColumn";
            this.descripcionVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prioridad.DataPropertyName = "Prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // fechacreacionDataGridViewTextBoxColumn
            // 
            this.fechacreacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechacreacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.HeaderText = "Fecha Creacion";
            this.fechacreacionDataGridViewTextBoxColumn.Name = "fechacreacionDataGridViewTextBoxColumn";
            this.fechacreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAsignacionDataGridViewTextBoxColumn
            // 
            this.fechaAsignacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaAsignacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Asignacion";
            this.fechaAsignacionDataGridViewTextBoxColumn.HeaderText = "Fecha Asignacion";
            this.fechaAsignacionDataGridViewTextBoxColumn.Name = "fechaAsignacionDataGridViewTextBoxColumn";
            this.fechaAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFacturacionDataGridViewTextBoxColumn
            // 
            this.fechaFacturacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaFacturacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Facturacion";
            this.fechaFacturacionDataGridViewTextBoxColumn.HeaderText = "Fecha Facturacion";
            this.fechaFacturacionDataGridViewTextBoxColumn.Name = "fechaFacturacionDataGridViewTextBoxColumn";
            this.fechaFacturacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hombreDataGridViewTextBoxColumn
            // 
            this.hombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hombreDataGridViewTextBoxColumn.DataPropertyName = "Hombre";
            this.hombreDataGridViewTextBoxColumn.HeaderText = "Hombre";
            this.hombreDataGridViewTextBoxColumn.Name = "hombreDataGridViewTextBoxColumn";
            this.hombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mujerDataGridViewTextBoxColumn
            // 
            this.mujerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mujerDataGridViewTextBoxColumn.DataPropertyName = "Mujer";
            this.mujerDataGridViewTextBoxColumn.HeaderText = "Mujer";
            this.mujerDataGridViewTextBoxColumn.Name = "mujerDataGridViewTextBoxColumn";
            this.mujerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kidsDataGridViewTextBoxColumn
            // 
            this.kidsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kidsDataGridViewTextBoxColumn.DataPropertyName = "Kids";
            this.kidsDataGridViewTextBoxColumn.HeaderText = "Kids";
            this.kidsDataGridViewTextBoxColumn.Name = "kidsDataGridViewTextBoxColumn";
            this.kidsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoAsignadorDataGridViewTextBoxColumn
            // 
            this.legajoAsignadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.legajoAsignadorDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Asignador";
            this.legajoAsignadorDataGridViewTextBoxColumn.HeaderText = "Legajo Asignador";
            this.legajoAsignadorDataGridViewTextBoxColumn.Name = "legajoAsignadorDataGridViewTextBoxColumn";
            this.legajoAsignadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionAsignadorDataGridViewTextBoxColumn
            // 
            this.descripcionAsignadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionAsignadorDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Asignador";
            this.descripcionAsignadorDataGridViewTextBoxColumn.HeaderText = "Descripcion Asignador";
            this.descripcionAsignadorDataGridViewTextBoxColumn.Name = "descripcionAsignadorDataGridViewTextBoxColumn";
            this.descripcionAsignadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoFacturistaDataGridViewTextBoxColumn
            // 
            this.legajoFacturistaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.legajoFacturistaDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Facturista";
            this.legajoFacturistaDataGridViewTextBoxColumn.HeaderText = "Legajo Facturista";
            this.legajoFacturistaDataGridViewTextBoxColumn.Name = "legajoFacturistaDataGridViewTextBoxColumn";
            this.legajoFacturistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionFacturistaDataGridViewTextBoxColumn
            // 
            this.descripcionFacturistaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionFacturistaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Facturista";
            this.descripcionFacturistaDataGridViewTextBoxColumn.HeaderText = "Descripcion Facturista";
            this.descripcionFacturistaDataGridViewTextBoxColumn.Name = "descripcionFacturistaDataGridViewTextBoxColumn";
            this.descripcionFacturistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataSource = typeof(PedidosFacturacion.Pedidos);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(1070, 619);
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
            this.lblPagina.Location = new System.Drawing.Point(1151, 624);
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
            // btnPrioridad
            // 
            this.btnPrioridad.Location = new System.Drawing.Point(426, 30);
            this.btnPrioridad.Name = "btnPrioridad";
            this.btnPrioridad.Size = new System.Drawing.Size(75, 23);
            this.btnPrioridad.TabIndex = 9;
            this.btnPrioridad.Text = "Prioridad";
            this.btnPrioridad.UseVisualStyleBackColor = true;
            this.btnPrioridad.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marcar como prioridad:";
            // 
            // txtComentario
            // 
            this.txtComentario.AcceptsReturn = true;
            this.txtComentario.AcceptsTab = true;
            this.txtComentario.Location = new System.Drawing.Point(590, 33);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(557, 20);
            this.txtComentario.TabIndex = 11;
            this.txtComentario.MouseEnter += new System.EventHandler(this.txtComentario_MouseEnter);
            this.txtComentario.MouseLeave += new System.EventHandler(this.txtComentario_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Comentario:";
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
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1169, 30);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btmConsultar);
            this.panel1.Controls.Add(this.btnPrioridad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 58);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consultas";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = typeof(PedidosFacturacion.Estados);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btmConsultar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblPagina;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private System.Windows.Forms.Button btnPrioridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsignacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mujerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoAsignadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAsignadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoFacturistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionFacturistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPopUp;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}