namespace CFDI_Validator
{
    partial class pnlReporte
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRFCSave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnDescargas = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlTipos = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlDescargas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblRFCSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 39);
            this.panel1.TabIndex = 5;
            // 
            // lblRFCSave
            // 
            this.lblRFCSave.AutoSize = true;
            this.lblRFCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFCSave.ForeColor = System.Drawing.Color.White;
            this.lblRFCSave.Location = new System.Drawing.Point(469, 13);
            this.lblRFCSave.Name = "lblRFCSave";
            this.lblRFCSave.Size = new System.Drawing.Size(86, 17);
            this.lblRFCSave.TabIndex = 8;
            this.lblRFCSave.Text = "RFC Emisor:";
            this.lblRFCSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RFC Emisor:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.pnlTipos);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.btnDescargas);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 456);
            this.panel2.TabIndex = 6;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReporte.Image = global::CFDI_Validator.Properties.Resources.reporte;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 79);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 36);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Nuevo Reporte.";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnDescargas
            // 
            this.btnDescargas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDescargas.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnDescargas.FlatAppearance.BorderSize = 0;
            this.btnDescargas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDescargas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnDescargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDescargas.Image = global::CFDI_Validator.Properties.Resources.descarga;
            this.btnDescargas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargas.Location = new System.Drawing.Point(-2, 28);
            this.btnDescargas.Name = "btnDescargas";
            this.btnDescargas.Size = new System.Drawing.Size(203, 36);
            this.btnDescargas.TabIndex = 5;
            this.btnDescargas.Text = "Descargas Disponibles.";
            this.btnDescargas.UseVisualStyleBackColor = false;
            this.btnDescargas.Click += new System.EventHandler(this.btnDescargas_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Image = global::CFDI_Validator.Properties.Resources.nuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1, 184);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(200, 36);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nueva Descarga.";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::CFDI_Validator.Properties.Resources.configuracion;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(940, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 36);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::CFDI_Validator.Properties.Resources.soporte;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Soporte.";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnlTipos
            // 
            this.pnlTipos.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTipos.Controls.Add(this.button6);
            this.pnlTipos.Controls.Add(this.button5);
            this.pnlTipos.Location = new System.Drawing.Point(0, 226);
            this.pnlTipos.Name = "pnlTipos";
            this.pnlTipos.Size = new System.Drawing.Size(201, 75);
            this.pnlTipos.TabIndex = 7;
            this.pnlTipos.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::CFDI_Validator.Properties.Resources.enviar;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(27, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Emitidas.";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = global::CFDI_Validator.Properties.Resources.ricibir;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(27, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 35);
            this.button6.TabIndex = 9;
            this.button6.Text = "Remitidas.";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 437);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label1";
            // 
            // pnlDescargas
            // 
            this.pnlDescargas.BackColor = System.Drawing.Color.Red;
            this.pnlDescargas.Location = new System.Drawing.Point(208, 45);
            this.pnlDescargas.Name = "pnlDescargas";
            this.pnlDescargas.Size = new System.Drawing.Size(751, 441);
            this.pnlDescargas.TabIndex = 7;
            this.pnlDescargas.Visible = false;
            // 
            // pnlReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 493);
            this.Controls.Add(this.pnlDescargas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "pnlReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTipos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRFCSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDescargas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel pnlTipos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlDescargas;
    }
}

