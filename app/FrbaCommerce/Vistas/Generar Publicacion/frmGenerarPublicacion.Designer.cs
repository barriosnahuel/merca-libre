namespace FrbaCommerce.Vistas.Generar_Publicacion
{
    partial class frmGenerarPublicacion
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
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.precioLb = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoPublicacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rubros = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.visibilidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(129, 37);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(325, 61);
            this.descripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad unidades:";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(129, 133);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(53, 20);
            this.stock.TabIndex = 3;
            // 
            // precioLb
            // 
            this.precioLb.AutoSize = true;
            this.precioLb.Location = new System.Drawing.Point(279, 135);
            this.precioLb.Name = "precioLb";
            this.precioLb.Size = new System.Drawing.Size(40, 13);
            this.precioLb.TabIndex = 4;
            this.precioLb.Text = "Precio:";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(354, 135);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(121, 20);
            this.precio.TabIndex = 5;
            this.precio.Text = "00,00";
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha desde:";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(198, 190);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(224, 20);
            this.fechaDesde.TabIndex = 7;
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(198, 236);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(224, 20);
            this.fechaHasta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha hasta:";
            // 
            // tipoPublicacion
            // 
            this.tipoPublicacion.FormattingEnabled = true;
            this.tipoPublicacion.Location = new System.Drawing.Point(124, 302);
            this.tipoPublicacion.Name = "tipoPublicacion";
            this.tipoPublicacion.Size = new System.Drawing.Size(121, 21);
            this.tipoPublicacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo publicacion:";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(354, 305);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // rubros
            // 
            this.rubros.FormattingEnabled = true;
            this.rubros.Location = new System.Drawing.Point(124, 360);
            this.rubros.Name = "rubros";
            this.rubros.Size = new System.Drawing.Size(121, 94);
            this.rubros.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rubros:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Visibilidad:";
            // 
            // visibilidad
            // 
            this.visibilidad.FormattingEnabled = true;
            this.visibilidad.Location = new System.Drawing.Point(354, 360);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(121, 21);
            this.visibilidad.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.visibilidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rubros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipoPublicacion);
            this.Controls.Add(this.fechaHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.precioLb);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion);
            this.Name = "frmGenerarPublicacion";
            this.Text = "frmGenerarPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.Label precioLb;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoPublicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox rubros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox visibilidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}