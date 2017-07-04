namespace PedidosFacturacion
{
    partial class AssignBasket
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacturista = new System.Windows.Forms.TextBox();
            this.txtAsignador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFacturista = new System.Windows.Forms.ComboBox();
            this.operarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAsignador = new System.Windows.Forms.ComboBox();
            this.operarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCanasto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanasto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFacturista);
            this.panel2.Controls.Add(this.txtAsignador);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAsignar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbFacturista);
            this.panel2.Controls.Add(this.cmbAsignador);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 132);
            this.panel2.TabIndex = 23;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(760, 95);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(679, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Legajo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Legajo:";
            // 
            // txtFacturista
            // 
            this.txtFacturista.Location = new System.Drawing.Point(692, 57);
            this.txtFacturista.Name = "txtFacturista";
            this.txtFacturista.ReadOnly = true;
            this.txtFacturista.Size = new System.Drawing.Size(143, 20);
            this.txtFacturista.TabIndex = 20;
            // 
            // txtAsignador
            // 
            this.txtAsignador.Location = new System.Drawing.Point(691, 24);
            this.txtAsignador.Name = "txtAsignador";
            this.txtAsignador.ReadOnly = true;
            this.txtAsignador.Size = new System.Drawing.Size(143, 20);
            this.txtAsignador.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Canasto:";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(598, 95);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 9;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Facturista:";
            // 
            // cmbFacturista
            // 
            this.cmbFacturista.DataSource = this.operarioBindingSource1;
            this.cmbFacturista.DisplayMember = "Descripcion";
            this.cmbFacturista.FormattingEnabled = true;
            this.cmbFacturista.Location = new System.Drawing.Point(77, 56);
            this.cmbFacturista.Name = "cmbFacturista";
            this.cmbFacturista.Size = new System.Drawing.Size(540, 21);
            this.cmbFacturista.TabIndex = 8;
            this.cmbFacturista.ValueMember = "Id";
            this.cmbFacturista.SelectedIndexChanged += new System.EventHandler(this.cmbFacturista_SelectedIndexChanged);
            // 
            // operarioBindingSource1
            // 
            this.operarioBindingSource1.DataSource = typeof(PedidosFacturacion.Operario);
            // 
            // cmbAsignador
            // 
            this.cmbAsignador.DataSource = this.operarioBindingSource;
            this.cmbAsignador.DisplayMember = "Descripcion";
            this.cmbAsignador.FormattingEnabled = true;
            this.cmbAsignador.Location = new System.Drawing.Point(77, 23);
            this.cmbAsignador.Name = "cmbAsignador";
            this.cmbAsignador.Size = new System.Drawing.Size(540, 21);
            this.cmbAsignador.TabIndex = 12;
            this.cmbAsignador.ValueMember = "Id";
            this.cmbAsignador.SelectedIndexChanged += new System.EventHandler(this.cmbAsignador_SelectedIndexChanged);
            // 
            // operarioBindingSource
            // 
            this.operarioBindingSource.DataSource = typeof(PedidosFacturacion.Operario);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asignador:";
            // 
            // dgvCanasto
            // 
            this.dgvCanasto.AllowUserToAddRows = false;
            this.dgvCanasto.AllowUserToDeleteRows = false;
            this.dgvCanasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanasto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCanasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Prioridad,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCanasto.Location = new System.Drawing.Point(0, 138);
            this.dgvCanasto.Name = "dgvCanasto";
            this.dgvCanasto.ReadOnly = true;
            this.dgvCanasto.Size = new System.Drawing.Size(848, 251);
            this.dgvCanasto.TabIndex = 24;
            this.dgvCanasto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanasto_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 71.06599F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nº Pedido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nº Local";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Local";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Vendedor";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Segmento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 104.8223F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha creación";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha asignacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Asignador";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Facturista";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // AssignBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 388);
            this.Controls.Add(this.dgvCanasto);
            this.Controls.Add(this.panel2);
            this.Name = "AssignBasket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Canasto";
            this.Load += new System.EventHandler(this.AsignarCanasto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFacturista;
        private System.Windows.Forms.ComboBox cmbAsignador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAsignador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFacturista;
        private System.Windows.Forms.BindingSource operarioBindingSource1;
        private System.Windows.Forms.BindingSource operarioBindingSource;
        private System.Windows.Forms.DataGridView dgvCanasto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}