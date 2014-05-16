namespace FrbaCommerce.Registro_de_Usuario
{
    partial class RegistroPasoUno
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
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.ComboBox();
            this.siguiente_button = new System.Windows.Forms.Button();
            this.borrar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(85, 23);
            this.username.MaxLength = 100;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(120, 20);
            this.username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(85, 49);
            this.password1.MaxLength = 100;
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(120, 20);
            this.password1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Re-Password";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(85, 75);
            this.password2.MaxLength = 100;
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(120, 20);
            this.password2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rol";
            // 
            // rol
            // 
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.rol.Location = new System.Drawing.Point(84, 100);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(121, 21);
            this.rol.TabIndex = 8;
            this.rol.TabStop = false;
            this.rol.Text = "Cliente";
            // 
            // siguiente_button
            // 
            this.siguiente_button.Location = new System.Drawing.Point(164, 156);
            this.siguiente_button.Name = "siguiente_button";
            this.siguiente_button.Size = new System.Drawing.Size(75, 23);
            this.siguiente_button.TabIndex = 9;
            this.siguiente_button.Text = "Siguiente";
            this.siguiente_button.UseVisualStyleBackColor = true;
            this.siguiente_button.Click += new System.EventHandler(this.siguiente_button_Click);
            // 
            // borrar_button
            // 
            this.borrar_button.Location = new System.Drawing.Point(17, 156);
            this.borrar_button.Name = "borrar_button";
            this.borrar_button.Size = new System.Drawing.Size(75, 23);
            this.borrar_button.TabIndex = 10;
            this.borrar_button.Text = "Borrar todo";
            this.borrar_button.UseVisualStyleBackColor = true;
            this.borrar_button.Click += new System.EventHandler(this.borrar_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.password1);
            this.groupBox1.Controls.Add(this.rol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // RegistroPasoUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borrar_button);
            this.Controls.Add(this.siguiente_button);
            this.Name = "RegistroPasoUno";
            this.Text = "Registrarse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.Button siguiente_button;
        private System.Windows.Forms.Button borrar_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}