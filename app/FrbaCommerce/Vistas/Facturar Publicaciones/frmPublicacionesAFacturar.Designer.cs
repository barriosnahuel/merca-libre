namespace FrbaCommerce.Vistas.Facturar_Publicaciones
{
    partial class frmPublicacionesAFacturar
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
            this.dgvPublicaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCantPub = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupFormaPago = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.lblNroTarjeta = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPublicaciones
            // 
            this.dgvPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicaciones.Location = new System.Drawing.Point(6, 19);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            this.dgvPublicaciones.Size = new System.Drawing.Size(751, 312);
            this.dgvPublicaciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuantos items desea rendir?";
            // 
            // cmbCantPub
            // 
            this.cmbCantPub.FormattingEnabled = true;
            this.cmbCantPub.Location = new System.Drawing.Point(15, 368);
            this.cmbCantPub.Name = "cmbCantPub";
            this.cmbCantPub.Size = new System.Drawing.Size(134, 21);
            this.cmbCantPub.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPublicaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras / Visibilidades sin rendir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recuerde que se rinden las mas antiguas primero";
            // 
            // groupFormaPago
            // 
            this.groupFormaPago.Controls.Add(this.txtCodigo);
            this.groupFormaPago.Controls.Add(this.lblCod);
            this.groupFormaPago.Controls.Add(this.txtNroTarjeta);
            this.groupFormaPago.Controls.Add(this.lblNroTarjeta);
            this.groupFormaPago.Controls.Add(this.txtTitular);
            this.groupFormaPago.Controls.Add(this.lblTitular);
            this.groupFormaPago.Location = new System.Drawing.Point(155, 396);
            this.groupFormaPago.Name = "groupFormaPago";
            this.groupFormaPago.Size = new System.Drawing.Size(619, 46);
            this.groupFormaPago.TabIndex = 6;
            this.groupFormaPago.TabStop = false;
            this.groupFormaPago.Text = "Forma de pago";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(563, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(44, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(453, 21);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(104, 13);
            this.lblCod.TabIndex = 6;
            this.lblCod.Text = "Codigo de seguridad";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(282, 19);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(153, 20);
            this.txtNroTarjeta.TabIndex = 5;
            this.txtNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.lblNroTarjeta.Location = new System.Drawing.Point(220, 22);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(56, 13);
            this.lblNroTarjeta.TabIndex = 4;
            this.lblNroTarjeta.Text = "Nro tarjeta";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(49, 19);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(153, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(7, 22);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 2;
            this.lblTitular.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione forma de pago";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(15, 412);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(134, 21);
            this.cmbFormaPago.TabIndex = 0;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(694, 448);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // frmPublicacionesAFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 474);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupFormaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCantPub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFormaPago);
            this.Name = "frmPublicacionesAFacturar";
            this.Text = "Facturar Publicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupFormaPago.ResumeLayout(false);
            this.groupFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantPub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupFormaPago;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Label lblNroTarjeta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnPagar;
    }
}