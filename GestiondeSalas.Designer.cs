namespace Visionary_Arts_Cinema
{
    partial class GestiondeSalas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSala = new System.Windows.Forms.Label();
            this.btnAgregarSala = new System.Windows.Forms.Button();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.lblSala);
            this.panel1.Controls.Add(this.btnAgregarSala);
            this.panel1.Controls.Add(this.txtSala);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 258);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 258);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 227);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.White;
            this.lblSala.Location = new System.Drawing.Point(38, 11);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(163, 24);
            this.lblSala.TabIndex = 5;
            this.lblSala.Text = "Nombre de la sala";
            // 
            // btnAgregarSala
            // 
            this.btnAgregarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.btnAgregarSala.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarSala.FlatAppearance.BorderSize = 15;
            this.btnAgregarSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAgregarSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarSala.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSala.Location = new System.Drawing.Point(40, 166);
            this.btnAgregarSala.Name = "btnAgregarSala";
            this.btnAgregarSala.Size = new System.Drawing.Size(139, 60);
            this.btnAgregarSala.TabIndex = 4;
            this.btnAgregarSala.Text = "Agregar Sala";
            this.btnAgregarSala.UseVisualStyleBackColor = false;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(42, 38);
            this.txtSala.Multiline = true;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(354, 26);
            this.txtSala.TabIndex = 3;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.White;
            this.lblCapacidad.Location = new System.Drawing.Point(36, 80);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(210, 24);
            this.lblCapacidad.TabIndex = 5;
            this.lblCapacidad.Text = "Capacidad de personas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(42, 127);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(354, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GestiondeSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "GestiondeSalas";
            this.Size = new System.Drawing.Size(656, 485);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Button btnAgregarSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
