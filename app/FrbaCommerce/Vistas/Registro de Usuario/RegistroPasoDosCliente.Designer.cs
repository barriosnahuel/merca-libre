namespace FrbaCommerce.Vistas.Registro_de_Usuario
{
    partial class RegistroPasoDosCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.label5 = new System.Windows.Forms.Label();
            this.borrar_button = new System.Windows.Forms.Button();
            this.crear_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(147, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "2/2";
            // 
            // borrar_button
            // 
            this.borrar_button.Location = new System.Drawing.Point(17, 256);
            this.borrar_button.Name = "borrar_button";
            this.borrar_button.Size = new System.Drawing.Size(75, 23);
            this.borrar_button.TabIndex = 21;
            this.borrar_button.Text = "Borrar todo";
            this.borrar_button.UseVisualStyleBackColor = true;
            this.borrar_button.Click += new System.EventHandler(this.borrar_button_Click);
            // 
            // crear_button
            // 
            this.crear_button.Location = new System.Drawing.Point(219, 256);
            this.crear_button.Name = "crear_button";
            this.crear_button.Size = new System.Drawing.Size(75, 23);
            this.crear_button.TabIndex = 20;
            this.crear_button.Text = "Crear";
            this.crear_button.UseVisualStyleBackColor = true;
            this.crear_button.Click += new System.EventHandler(this.crear_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo y Nº Documento";
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(174, 61);
            this.documento.MaxLength = 100;
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(129, 20);
            this.documento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(119, 35);
            this.apellido.MaxLength = 100;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(156, 20);
            this.apellido.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(119, 9);
            this.nombre.MaxLength = 100;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(156, 20);
            this.nombre.TabIndex = 12;
            // 
            // tipoDoc
            // 
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.tipoDoc.Location = new System.Drawing.Point(119, 61);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(49, 21);
            this.tipoDoc.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teléfono";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(119, 113);
            this.telefono.MaxLength = 100;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(156, 20);
            this.telefono.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "E-Mail";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(119, 87);
            this.mail.MaxLength = 100;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(156, 20);
            this.mail.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Código Postal";
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(119, 139);
            this.codigoPostal.MaxLength = 100;
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(156, 20);
            this.codigoPostal.TabIndex = 28;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(119, 168);
            this.fecha.MaxDate = new System.DateTime(2109, 7, 11, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1899, 7, 21, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(156, 20);
            this.fecha.TabIndex = 32;
            this.fecha.Value = new System.DateTime(2014, 5, 10, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Dirección";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(119, 194);
            this.direccion.MaxLength = 100;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(156, 20);
            this.direccion.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Localidad";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(119, 220);
            this.localidad.MaxLength = 100;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(156, 20);
            this.localidad.TabIndex = 35;
            // 
            // RegistroPasoDosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 289);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.tipoDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrar_button);
            this.Controls.Add(this.crear_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "RegistroPasoDosCliente";
            this.Text = "RegistroPasoDos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button crear_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox localidad;
        protected System.Windows.Forms.Button borrar_button;
    }
}