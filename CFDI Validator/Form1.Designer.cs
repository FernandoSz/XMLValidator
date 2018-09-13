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
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlTipos = new System.Windows.Forms.Panel();
            this.pnlDescargas = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.dtgvDescargas = new System.Windows.Forms.DataGridView();
            this.pnlVisorReportes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutaOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnRemitidas = new System.Windows.Forms.Button();
            this.btnEmitidas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnDescargas = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBuscarServer = new System.Windows.Forms.Button();
            this.btnBuscarFolder = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.directorsearch = new System.DirectoryServices.DirectorySearcher();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.lblReceptorReq = new System.Windows.Forms.Label();
            this.lblEmisorReq = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinEmision = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bntNext = new System.Windows.Forms.Button();
            this.pnlnewdowload = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTipos.SuspendLayout();
            this.pnlDescargas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDescargas)).BeginInit();
            this.pnlVisorReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlnewdowload.SuspendLayout();
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
            this.lblRFCSave.Location = new System.Drawing.Point(484, 13);
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
            this.label2.Location = new System.Drawing.Point(370, 14);
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 437);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label1";
            // 
            // pnlTipos
            // 
            this.pnlTipos.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTipos.Controls.Add(this.btnRemitidas);
            this.pnlTipos.Controls.Add(this.btnEmitidas);
            this.pnlTipos.Location = new System.Drawing.Point(0, 226);
            this.pnlTipos.Name = "pnlTipos";
            this.pnlTipos.Size = new System.Drawing.Size(201, 75);
            this.pnlTipos.TabIndex = 7;
            this.pnlTipos.Visible = false;
            // 
            // pnlDescargas
            // 
            this.pnlDescargas.BackColor = System.Drawing.Color.Silver;
            this.pnlDescargas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDescargas.Controls.Add(this.lblReportes);
            this.pnlDescargas.Controls.Add(this.dtgvDescargas);
            this.pnlDescargas.Location = new System.Drawing.Point(207, 40);
            this.pnlDescargas.Name = "pnlDescargas";
            this.pnlDescargas.Size = new System.Drawing.Size(755, 450);
            this.pnlDescargas.TabIndex = 7;
            this.pnlDescargas.Visible = false;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.Navy;
            this.lblReportes.Location = new System.Drawing.Point(229, 12);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(280, 24);
            this.lblReportes.TabIndex = 1;
            this.lblReportes.Text = "Paquetes Listos Para Descargar:";
            // 
            // dtgvDescargas
            // 
            this.dtgvDescargas.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDescargas.Location = new System.Drawing.Point(18, 49);
            this.dtgvDescargas.Name = "dtgvDescargas";
            this.dtgvDescargas.Size = new System.Drawing.Size(721, 374);
            this.dtgvDescargas.TabIndex = 0;
            // 
            // pnlVisorReportes
            // 
            this.pnlVisorReportes.BackColor = System.Drawing.Color.White;
            this.pnlVisorReportes.Controls.Add(this.btnSiguiente);
            this.pnlVisorReportes.Controls.Add(this.btnBuscarServer);
            this.pnlVisorReportes.Controls.Add(this.txtTabla);
            this.pnlVisorReportes.Controls.Add(this.txtBD);
            this.pnlVisorReportes.Controls.Add(this.txtServidor);
            this.pnlVisorReportes.Controls.Add(this.label6);
            this.pnlVisorReportes.Controls.Add(this.label5);
            this.pnlVisorReportes.Controls.Add(this.label4);
            this.pnlVisorReportes.Controls.Add(this.btnBuscarFolder);
            this.pnlVisorReportes.Controls.Add(this.txtRutaOrigen);
            this.pnlVisorReportes.Controls.Add(this.label3);
            this.pnlVisorReportes.Controls.Add(this.pictureBox2);
            this.pnlVisorReportes.Controls.Add(this.pictureBox1);
            this.pnlVisorReportes.Controls.Add(this.label1);
            this.pnlVisorReportes.Location = new System.Drawing.Point(206, 40);
            this.pnlVisorReportes.Name = "pnlVisorReportes";
            this.pnlVisorReportes.Size = new System.Drawing.Size(756, 452);
            this.pnlVisorReportes.TabIndex = 8;
            this.pnlVisorReportes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Reporte.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carpeta Origen:";
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Enabled = false;
            this.txtRutaOrigen.Location = new System.Drawing.Point(110, 259);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.Size = new System.Drawing.Size(196, 20);
            this.txtRutaOrigen.TabIndex = 4;
            this.txtRutaOrigen.Text = ".../user/Documents/XML1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Servidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Base de datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tabla:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(512, 263);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(196, 20);
            this.txtServidor.TabIndex = 9;
            this.txtServidor.Text = "FSARWQ02";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(512, 291);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(196, 20);
            this.txtBD.TabIndex = 10;
            this.txtBD.Text = "BDXML";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(512, 324);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(196, 20);
            this.txtTabla.TabIndex = 11;
            this.txtTabla.Text = "Emitidos";
            // 
            // btnRemitidas
            // 
            this.btnRemitidas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemitidas.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnRemitidas.FlatAppearance.BorderSize = 0;
            this.btnRemitidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemitidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnRemitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemitidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemitidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemitidas.Image = global::CFDI_Validator.Properties.Resources.ricibir;
            this.btnRemitidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemitidas.Location = new System.Drawing.Point(27, 37);
            this.btnRemitidas.Name = "btnRemitidas";
            this.btnRemitidas.Size = new System.Drawing.Size(173, 35);
            this.btnRemitidas.TabIndex = 9;
            this.btnRemitidas.Text = "Remitidas.";
            this.btnRemitidas.UseVisualStyleBackColor = false;
            this.btnRemitidas.Click += new System.EventHandler(this.btnRemitidas_Click);
            // 
            // btnEmitidas
            // 
            this.btnEmitidas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmitidas.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnEmitidas.FlatAppearance.BorderSize = 0;
            this.btnEmitidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmitidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnEmitidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmitidas.Image = global::CFDI_Validator.Properties.Resources.enviar;
            this.btnEmitidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitidas.Location = new System.Drawing.Point(27, 1);
            this.btnEmitidas.Name = "btnEmitidas";
            this.btnEmitidas.Size = new System.Drawing.Size(173, 36);
            this.btnEmitidas.TabIndex = 8;
            this.btnEmitidas.Text = "Emitidas.";
            this.btnEmitidas.UseVisualStyleBackColor = false;
            this.btnEmitidas.Click += new System.EventHandler(this.btnEmitidas_Click);
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
            this.btnDescargas.Location = new System.Drawing.Point(-1, 28);
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
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.Image = global::CFDI_Validator.Properties.Resources.next;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.Location = new System.Drawing.Point(606, 422);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Continuar.";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarServer
            // 
            this.btnBuscarServer.BackColor = System.Drawing.Color.White;
            this.btnBuscarServer.Image = global::CFDI_Validator.Properties.Resources.buscar;
            this.btnBuscarServer.Location = new System.Drawing.Point(715, 261);
            this.btnBuscarServer.Name = "btnBuscarServer";
            this.btnBuscarServer.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarServer.TabIndex = 12;
            this.btnBuscarServer.UseVisualStyleBackColor = false;
            // 
            // btnBuscarFolder
            // 
            this.btnBuscarFolder.BackColor = System.Drawing.Color.White;
            this.btnBuscarFolder.Image = global::CFDI_Validator.Properties.Resources.buscar;
            this.btnBuscarFolder.Location = new System.Drawing.Point(309, 259);
            this.btnBuscarFolder.Name = "btnBuscarFolder";
            this.btnBuscarFolder.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarFolder.TabIndex = 5;
            this.btnBuscarFolder.UseVisualStyleBackColor = false;
            this.btnBuscarFolder.Click += new System.EventHandler(this.btnBuscarFolder_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CFDI_Validator.Properties.Resources.basededatos;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(499, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 129);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CFDI_Validator.Properties.Resources.folder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(110, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 129);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // directorsearch
            // 
            this.directorsearch.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorsearch.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorsearch.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(315, 13);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(57, 20);
            this.lblTipoFactura.TabIndex = 0;
            this.lblTipoFactura.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "RFC Emisor:";
            // 
            // txtEmisor
            // 
            this.txtEmisor.Enabled = false;
            this.txtEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmisor.Location = new System.Drawing.Point(165, 74);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(176, 20);
            this.txtEmisor.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "RFC Receptor:";
            // 
            // txtReceptor
            // 
            this.txtReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptor.Location = new System.Drawing.Point(505, 73);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(196, 20);
            this.txtReceptor.TabIndex = 4;
            // 
            // lblReceptorReq
            // 
            this.lblReceptorReq.AutoSize = true;
            this.lblReceptorReq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptorReq.ForeColor = System.Drawing.Color.Red;
            this.lblReceptorReq.Location = new System.Drawing.Point(703, 73);
            this.lblReceptorReq.Name = "lblReceptorReq";
            this.lblReceptorReq.Size = new System.Drawing.Size(17, 19);
            this.lblReceptorReq.TabIndex = 5;
            this.lblReceptorReq.Text = "*";
            // 
            // lblEmisorReq
            // 
            this.lblEmisorReq.AutoSize = true;
            this.lblEmisorReq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisorReq.ForeColor = System.Drawing.Color.Red;
            this.lblEmisorReq.Location = new System.Drawing.Point(341, 74);
            this.lblEmisorReq.Name = "lblEmisorReq";
            this.lblEmisorReq.Size = new System.Drawing.Size(17, 19);
            this.lblEmisorReq.TabIndex = 6;
            this.lblEmisorReq.Text = "*";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(12, 165);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(126, 14);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Fecha Inicial De Emisión:";
            // 
            // lblFinEmision
            // 
            this.lblFinEmision.AutoSize = true;
            this.lblFinEmision.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinEmision.Location = new System.Drawing.Point(390, 165);
            this.lblFinEmision.Name = "lblFinEmision";
            this.lblFinEmision.Size = new System.Drawing.Size(120, 14);
            this.lblFinEmision.TabIndex = 8;
            this.lblFinEmision.Text = "Fecha Final De Emisión:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 161);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // bntNext
            // 
            this.bntNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNext.Image = global::CFDI_Validator.Properties.Resources.next;
            this.bntNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntNext.Location = new System.Drawing.Point(687, 427);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 23);
            this.bntNext.TabIndex = 11;
            this.bntNext.Text = "Continuar.";
            this.bntNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntNext.UseVisualStyleBackColor = true;
            // 
            // pnlnewdowload
            // 
            this.pnlnewdowload.BackColor = System.Drawing.Color.White;
            this.pnlnewdowload.Controls.Add(this.bntNext);
            this.pnlnewdowload.Controls.Add(this.dateTimePicker2);
            this.pnlnewdowload.Controls.Add(this.dateTimePicker1);
            this.pnlnewdowload.Controls.Add(this.lblFinEmision);
            this.pnlnewdowload.Controls.Add(this.lblInicio);
            this.pnlnewdowload.Controls.Add(this.lblEmisorReq);
            this.pnlnewdowload.Controls.Add(this.lblReceptorReq);
            this.pnlnewdowload.Controls.Add(this.txtReceptor);
            this.pnlnewdowload.Controls.Add(this.label9);
            this.pnlnewdowload.Controls.Add(this.txtEmisor);
            this.pnlnewdowload.Controls.Add(this.label8);
            this.pnlnewdowload.Controls.Add(this.lblTipoFactura);
            this.pnlnewdowload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlnewdowload.Location = new System.Drawing.Point(206, 40);
            this.pnlnewdowload.Name = "pnlnewdowload";
            this.pnlnewdowload.Size = new System.Drawing.Size(766, 452);
            this.pnlnewdowload.TabIndex = 9;
            // 
            // pnlReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 493);
            this.Controls.Add(this.pnlnewdowload);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVisorReportes);
            this.Controls.Add(this.pnlDescargas);
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
            this.pnlDescargas.ResumeLayout(false);
            this.pnlDescargas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDescargas)).EndInit();
            this.pnlVisorReportes.ResumeLayout(false);
            this.pnlVisorReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlnewdowload.ResumeLayout(false);
            this.pnlnewdowload.PerformLayout();
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
        private System.Windows.Forms.Button btnRemitidas;
        private System.Windows.Forms.Button btnEmitidas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlDescargas;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.DataGridView dtgvDescargas;
        private System.Windows.Forms.Panel pnlVisorReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarFolder;
        private System.Windows.Forms.TextBox txtRutaOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarServer;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.FolderBrowserDialog searchFolder;
        private System.DirectoryServices.DirectorySearcher directorsearch;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label lblReceptorReq;
        private System.Windows.Forms.Label lblEmisorReq;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinEmision;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Panel pnlnewdowload;
    }
}

