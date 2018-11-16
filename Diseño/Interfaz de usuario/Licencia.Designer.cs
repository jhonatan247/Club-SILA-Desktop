namespace Diseño.Interfaz_de_usuario
{
    partial class Licencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l8 = new System.Windows.Forms.MaskedTextBox();
            this.l7 = new System.Windows.Forms.MaskedTextBox();
            this.l6 = new System.Windows.Forms.MaskedTextBox();
            this.l1 = new System.Windows.Forms.MaskedTextBox();
            this.l2 = new System.Windows.Forms.MaskedTextBox();
            this.l3 = new System.Windows.Forms.MaskedTextBox();
            this.l4 = new System.Windows.Forms.MaskedTextBox();
            this.l5 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bnActivar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnAceptar = new System.Windows.Forms.Button();
            this.bnCopiar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.tTransparencia = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 173);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(559, 138);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Información del producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(481, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contáctenos.";
            // 
            // lstProductos
            // 
            this.lstProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProductos.BackColor = System.Drawing.Color.Teal;
            this.lstProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.ForeColor = System.Drawing.Color.White;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.HorizontalScrollbar = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Items.AddRange(new object[] {
            "Express (Periodo de prueba terminado)",
            "Standard (Licencia registrada en éste ordenador)",
            "Professional (Registro pendiente)"});
            this.lstProductos.Location = new System.Drawing.Point(7, 180);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(429, 68);
            this.lstProductos.TabIndex = 10;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Detalles de la licencia:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.l8);
            this.panel2.Controls.Add(this.l7);
            this.panel2.Controls.Add(this.l6);
            this.panel2.Controls.Add(this.l1);
            this.panel2.Controls.Add(this.l2);
            this.panel2.Controls.Add(this.l3);
            this.panel2.Controls.Add(this.l4);
            this.panel2.Controls.Add(this.l5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bnActivar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bnAceptar);
            this.panel2.Controls.Add(this.bnCopiar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lstProductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 356);
            this.panel2.TabIndex = 12;
            // 
            // l8
            // 
            this.l8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(391, 123);
            this.l8.Mask = "999";
            this.l8.Name = "l8";
            this.l8.PasswordChar = '•';
            this.l8.Size = new System.Drawing.Size(43, 22);
            this.l8.TabIndex = 40;
            this.l8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l8.TextChanged += new System.EventHandler(this.l8_TextChanged);
            this.l8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l7
            // 
            this.l7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(336, 123);
            this.l7.Mask = "999";
            this.l7.Name = "l7";
            this.l7.PasswordChar = '•';
            this.l7.Size = new System.Drawing.Size(43, 22);
            this.l7.TabIndex = 39;
            this.l7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l7.ValidatingType = typeof(int);
            this.l7.TextChanged += new System.EventHandler(this.l7_TextChanged);
            this.l7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l6
            // 
            this.l6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(281, 123);
            this.l6.Mask = "999";
            this.l6.Name = "l6";
            this.l6.PasswordChar = '•';
            this.l6.Size = new System.Drawing.Size(43, 22);
            this.l6.TabIndex = 38;
            this.l6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l6.TextChanged += new System.EventHandler(this.l6_TextChanged);
            this.l6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l1
            // 
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(9, 123);
            this.l1.Mask = "999";
            this.l1.Name = "l1";
            this.l1.PasswordChar = '•';
            this.l1.Size = new System.Drawing.Size(43, 22);
            this.l1.TabIndex = 37;
            this.l1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l1.TextChanged += new System.EventHandler(this.l1_TextChanged);
            this.l1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l2
            // 
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(65, 123);
            this.l2.Mask = "999";
            this.l2.Name = "l2";
            this.l2.PasswordChar = '•';
            this.l2.Size = new System.Drawing.Size(43, 22);
            this.l2.TabIndex = 36;
            this.l2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l2.TextChanged += new System.EventHandler(this.l2_TextChanged);
            this.l2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l3
            // 
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(119, 123);
            this.l3.Mask = "999";
            this.l3.Name = "l3";
            this.l3.PasswordChar = '•';
            this.l3.Size = new System.Drawing.Size(43, 22);
            this.l3.TabIndex = 35;
            this.l3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3.TextChanged += new System.EventHandler(this.l3_TextChanged);
            this.l3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l4
            // 
            this.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(173, 123);
            this.l4.Mask = "999";
            this.l4.Name = "l4";
            this.l4.PasswordChar = '•';
            this.l4.Size = new System.Drawing.Size(43, 22);
            this.l4.TabIndex = 34;
            this.l4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l4.TextChanged += new System.EventHandler(this.l4_TextChanged);
            this.l4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // l5
            // 
            this.l5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(227, 123);
            this.l5.Mask = "999";
            this.l5.Name = "l5";
            this.l5.PasswordChar = '•';
            this.l5.Size = new System.Drawing.Size(43, 22);
            this.l5.TabIndex = 33;
            this.l5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l5.TextChanged += new System.EventHandler(this.l5_TextChanged);
            this.l5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(380, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(325, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(270, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(216, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(162, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "-";
            // 
            // bnActivar
            // 
            this.bnActivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnActivar.ForeColor = System.Drawing.Color.White;
            this.bnActivar.Location = new System.Drawing.Point(448, 122);
            this.bnActivar.Name = "bnActivar";
            this.bnActivar.Size = new System.Drawing.Size(103, 23);
            this.bnActivar.TabIndex = 9;
            this.bnActivar.Text = "Activar";
            this.bnActivar.UseVisualStyleBackColor = true;
            this.bnActivar.Click += new System.EventHandler(this.bnActivar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Código de activación:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 64);
            this.label5.TabIndex = 21;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Activación de Club Sila professional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Información de registro y típos de licencia:";
            // 
            // bnAceptar
            // 
            this.bnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnAceptar.ForeColor = System.Drawing.Color.White;
            this.bnAceptar.Location = new System.Drawing.Point(448, 299);
            this.bnAceptar.Name = "bnAceptar";
            this.bnAceptar.Size = new System.Drawing.Size(103, 23);
            this.bnAceptar.TabIndex = 12;
            this.bnAceptar.Text = "Aceptar";
            this.bnAceptar.UseVisualStyleBackColor = true;
            this.bnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnCopiar
            // 
            this.bnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCopiar.ForeColor = System.Drawing.Color.White;
            this.bnCopiar.Location = new System.Drawing.Point(448, 180);
            this.bnCopiar.Name = "bnCopiar";
            this.bnCopiar.Size = new System.Drawing.Size(103, 23);
            this.bnCopiar.TabIndex = 11;
            this.bnCopiar.Text = "Copiar información";
            this.bnCopiar.UseVisualStyleBackColor = true;
            this.bnCopiar.Click += new System.EventHandler(this.bnCopiar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lblDescripcion);
            this.panel4.Controls.Add(this.pbIcono);
            this.panel4.Location = new System.Drawing.Point(7, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 74);
            this.panel4.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 5);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(350, 450);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(343, 26);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Advertencia: este programa está protegido por las leyes de derecho de autor y otr" +
    "os tratados internacionales.";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.Location = new System.Drawing.Point(5, 5);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(50, 50);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // tTransparencia
            // 
            this.tTransparencia.Tick += new System.EventHandler(this.tTransparencia_Tick);
            // 
            // Licencia
            // 
            this.AcceptButton = this.bnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Licencia";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estádo de licencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Licencia_FormClosing);
            this.Load += new System.EventHandler(this.Licencia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bnAceptar;
        private System.Windows.Forms.Button bnCopiar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Timer tTransparencia;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnActivar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox l8;
        private System.Windows.Forms.MaskedTextBox l7;
        private System.Windows.Forms.MaskedTextBox l6;
        private System.Windows.Forms.MaskedTextBox l1;
        private System.Windows.Forms.MaskedTextBox l2;
        private System.Windows.Forms.MaskedTextBox l3;
        private System.Windows.Forms.MaskedTextBox l4;
        private System.Windows.Forms.MaskedTextBox l5;
    }
}