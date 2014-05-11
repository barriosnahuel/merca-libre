namespace FrbaCommerce.Vistas.Registro_de_Usuario
{
    partial class VentanaError
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
            this.cerrar_button = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cerrar_button
            // 
            this.cerrar_button.Location = new System.Drawing.Point(162, 40);
            this.cerrar_button.Name = "cerrar_button";
            this.cerrar_button.Size = new System.Drawing.Size(75, 23);
            this.cerrar_button.TabIndex = 11;
            this.cerrar_button.Text = "Cerrar";
            this.cerrar_button.UseVisualStyleBackColor = true;
            this.cerrar_button.Click += new System.EventHandler(this.cerrar_button_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(12, 9);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 13);
            this.mensaje.TabIndex = 10;
            // 
            // Error
            // 
            this.AccessibleName = "ventana";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 71);
            this.Controls.Add(this.cerrar_button);
            this.Controls.Add(this.mensaje);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrar_button;
        private System.Windows.Forms.Label mensaje;
    }
}