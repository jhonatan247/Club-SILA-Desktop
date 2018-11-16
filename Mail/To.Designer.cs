namespace Mail
{
    partial class To
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(To));
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensaje para :";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(366, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 25);
            this.button9.TabIndex = 9;
            this.button9.Text = "Salir";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Administradores, Programadores, Entrenadores, Deportistas",
            "Administradores, Programadores,Entrenadores, Acudientes",
            "Administradores, Programadores, Deportistasa, Acudientes",
            "Administradores, Entrenadores, Deportistas, Acudientes",
            "Programadores, Entrenadores, Deportistas, Acudientes",
            "Administradores, Programadores, Entrenadores",
            "Administradores, Programadores, Deportistas",
            "Administradores, Programadores, Acudientes",
            "Administradores, Entrenadores, Deportistas",
            "Administradores, Entrenadores, Acudientes",
            "Administradores, Deportistas, Acudientes",
            "Programadores, Entrenadores, Deportistas",
            "Programadores, Entrenadores, Acudientes",
            "Programadores, Deportistas, Acudientes",
            "Entrenadores, Deportistas, Acudientes",
            "Administradores, Programadores",
            "Administradores, Entrenadores",
            "Administradores, Deportistas",
            "Administradores, Acudientes",
            "Programadores, Entrenadores",
            "Programadores, Deportistas",
            "Programadores, Acudientes",
            "Entrenadores, Deportistas",
            "Entrenadores, Acudientes",
            "Deportistas, Acudientes",
            "Administradores",
            "Programadores",
            "Entrenadores",
            "Deportistas",
            "Acudientes",
            "Administradores seleccionados",
            "Programadores seleccionados",
            "Entrenadores seleccionados",
            "Deportistas seleccionados",
            "Acudientes seleccionados",
            "Otro"});
            this.comboBox1.Location = new System.Drawing.Point(49, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(177, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // To
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "To";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}