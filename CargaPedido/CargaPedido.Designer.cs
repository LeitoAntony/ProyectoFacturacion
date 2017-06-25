
namespace PedidosFacturacion
{
    partial class CargaPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.localBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvCanasto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanasto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Local: ";
            // 
            // cmbLocal
            // 
            this.cmbLocal.DataSource = this.localBindingSource;
            this.cmbLocal.DisplayMember = "Descripcion";
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(64, 25);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(427, 21);
            this.cmbLocal.TabIndex = 1;
            this.cmbLocal.Tag = "Local";
            this.cmbLocal.ValueMember = "Id";
            this.cmbLocal.SelectedIndexChanged += new System.EventHandler(this.cmbLocal_SelectedIndexChanged);
            // 
            // localBindingSource
            // 
            this.localBindingSource.DataSource = typeof(PedidosFacturacion.Local);
            // 
            // operarioBindingSource
            // 
            this.operarioBindingSource.DataSource = typeof(PedidosFacturacion.Operario);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2});
            this.dgvPedido.Location = new System.Drawing.Point(12, 132);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(496, 561);
            this.dgvPedido.TabIndex = 14;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick_1);
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 53.2995F;
            this.Column9.HeaderText = "Nº Pedido";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 123.3503F;
            this.Column2.HeaderText = "Local";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(64, 56);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(123, 20);
            this.txtLocal.TabIndex = 17;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(87, 92);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pedido";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.txtLocal);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbLocal);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 123);
            this.panel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nº Local:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(169, 92);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvCanasto
            // 
            this.dgvCanasto.AllowUserToAddRows = false;
            this.dgvCanasto.AllowUserToDeleteRows = false;
            this.dgvCanasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanasto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCanasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvCanasto.Location = new System.Drawing.Point(514, 132);
            this.dgvCanasto.Name = "dgvCanasto";
            this.dgvCanasto.ReadOnly = true;
            this.dgvCanasto.Size = new System.Drawing.Size(838, 561);
            this.dgvCanasto.TabIndex = 22;
            this.dgvCanasto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanasto_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 71.06599F;
            this.Column3.HeaderText = "Nº Pedido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 104.8223F;
            this.Column5.HeaderText = "Nº Local";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 104.8223F;
            this.Column6.HeaderText = "Local";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 104.8223F;
            this.Column7.HeaderText = "Legajo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 104.8223F;
            this.Column10.HeaderText = "Vendedor";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 104.8223F;
            this.Column11.HeaderText = "Segmento";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 104.8223F;
            this.Column12.HeaderText = "Fecha";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // CargaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.dgvCanasto);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.panel1);
            this.Name = "CargaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CargaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource localBindingSource;
        private System.Windows.Forms.BindingSource operarioBindingSource;
        private System.Windows.Forms.DataGridView dgvCanasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}