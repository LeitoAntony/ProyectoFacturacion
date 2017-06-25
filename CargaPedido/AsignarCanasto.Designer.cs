namespace PedidosFacturacion
{
    partial class AsignarCanasto
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFacturista = new System.Windows.Forms.ComboBox();
            this.cmbAsignador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAsignador = new System.Windows.Forms.TextBox();
            this.txtFacturista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.operarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 132);
            this.panel2.TabIndex = 23;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(760, 96);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asignador:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Legajo:";
            // 
            // txtAsignador
            // 
            this.txtAsignador.Location = new System.Drawing.Point(691, 24);
            this.txtAsignador.Name = "txtAsignador";
            this.txtAsignador.ReadOnly = true;
            this.txtAsignador.Size = new System.Drawing.Size(143, 20);
            this.txtAsignador.TabIndex = 20;
            // 
            // txtFacturista
            // 
            this.txtFacturista.Location = new System.Drawing.Point(692, 57);
            this.txtFacturista.Name = "txtFacturista";
            this.txtFacturista.ReadOnly = true;
            this.txtFacturista.Size = new System.Drawing.Size(143, 20);
            this.txtFacturista.TabIndex = 20;
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
            // operarioBindingSource
            // 
            this.operarioBindingSource.DataSource = typeof(PedidosFacturacion.Operario);
            // 
            // operarioBindingSource1
            // 
            this.operarioBindingSource1.DataSource = typeof(PedidosFacturacion.Operario);
            // 
            // AsignarCanasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 132);
            this.Controls.Add(this.panel2);
            this.Name = "AsignarCanasto";
            this.Text = "Asignar Canasto";
            this.Load += new System.EventHandler(this.AsignarCanasto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operarioBindingSource1)).EndInit();
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
    }
}