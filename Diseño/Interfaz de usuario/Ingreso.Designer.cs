namespace Diseño.Interfaz_de_usuario
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.bnIngresar = new System.Windows.Forms.Button();
            this.chRecordarme = new System.Windows.Forms.CheckBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUsut = new System.Windows.Forms.Label();
            this.lbContrat = new System.Windows.Forms.Label();
            this.trayBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.Acciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.capturaDePantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirProtectorDePantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbOlvidarUsuario = new System.Windows.Forms.PictureBox();
            this.lbSubTitulo = new System.Windows.Forms.Label();
            this.lOlvid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbOlvidarContraseña = new System.Windows.Forms.PictureBox();
            this.tTransparencia = new System.Windows.Forms.Timer(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuSup = new System.Windows.Forms.MenuStrip();
            this.toolAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarDesactivarSonidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.regresarAlMenúAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDiseño = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinimizado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbEstilo = new System.Windows.Forms.ToolStripComboBox();
            this.pBarra = new System.Windows.Forms.Panel();
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            this.Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOlvidarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOlvidarContraseña)).BeginInit();
            this.MenuSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txUsuario.BackColor = System.Drawing.Color.White;
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.txUsuario.Location = new System.Drawing.Point(24, 187);
            this.txUsuario.MaximumSize = new System.Drawing.Size(451, 22);
            this.txUsuario.MaxLength = 20;
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(324, 22);
            this.txUsuario.TabIndex = 0;
            this.txUsuario.Tag = "Usuario";
            this.txUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txUsuario, "Nombre de usuario, correo, o nombre de usuario alternativo.");
            this.txUsuario.Click += new System.EventHandler(this.usu_Click);
            this.txUsuario.TextChanged += new System.EventHandler(this.txUsuario_TextChanged);
            this.txUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usu_KeyDown);
            this.txUsuario.Leave += new System.EventHandler(this.txUsuario_Leave);
            // 
            // txContraseña
            // 
            this.txContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txContraseña.BackColor = System.Drawing.Color.White;
            this.txContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.txContraseña.Location = new System.Drawing.Point(24, 213);
            this.txContraseña.MaximumSize = new System.Drawing.Size(451, 22);
            this.txContraseña.MaxLength = 20;
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.PasswordChar = '•';
            this.txContraseña.Size = new System.Drawing.Size(324, 22);
            this.txContraseña.TabIndex = 1;
            this.txContraseña.Tag = "Contaseña";
            this.txContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txContraseña, "Contraseña.");
            this.txContraseña.UseSystemPasswordChar = true;
            this.txContraseña.Click += new System.EventHandler(this.contrat_Click);
            this.txContraseña.TextChanged += new System.EventHandler(this.txContraseña_TextChanged);
            this.txContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usu_KeyDown);
            this.txContraseña.Leave += new System.EventHandler(this.txContraseña_Leave);
            // 
            // bnIngresar
            // 
            this.bnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.bnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnIngresar.ForeColor = System.Drawing.Color.White;
            this.bnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnIngresar.Location = new System.Drawing.Point(0, 279);
            this.bnIngresar.Name = "bnIngresar";
            this.bnIngresar.Size = new System.Drawing.Size(400, 26);
            this.bnIngresar.TabIndex = 2;
            this.bnIngresar.Text = "Autenticar";
            this.toolTip1.SetToolTip(this.bnIngresar, "Autentificar usuario y contraseña.");
            this.bnIngresar.UseVisualStyleBackColor = false;
            this.bnIngresar.Click += new System.EventHandler(this.btning_Click);
            this.bnIngresar.MouseLeave += new System.EventHandler(this.bn_MouseLeave);
            this.bnIngresar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bn_MouseMove);
            // 
            // chRecordarme
            // 
            this.chRecordarme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chRecordarme.AutoSize = true;
            this.chRecordarme.BackColor = System.Drawing.Color.White;
            this.chRecordarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chRecordarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chRecordarme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.chRecordarme.Location = new System.Drawing.Point(19, 241);
            this.chRecordarme.Name = "chRecordarme";
            this.chRecordarme.Size = new System.Drawing.Size(100, 20);
            this.chRecordarme.TabIndex = 3;
            this.chRecordarme.Text = "Recordarme";
            this.toolTip1.SetToolTip(this.chRecordarme, "Recordar siempre mi usuario y contraseña.");
            this.chRecordarme.UseVisualStyleBackColor = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.Color.White;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbTitulo.Location = new System.Drawing.Point(0, 27);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(400, 29);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "Club Sila";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbTitulo, "Bienvenido(a), ingresa a tu cuenta.");
            // 
            // lbUsut
            // 
            this.lbUsut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbUsut.AutoSize = true;
            this.lbUsut.BackColor = System.Drawing.Color.White;
            this.lbUsut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbUsut.Location = new System.Drawing.Point(154, 188);
            this.lbUsut.Name = "lbUsut";
            this.lbUsut.Size = new System.Drawing.Size(64, 20);
            this.lbUsut.TabIndex = 6;
            this.lbUsut.Text = "Usuario";
            this.toolTip1.SetToolTip(this.lbUsut, "Nombre de usuario, correo, o nombre de usuario alternativo.");
            this.lbUsut.Click += new System.EventHandler(this.usu_Click);
            this.lbUsut.MouseLeave += new System.EventHandler(this.lOlvid_MouseLeave);
            this.lbUsut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lOlvid_MouseMove);
            // 
            // lbContrat
            // 
            this.lbContrat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbContrat.AutoSize = true;
            this.lbContrat.BackColor = System.Drawing.Color.White;
            this.lbContrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbContrat.Location = new System.Drawing.Point(140, 214);
            this.lbContrat.Name = "lbContrat";
            this.lbContrat.Size = new System.Drawing.Size(92, 20);
            this.lbContrat.TabIndex = 7;
            this.lbContrat.Text = "Contraseña";
            this.toolTip1.SetToolTip(this.lbContrat, "Contraseña.");
            this.lbContrat.Click += new System.EventHandler(this.contrat_Click);
            this.lbContrat.MouseLeave += new System.EventHandler(this.lOlvid_MouseLeave);
            this.lbContrat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lOlvid_MouseMove);
            // 
            // trayBar
            // 
            this.trayBar.ContextMenuStrip = this.Acciones;
            this.trayBar.Icon = ((System.Drawing.Icon)(resources.GetObject("trayBar.Icon")));
            this.trayBar.Text = "Ingreso";
            this.trayBar.DoubleClick += new System.EventHandler(this.trayBar_DoubleClick);
            // 
            // Acciones
            // 
            this.Acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaDePantallaToolStripMenuItem,
            this.toolStripSeparator20,
            this.abrirProtectorDePantallaToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarSesiónToolStripMenuItem});
            this.Acciones.Name = "contextMenuStrip1";
            this.Acciones.OwnerItem = this.toolAcciones;
            this.Acciones.Size = new System.Drawing.Size(214, 82);
            // 
            // capturaDePantallaToolStripMenuItem
            // 
            this.capturaDePantallaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.capturaDePantallaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completaToolStripMenuItem,
            this.formularioToolStripMenuItem});
            this.capturaDePantallaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("capturaDePantallaToolStripMenuItem.Image")));
            this.capturaDePantallaToolStripMenuItem.Name = "capturaDePantallaToolStripMenuItem";
            this.capturaDePantallaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.capturaDePantallaToolStripMenuItem.Text = "Captura de pantalla";
            // 
            // completaToolStripMenuItem
            // 
            this.completaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.completaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completaToolStripMenuItem.Image")));
            this.completaToolStripMenuItem.Name = "completaToolStripMenuItem";
            this.completaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.completaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.completaToolStripMenuItem.Text = "Captura completa";
            this.completaToolStripMenuItem.Click += new System.EventHandler(this.completaToolStripMenuItem_Click);
            // 
            // formularioToolStripMenuItem
            // 
            this.formularioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formularioToolStripMenuItem.Image")));
            this.formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            this.formularioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.formularioToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.formularioToolStripMenuItem.Text = "Capturar formulario";
            this.formularioToolStripMenuItem.Click += new System.EventHandler(this.formularioToolStripMenuItem_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(210, 6);
            // 
            // abrirProtectorDePantallaToolStripMenuItem
            // 
            this.abrirProtectorDePantallaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirProtectorDePantallaToolStripMenuItem.Image")));
            this.abrirProtectorDePantallaToolStripMenuItem.Name = "abrirProtectorDePantallaToolStripMenuItem";
            this.abrirProtectorDePantallaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirProtectorDePantallaToolStripMenuItem.Text = "Abrir protector de pantalla";
            this.abrirProtectorDePantallaToolStripMenuItem.Click += new System.EventHandler(this.abrirProtectorDePantallaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Actualizar datos.";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolAcciones
            // 
            this.toolAcciones.AutoToolTip = true;
            this.toolAcciones.DropDown = this.Acciones;
            this.toolAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.toolAcciones.Image = ((System.Drawing.Image)(resources.GetObject("toolAcciones.Image")));
            this.toolAcciones.Name = "toolAcciones";
            this.toolAcciones.Size = new System.Drawing.Size(83, 23);
            this.toolAcciones.Text = "Acciones";
            // 
            // pbOlvidarUsuario
            // 
            this.pbOlvidarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOlvidarUsuario.BackColor = System.Drawing.Color.White;
            this.pbOlvidarUsuario.Enabled = false;
            this.pbOlvidarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbOlvidarUsuario.Image")));
            this.pbOlvidarUsuario.Location = new System.Drawing.Point(349, 213);
            this.pbOlvidarUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbOlvidarUsuario.Name = "pbOlvidarUsuario";
            this.pbOlvidarUsuario.Size = new System.Drawing.Size(28, 22);
            this.pbOlvidarUsuario.TabIndex = 12;
            this.pbOlvidarUsuario.TabStop = false;
            this.toolTip1.SetToolTip(this.pbOlvidarUsuario, "Olvidar usuario guardado.\r\nNo recordar más los datos de la cuenta al iniciar.");
            this.pbOlvidarUsuario.Click += new System.EventHandler(this.pbOlvidar_Click);
            // 
            // lbSubTitulo
            // 
            this.lbSubTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTitulo.AutoSize = true;
            this.lbSubTitulo.BackColor = System.Drawing.Color.White;
            this.lbSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbSubTitulo.Location = new System.Drawing.Point(2, 59);
            this.lbSubTitulo.Name = "lbSubTitulo";
            this.lbSubTitulo.Size = new System.Drawing.Size(63, 20);
            this.lbSubTitulo.TabIndex = 14;
            this.lbSubTitulo.Text = "Ingreso";
            this.lbSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbSubTitulo, "Bienvenido(a), ingresa a tu cuenta.");
            // 
            // lOlvid
            // 
            this.lOlvid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lOlvid.AutoSize = true;
            this.lOlvid.BackColor = System.Drawing.Color.White;
            this.lOlvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOlvid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lOlvid.Location = new System.Drawing.Point(207, 243);
            this.lOlvid.Name = "lOlvid";
            this.lOlvid.Size = new System.Drawing.Size(170, 16);
            this.lOlvid.TabIndex = 15;
            this.lOlvid.Text = "¿Olviadaste tu contraseña?";
            this.toolTip1.SetToolTip(this.lOlvid, "Click para recuperar contraseña.");
            this.lOlvid.Click += new System.EventHandler(this.lOlvid_Click);
            this.lOlvid.MouseLeave += new System.EventHandler(this.lOlvid_MouseLeave);
            this.lOlvid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lOlvid_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(116, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Taekwondo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.label2, "Bienvenido(a), ingresa a tu cuenta.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(150, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Reloj análogo");
            // 
            // pbOlvidarContraseña
            // 
            this.pbOlvidarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOlvidarContraseña.BackColor = System.Drawing.Color.White;
            this.pbOlvidarContraseña.Enabled = false;
            this.pbOlvidarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pbOlvidarContraseña.Image")));
            this.pbOlvidarContraseña.Location = new System.Drawing.Point(349, 187);
            this.pbOlvidarContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbOlvidarContraseña.Name = "pbOlvidarContraseña";
            this.pbOlvidarContraseña.Size = new System.Drawing.Size(28, 22);
            this.pbOlvidarContraseña.TabIndex = 19;
            this.pbOlvidarContraseña.TabStop = false;
            this.toolTip1.SetToolTip(this.pbOlvidarContraseña, "Olvidar usuario guardado.\r\nNo recordar más los datos de la cuenta al iniciar.");
            this.pbOlvidarContraseña.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tTransparencia
            // 
            this.tTransparencia.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MenuSup
            // 
            this.MenuSup.BackColor = System.Drawing.Color.White;
            this.MenuSup.ForeColor = System.Drawing.Color.Black;
            this.MenuSup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MenuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAyuda,
            this.toolAcciones,
            this.toolStripSeparator3,
            this.toolDiseño});
            this.MenuSup.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuSup.Location = new System.Drawing.Point(0, 0);
            this.MenuSup.Name = "MenuSup";
            this.MenuSup.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuSup.Size = new System.Drawing.Size(400, 27);
            this.MenuSup.TabIndex = 11;
            this.MenuSup.Text = "menuStrip1";
            // 
            // toolAyuda
            // 
            this.toolAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolAyuda.AutoToolTip = true;
            this.toolAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem,
            this.toolStripSeparator21,
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator22,
            this.ajustesToolStripMenuItem,
            this.toolStripSeparator19,
            this.regresarAlMenúAnteriorToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.toolAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.toolAyuda.Image = ((System.Drawing.Image)(resources.GetObject("toolAyuda.Image")));
            this.toolAyuda.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolAyuda.Name = "toolAyuda";
            this.toolAyuda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolAyuda.Size = new System.Drawing.Size(69, 23);
            this.toolAyuda.Text = "Ayuda";
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.instruccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instruccionesToolStripMenuItem.Image")));
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instruccionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(228, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acercaDeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de Club Sila";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(228, 6);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarDesactivarSonidosToolStripMenuItem});
            this.ajustesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajustesToolStripMenuItem.Image")));
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // activarDesactivarSonidosToolStripMenuItem
            // 
            this.activarDesactivarSonidosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.activarDesactivarSonidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activarDesactivarSonidosToolStripMenuItem.Image")));
            this.activarDesactivarSonidosToolStripMenuItem.Name = "activarDesactivarSonidosToolStripMenuItem";
            this.activarDesactivarSonidosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.activarDesactivarSonidosToolStripMenuItem.Text = "Activar/Desactivar sonidos";
            this.activarDesactivarSonidosToolStripMenuItem.Click += new System.EventHandler(this.activarDesactivarSonidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(228, 6);
            // 
            // regresarAlMenúAnteriorToolStripMenuItem
            // 
            this.regresarAlMenúAnteriorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.regresarAlMenúAnteriorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regresarAlMenúAnteriorToolStripMenuItem.Image")));
            this.regresarAlMenúAnteriorToolStripMenuItem.Name = "regresarAlMenúAnteriorToolStripMenuItem";
            this.regresarAlMenúAnteriorToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regresarAlMenúAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.regresarAlMenúAnteriorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.regresarAlMenúAnteriorToolStripMenuItem.Text = "Minimizar formulario.";
            this.regresarAlMenúAnteriorToolStripMenuItem.Click += new System.EventHandler(this.tsmiMinimizado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolDiseño
            // 
            this.toolDiseño.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolDiseño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.toolDiseño.Image = ((System.Drawing.Image)(resources.GetObject("toolDiseño.Image")));
            this.toolDiseño.Name = "toolDiseño";
            this.toolDiseño.Size = new System.Drawing.Size(71, 23);
            this.toolDiseño.Text = "Diseño";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem17});
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem11.Text = "Formulario";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.tsmiMinimizado});
            this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem13.Text = "Tamaño";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem14.Text = "Grande";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem15.Text = "Normal";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // tsmiMinimizado
            // 
            this.tsmiMinimizado.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMinimizado.Image")));
            this.tsmiMinimizado.Name = "tsmiMinimizado";
            this.tsmiMinimizado.Size = new System.Drawing.Size(137, 22);
            this.tsmiMinimizado.Text = "Minimizado";
            this.tsmiMinimizado.Click += new System.EventHandler(this.tsmiMinimizado_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbEstilo});
            this.toolStripMenuItem17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem17.Image")));
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem17.Text = "Color";
            // 
            // cbEstilo
            // 
            this.cbEstilo.Items.AddRange(new object[] {
            "Azul",
            "Verde",
            "Rojo",
            "Morado",
            "Naranja",
            "Agua marina",
            "Tomate",
            "Oro",
            "Turquesa"});
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(121, 23);
            this.cbEstilo.SelectedIndexChanged += new System.EventHandler(this.cbEstilo_SelectedIndexChanged);
            // 
            // pBarra
            // 
            this.pBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.pBarra.Location = new System.Drawing.Point(0, 56);
            this.pBarra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pBarra.Name = "pBarra";
            this.pBarra.Size = new System.Drawing.Size(370, 3);
            this.pBarra.TabIndex = 13;
            // 
            // tReloj
            // 
            this.tReloj.Interval = 1000;
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 305);
            this.Controls.Add(this.pbOlvidarContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lOlvid);
            this.Controls.Add(this.bnIngresar);
            this.Controls.Add(this.pBarra);
            this.Controls.Add(this.pbOlvidarUsuario);
            this.Controls.Add(this.lbContrat);
            this.Controls.Add(this.lbUsut);
            this.Controls.Add(this.chRecordarme);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbSubTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.MenuSup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 298);
            this.Name = "Ingreso";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Sila - Ingreso";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingg);
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.LocationChanged += new System.EventHandler(this.Ingreso_LocationChanged);
            this.Resize += new System.EventHandler(this.Ingreso_Resize);
            this.Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOlvidarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOlvidarContraseña)).EndInit();
            this.MenuSup.ResumeLayout(false);
            this.MenuSup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.CheckBox chRecordarme;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUsut;
        private System.Windows.Forms.Label lbContrat;
        private System.Windows.Forms.Button bnIngresar;
        private System.Windows.Forms.NotifyIcon trayBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tTransparencia;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.MenuStrip MenuSup;
        private System.Windows.Forms.ToolStripMenuItem toolAyuda;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarDesactivarSonidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Acciones;
        private System.Windows.Forms.ToolStripMenuItem capturaDePantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarAlMenúAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pbOlvidarUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolAcciones;
        private System.Windows.Forms.ToolStripMenuItem toolDiseño;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinimizado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripComboBox cbEstilo;
        private System.Windows.Forms.Panel pBarra;
        private System.Windows.Forms.Label lbSubTitulo;
        private System.Windows.Forms.Label lOlvid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbOlvidarContraseña;
        private System.Windows.Forms.ToolStripMenuItem abrirProtectorDePantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer tReloj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

