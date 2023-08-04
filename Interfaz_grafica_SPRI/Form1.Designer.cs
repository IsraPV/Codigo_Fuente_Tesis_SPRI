namespace Interface
{
    partial class FormInterface
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
            this.components = new System.ComponentModel.Container();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.btnListarPuertos = new System.Windows.Forms.Button();
            this.cboxPorts = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.lblTextBC = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCMD = new System.Windows.Forms.TabControl();
            this.TabPagina1 = new System.Windows.Forms.TabPage();
            this.btnDetenerCaptSec = new System.Windows.Forms.Button();
            this.btnCapturaSecuencial = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.TabPagina2 = new System.Windows.Forms.TabPage();
            this.btnReiniciarCfg = new System.Windows.Forms.Button();
            this.btnModoBarraColor = new System.Windows.Forms.Button();
            this.btnModoImagen = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tboxComandos = new System.Windows.Forms.TextBox();
            this.tabPagina3 = new System.Windows.Forms.TabPage();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.lblRval = new System.Windows.Forms.Label();
            this.btnEstablecer = new System.Windows.Forms.Button();
            this.lblGval = new System.Windows.Forms.Label();
            this.lblBval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.btnCMD.SuspendLayout();
            this.TabPagina1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.TabPagina2.SuspendLayout();
            this.tabPagina3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(98, 166);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(640, 537);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // btnListarPuertos
            // 
            this.btnListarPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPuertos.Location = new System.Drawing.Point(19, 25);
            this.btnListarPuertos.Name = "btnListarPuertos";
            this.btnListarPuertos.Size = new System.Drawing.Size(146, 40);
            this.btnListarPuertos.TabIndex = 1;
            this.btnListarPuertos.Text = "Escanear puertos";
            this.btnListarPuertos.UseVisualStyleBackColor = true;
            this.btnListarPuertos.Click += new System.EventHandler(this.btnGetPorts_Click);
            // 
            // cboxPorts
            // 
            this.cboxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPorts.FormattingEnabled = true;
            this.cboxPorts.Location = new System.Drawing.Point(185, 32);
            this.cboxPorts.Name = "cboxPorts";
            this.cboxPorts.Size = new System.Drawing.Size(137, 28);
            this.cboxPorts.TabIndex = 2;
            this.cboxPorts.SelectedIndexChanged += new System.EventHandler(this.cboxPorts_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(18, 71);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(146, 41);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Desconectado";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(120, 726);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 41);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCaptura
            // 
            this.btnCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.Location = new System.Drawing.Point(348, 726);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(121, 41);
            this.btnCaptura.TabIndex = 5;
            this.btnCaptura.Text = "Captura";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblTextBC
            // 
            this.lblTextBC.AutoSize = true;
            this.lblTextBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBC.Location = new System.Drawing.Point(13, 49);
            this.lblTextBC.Name = "lblTextBC";
            this.lblTextBC.Size = new System.Drawing.Size(120, 20);
            this.lblTextBC.TabIndex = 6;
            this.lblTextBC.Text = "Bytes recibidos:";
            this.lblTextBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(147, 49);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 20);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "...";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 85;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(13, 13);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(64, 20);
            this.lblInfo2.TabIndex = 8;
            this.lblInfo2.Text = "Estado:";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(83, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(21, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bytes procesados:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount2.Location = new System.Drawing.Point(160, 86);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(21, 20);
            this.lblCount2.TabIndex = 11;
            this.lblCount2.Text = "...";
            this.lblCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCMD
            // 
            this.btnCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCMD.Controls.Add(this.TabPagina1);
            this.btnCMD.Controls.Add(this.TabPagina2);
            this.btnCMD.Controls.Add(this.tabPagina3);
            this.btnCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMD.Location = new System.Drawing.Point(3, 3);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.SelectedIndex = 0;
            this.btnCMD.Size = new System.Drawing.Size(830, 822);
            this.btnCMD.TabIndex = 12;
            // 
            // TabPagina1
            // 
            this.TabPagina1.Controls.Add(this.btnDetenerCaptSec);
            this.TabPagina1.Controls.Add(this.btnCapturaSecuencial);
            this.TabPagina1.Controls.Add(this.btnGuardar);
            this.TabPagina1.Controls.Add(this.panelDatos);
            this.TabPagina1.Controls.Add(this.btnListarPuertos);
            this.TabPagina1.Controls.Add(this.btnCaptura);
            this.TabPagina1.Controls.Add(this.btnLimpiar);
            this.TabPagina1.Controls.Add(this.btnConectar);
            this.TabPagina1.Controls.Add(this.imageBox);
            this.TabPagina1.Controls.Add(this.cboxPorts);
            this.TabPagina1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPagina1.Location = new System.Drawing.Point(4, 29);
            this.TabPagina1.Name = "TabPagina1";
            this.TabPagina1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagina1.Size = new System.Drawing.Size(822, 789);
            this.TabPagina1.TabIndex = 0;
            this.TabPagina1.Text = "Control 1";
            this.TabPagina1.UseVisualStyleBackColor = true;
            // 
            // btnDetenerCaptSec
            // 
            this.btnDetenerCaptSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetenerCaptSec.BackColor = System.Drawing.Color.Transparent;
            this.btnDetenerCaptSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetenerCaptSec.Location = new System.Drawing.Point(696, 726);
            this.btnDetenerCaptSec.Name = "btnDetenerCaptSec";
            this.btnDetenerCaptSec.Size = new System.Drawing.Size(99, 41);
            this.btnDetenerCaptSec.TabIndex = 15;
            this.btnDetenerCaptSec.Text = "Detener";
            this.btnDetenerCaptSec.UseVisualStyleBackColor = false;
            this.btnDetenerCaptSec.Click += new System.EventHandler(this.btnDetenerCaptSec_Click);
            // 
            // btnCapturaSecuencial
            // 
            this.btnCapturaSecuencial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturaSecuencial.BackColor = System.Drawing.Color.Transparent;
            this.btnCapturaSecuencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturaSecuencial.Location = new System.Drawing.Point(525, 726);
            this.btnCapturaSecuencial.Name = "btnCapturaSecuencial";
            this.btnCapturaSecuencial.Size = new System.Drawing.Size(165, 41);
            this.btnCapturaSecuencial.TabIndex = 14;
            this.btnCapturaSecuencial.Text = "Captura sequencial";
            this.btnCapturaSecuencial.UseVisualStyleBackColor = false;
            this.btnCapturaSecuencial.Click += new System.EventHandler(this.btnCapturaSecuencial_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(19, 726);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 41);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.Controls.Add(this.lblTextBC);
            this.panelDatos.Controls.Add(this.lblCount);
            this.panelDatos.Controls.Add(this.lblInfo2);
            this.panelDatos.Controls.Add(this.lblCount2);
            this.panelDatos.Controls.Add(this.lblStatus);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Location = new System.Drawing.Point(466, 22);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(329, 125);
            this.panelDatos.TabIndex = 12;
            // 
            // TabPagina2
            // 
            this.TabPagina2.Controls.Add(this.btnReiniciarCfg);
            this.TabPagina2.Controls.Add(this.btnModoBarraColor);
            this.TabPagina2.Controls.Add(this.btnModoImagen);
            this.TabPagina2.Controls.Add(this.btnEnviar);
            this.TabPagina2.Controls.Add(this.tboxComandos);
            this.TabPagina2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPagina2.Location = new System.Drawing.Point(4, 29);
            this.TabPagina2.Name = "TabPagina2";
            this.TabPagina2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagina2.Size = new System.Drawing.Size(822, 789);
            this.TabPagina2.TabIndex = 1;
            this.TabPagina2.Text = "Control 2";
            this.TabPagina2.UseVisualStyleBackColor = true;
            // 
            // btnReiniciarCfg
            // 
            this.btnReiniciarCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarCfg.Location = new System.Drawing.Point(402, 376);
            this.btnReiniciarCfg.Name = "btnReiniciarCfg";
            this.btnReiniciarCfg.Size = new System.Drawing.Size(146, 59);
            this.btnReiniciarCfg.TabIndex = 16;
            this.btnReiniciarCfg.Text = "Reiniciar configuración";
            this.btnReiniciarCfg.UseVisualStyleBackColor = true;
            this.btnReiniciarCfg.Click += new System.EventHandler(this.btnReiniciarCfg_Click);
            // 
            // btnModoBarraColor
            // 
            this.btnModoBarraColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModoBarraColor.Location = new System.Drawing.Point(402, 511);
            this.btnModoBarraColor.Name = "btnModoBarraColor";
            this.btnModoBarraColor.Size = new System.Drawing.Size(146, 54);
            this.btnModoBarraColor.TabIndex = 15;
            this.btnModoBarraColor.Text = "Modo barra de colores";
            this.btnModoBarraColor.UseVisualStyleBackColor = true;
            this.btnModoBarraColor.Click += new System.EventHandler(this.btnModoBarraColor_Click);
            // 
            // btnModoImagen
            // 
            this.btnModoImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModoImagen.Location = new System.Drawing.Point(402, 453);
            this.btnModoImagen.Name = "btnModoImagen";
            this.btnModoImagen.Size = new System.Drawing.Size(146, 41);
            this.btnModoImagen.TabIndex = 14;
            this.btnModoImagen.Text = "Modo imagen";
            this.btnModoImagen.UseVisualStyleBackColor = true;
            this.btnModoImagen.Click += new System.EventHandler(this.btnModoImagen_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(402, 579);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(146, 55);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar comandos escritos";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // tboxComandos
            // 
            this.tboxComandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxComandos.Location = new System.Drawing.Point(23, 38);
            this.tboxComandos.Multiline = true;
            this.tboxComandos.Name = "tboxComandos";
            this.tboxComandos.Size = new System.Drawing.Size(336, 596);
            this.tboxComandos.TabIndex = 12;
            // 
            // tabPagina3
            // 
            this.tabPagina3.Controls.Add(this.lblBval);
            this.tabPagina3.Controls.Add(this.lblGval);
            this.tabPagina3.Controls.Add(this.btnEstablecer);
            this.tabPagina3.Controls.Add(this.lblRval);
            this.tabPagina3.Controls.Add(this.trackBarB);
            this.tabPagina3.Controls.Add(this.trackBarG);
            this.tabPagina3.Controls.Add(this.lblB);
            this.tabPagina3.Controls.Add(this.lblR);
            this.tabPagina3.Controls.Add(this.lblG);
            this.tabPagina3.Controls.Add(this.trackBarR);
            this.tabPagina3.Location = new System.Drawing.Point(4, 29);
            this.tabPagina3.Name = "tabPagina3";
            this.tabPagina3.Size = new System.Drawing.Size(822, 789);
            this.tabPagina3.TabIndex = 2;
            this.tabPagina3.Text = "Control 3";
            this.tabPagina3.UseVisualStyleBackColor = true;
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(271, 187);
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(246, 45);
            this.trackBarR.TabIndex = 0;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarR.Value = 10;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(218, 282);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(24, 24);
            this.lblG.TabIndex = 9;
            this.lblG.Text = "G";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(219, 199);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(23, 24);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "R";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(218, 366);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(22, 24);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(271, 270);
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(246, 45);
            this.trackBarG.TabIndex = 12;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarG.Value = 10;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(271, 354);
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(246, 45);
            this.trackBarB.TabIndex = 13;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarB.Value = 10;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // lblRval
            // 
            this.lblRval.AutoSize = true;
            this.lblRval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRval.Location = new System.Drawing.Point(542, 199);
            this.lblRval.Name = "lblRval";
            this.lblRval.Size = new System.Drawing.Size(20, 24);
            this.lblRval.TabIndex = 14;
            this.lblRval.Text = "1";
            this.lblRval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEstablecer
            // 
            this.btnEstablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecer.Location = new System.Drawing.Point(330, 479);
            this.btnEstablecer.Name = "btnEstablecer";
            this.btnEstablecer.Size = new System.Drawing.Size(121, 41);
            this.btnEstablecer.TabIndex = 15;
            this.btnEstablecer.Text = "Establecer";
            this.btnEstablecer.UseVisualStyleBackColor = true;
            this.btnEstablecer.Click += new System.EventHandler(this.btnEstablecer_Click);
            // 
            // lblGval
            // 
            this.lblGval.AutoSize = true;
            this.lblGval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGval.Location = new System.Drawing.Point(542, 282);
            this.lblGval.Name = "lblGval";
            this.lblGval.Size = new System.Drawing.Size(20, 24);
            this.lblGval.TabIndex = 16;
            this.lblGval.Text = "1";
            this.lblGval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBval
            // 
            this.lblBval.AutoSize = true;
            this.lblBval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBval.Location = new System.Drawing.Point(542, 366);
            this.lblBval.Name = "lblBval";
            this.lblBval.Size = new System.Drawing.Size(20, 24);
            this.lblBval.TabIndex = 17;
            this.lblBval.Text = "1";
            this.lblBval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 837);
            this.Controls.Add(this.btnCMD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInterface";
            this.Text = "SPRI control V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.btnCMD.ResumeLayout(false);
            this.TabPagina1.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.TabPagina2.ResumeLayout(false);
            this.TabPagina2.PerformLayout();
            this.tabPagina3.ResumeLayout(false);
            this.tabPagina3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button btnListarPuertos;
        private System.Windows.Forms.ComboBox cboxPorts;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Label lblTextBC;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl btnCMD;
        private System.Windows.Forms.TabPage TabPagina1;
        private System.Windows.Forms.TabPage TabPagina2;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button btnModoBarraColor;
        private System.Windows.Forms.Button btnModoImagen;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox tboxComandos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDetenerCaptSec;
        private System.Windows.Forms.Button btnCapturaSecuencial;
        private System.Windows.Forms.Button btnReiniciarCfg;
        private System.Windows.Forms.TabPage tabPagina3;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.Label lblRval;
        private System.Windows.Forms.Label lblBval;
        private System.Windows.Forms.Label lblGval;
        private System.Windows.Forms.Button btnEstablecer;
    }
}

