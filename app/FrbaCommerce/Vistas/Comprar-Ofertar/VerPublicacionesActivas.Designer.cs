namespace FrbaCommerce.Vistas.Comprar_Ofertar
{
    partial class VerPublicacionesActivas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siguientePagina_button = new System.Windows.Forms.Button();
            this.anteriorPagina_button = new System.Windows.Forms.Button();
            this.ver_button = new System.Windows.Forms.Button();
            this.preguntar_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rubros = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.buscar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroPagina = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admitePregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listadoPublicaciones);
            this.groupBox2.Location = new System.Drawing.Point(161, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 386);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publicaciones";
            // 
            // listadoPublicaciones
            // 
            this.listadoPublicaciones.AccessibleName = "listadoPublicaciones";
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.admitePregunta,
            this.tipo,
            this.estado,
            this.visibilidad});
            this.listadoPublicaciones.Location = new System.Drawing.Point(11, 19);
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.Size = new System.Drawing.Size(672, 361);
            this.listadoPublicaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siguientePagina_button);
            this.groupBox1.Controls.Add(this.anteriorPagina_button);
            this.groupBox1.Controls.Add(this.ver_button);
            this.groupBox1.Controls.Add(this.preguntar_button);
            this.groupBox1.Location = new System.Drawing.Point(161, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // siguientePagina_button
            // 
            this.siguientePagina_button.AccessibleName = "siguientePagina_button";
            this.siguientePagina_button.Location = new System.Drawing.Point(131, 19);
            this.siguientePagina_button.Name = "siguientePagina_button";
            this.siguientePagina_button.Size = new System.Drawing.Size(114, 23);
            this.siguientePagina_button.TabIndex = 4;
            this.siguientePagina_button.Text = "Siguiente pagina >";
            this.siguientePagina_button.UseVisualStyleBackColor = true;
            this.siguientePagina_button.Click += new System.EventHandler(this.siguientePagina_button_Click);
            // 
            // anteriorPagina_button
            // 
            this.anteriorPagina_button.AccessibleName = "anteriorPagina_button";
            this.anteriorPagina_button.Location = new System.Drawing.Point(11, 19);
            this.anteriorPagina_button.Name = "anteriorPagina_button";
            this.anteriorPagina_button.Size = new System.Drawing.Size(114, 23);
            this.anteriorPagina_button.TabIndex = 3;
            this.anteriorPagina_button.Text = "< Anterior pagina";
            this.anteriorPagina_button.UseVisualStyleBackColor = true;
            this.anteriorPagina_button.Click += new System.EventHandler(this.anteriorPagina_button_Click);
            // 
            // ver_button
            // 
            this.ver_button.AccessibleName = "ver_button";
            this.ver_button.Location = new System.Drawing.Point(583, 19);
            this.ver_button.Name = "ver_button";
            this.ver_button.Size = new System.Drawing.Size(100, 23);
            this.ver_button.TabIndex = 2;
            this.ver_button.Text = "Ver publicacion";
            this.ver_button.UseVisualStyleBackColor = true;
            // 
            // preguntar_button
            // 
            this.preguntar_button.AccessibleName = "preguntar_button";
            this.preguntar_button.Location = new System.Drawing.Point(419, 19);
            this.preguntar_button.Name = "preguntar_button";
            this.preguntar_button.Size = new System.Drawing.Size(158, 23);
            this.preguntar_button.TabIndex = 1;
            this.preguntar_button.Text = "Hacer una pregunta";
            this.preguntar_button.UseVisualStyleBackColor = true;
            this.preguntar_button.Click += new System.EventHandler(this.preguntar_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rubros);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.descripcion);
            this.groupBox3.Controls.Add(this.buscar_button);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 386);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar y Filtrar";
            // 
            // rubros
            // 
            this.rubros.FormattingEnabled = true;
            this.rubros.Location = new System.Drawing.Point(6, 95);
            this.rubros.Name = "rubros";
            this.rubros.Size = new System.Drawing.Size(128, 229);
            this.rubros.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rubros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion:";
            // 
            // descripcion
            // 
            this.descripcion.AccessibleName = "descripcion";
            this.descripcion.Location = new System.Drawing.Point(6, 41);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(131, 20);
            this.descripcion.TabIndex = 1;
            // 
            // buscar_button
            // 
            this.buscar_button.Location = new System.Drawing.Point(6, 333);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(131, 47);
            this.buscar_button.TabIndex = 0;
            this.buscar_button.Text = "Buscar";
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pagina:";
            // 
            // numeroPagina
            // 
            this.numeroPagina.AccessibleName = "numeroPagina";
            this.numeroPagina.AutoSize = true;
            this.numeroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numeroPagina.Location = new System.Drawing.Point(115, 412);
            this.numeroPagina.Name = "numeroPagina";
            this.numeroPagina.Size = new System.Drawing.Size(18, 20);
            this.numeroPagina.TabIndex = 6;
            this.numeroPagina.Text = "1";
            this.numeroPagina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // admitePregunta
            // 
            this.admitePregunta.DataPropertyName = "admitePregunta";
            this.admitePregunta.HeaderText = "admitePregunta";
            this.admitePregunta.Name = "admitePregunta";
            this.admitePregunta.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo_publicacion_id";
            this.tipo.Name = "tipo";
            this.tipo.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado_id";
            this.estado.Name = "estado";
            this.estado.Visible = false;
            // 
            // visibilidad
            // 
            this.visibilidad.DataPropertyName = "visibilidad";
            this.visibilidad.HeaderText = "visiblidad_id";
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Visible = false;
            // 
            // VerPublicacionesActivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 470);
            this.Controls.Add(this.numeroPagina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerPublicacionesActivas";
            this.Text = "VerPublicacionesActivas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button preguntar_button;
        private System.Windows.Forms.Button ver_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button siguientePagina_button;
        private System.Windows.Forms.Button anteriorPagina_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label numeroPagina;
        private System.Windows.Forms.CheckedListBox rubros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admitePregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilidad;

    }
}