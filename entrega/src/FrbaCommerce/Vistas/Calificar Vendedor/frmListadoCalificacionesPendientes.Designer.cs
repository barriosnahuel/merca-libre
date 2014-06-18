namespace FrbaCommerce.Vistas.Calificar_Vendedor
{
    partial class frmListadoCalificacionesPendientes
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
            this.dgvCalificacionesPendientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCalificacionesPendientes
            // 
            this.dgvCalificacionesPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificacionesPendientes.Location = new System.Drawing.Point(12, 12);
            this.dgvCalificacionesPendientes.Name = "dgvCalificacionesPendientes";
            this.dgvCalificacionesPendientes.Size = new System.Drawing.Size(650, 351);
            this.dgvCalificacionesPendientes.TabIndex = 0;
            this.dgvCalificacionesPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificacionesPendientes_CellContentClick);
            // 
            // frmListadoCalificacionesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 375);
            this.Controls.Add(this.dgvCalificacionesPendientes);
            this.Name = "frmListadoCalificacionesPendientes";
            this.Text = "Calificaciones pendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalificacionesPendientes;
    }
}