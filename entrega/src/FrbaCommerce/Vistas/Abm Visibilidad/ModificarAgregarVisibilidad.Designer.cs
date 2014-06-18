namespace FrbaCommerce.Vistas.Abm_Visibilidad
{
    partial class ModificarAgregarVisibilidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.porcentaje = new System.Windows.Forms.TextBox();
            this.accion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(132, 21);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(128, 20);
            this.descripcion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.accion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.porcentaje);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:                        $";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(132, 47);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(73, 20);
            this.precio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcentaje Ganancia: %";
            // 
            // porcentaje
            // 
            this.porcentaje.Location = new System.Drawing.Point(132, 74);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(73, 20);
            this.porcentaje.TabIndex = 7;
            // 
            // accion
            // 
            this.accion.Location = new System.Drawing.Point(61, 139);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(158, 35);
            this.accion.TabIndex = 8;
            this.accion.Text = "Crear";
            this.accion.UseVisualStyleBackColor = true;
            this.accion.Click += new System.EventHandler(this.accion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ej: 50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(132, 100);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(128, 20);
            this.codigo.TabIndex = 11;
            // 
            // ModificarAgregarVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 198);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarAgregarVisibilidad";
            this.Text = "ModificarAgregarVisibilidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button accion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox porcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigo;
    }
}