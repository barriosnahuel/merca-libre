namespace FrbaCommerce.Vistas.Ver_publicaciones
{
    partial class ListadoDePublicaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.responder_button = new System.Windows.Forms.Button();
            this.modificar_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_publicacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiblidad_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eliminar_button);
            this.groupBox1.Controls.Add(this.responder_button);
            this.groupBox1.Controls.Add(this.modificar_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // eliminar_button
            // 
            this.eliminar_button.AccessibleName = "eliminar_button";
            this.eliminar_button.Location = new System.Drawing.Point(145, 21);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(133, 23);
            this.eliminar_button.TabIndex = 2;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // responder_button
            // 
            this.responder_button.AccessibleName = "responder_button";
            this.responder_button.Location = new System.Drawing.Point(554, 21);
            this.responder_button.Name = "responder_button";
            this.responder_button.Size = new System.Drawing.Size(202, 23);
            this.responder_button.TabIndex = 1;
            this.responder_button.Text = "Responder preguntas de la publicacion";
            this.responder_button.UseVisualStyleBackColor = true;
            this.responder_button.Click += new System.EventHandler(this.responder_button_Click);
            // 
            // modificar_button
            // 
            this.modificar_button.AccessibleName = "modificar_button";
            this.modificar_button.Location = new System.Drawing.Point(6, 21);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(133, 23);
            this.modificar_button.TabIndex = 0;
            this.modificar_button.Text = "Modificar";
            this.modificar_button.UseVisualStyleBackColor = true;
            this.modificar_button.Click += new System.EventHandler(this.modificar_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listadoPublicaciones);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publicaciones";
            // 
            // listadoPublicaciones
            // 
            this.listadoPublicaciones.AccessibleName = "listadoPublicaciones";
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario_id,
            this.tipo_publicacion_id,
            this.estado_id,
            this.visiblidad_id});
            this.listadoPublicaciones.Location = new System.Drawing.Point(6, 19);
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.Size = new System.Drawing.Size(750, 361);
            this.listadoPublicaciones.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "usuario_id";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.Visible = false;
            // 
            // tipo_publicacion_id
            // 
            this.tipo_publicacion_id.HeaderText = "tipo_publicacion_id";
            this.tipo_publicacion_id.Name = "tipo_publicacion_id";
            this.tipo_publicacion_id.Visible = false;
            // 
            // estado_id
            // 
            this.estado_id.HeaderText = "estado_id";
            this.estado_id.Name = "estado_id";
            this.estado_id.Visible = false;
            // 
            // visiblidad_id
            // 
            this.visiblidad_id.HeaderText = "visiblidad_id";
            this.visiblidad_id.Name = "visiblidad_id";
            this.visiblidad_id.Visible = false;
            // 
            // ListadoDePublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoDePublicaciones";
            this.Text = "ListadoDePublicaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button responder_button;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_publicacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiblidad_id;
    }
}