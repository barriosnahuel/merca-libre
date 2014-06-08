namespace FrbaCommerce.Vistas.Gestion_de_Preguntas
{
    partial class PreguntasRealizadas
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
            this.listadoPreguntas = new System.Windows.Forms.DataGridView();
            this.fechaPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listadoPreguntas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preguntas realizadas";
            // 
            // listadoPreguntas
            // 
            this.listadoPreguntas.AccessibleName = "listadoPreguntas";
            this.listadoPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaPregunta,
            this.publicacion,
            this.pregunta,
            this.publicacionDescripcion,
            this.respuesta,
            this.id,
            this.usuario_id,
            this.fechaRespuesta});
            this.listadoPreguntas.Location = new System.Drawing.Point(6, 19);
            this.listadoPreguntas.Name = "listadoPreguntas";
            this.listadoPreguntas.Size = new System.Drawing.Size(572, 167);
            this.listadoPreguntas.TabIndex = 0;
            // 
            // fechaPregunta
            // 
            this.fechaPregunta.DataPropertyName = "fechaPregunta";
            this.fechaPregunta.HeaderText = "Fecha";
            this.fechaPregunta.Name = "fechaPregunta";
            this.fechaPregunta.ReadOnly = true;
            // 
            // publicacion
            // 
            this.publicacion.DataPropertyName = "publicacion";
            this.publicacion.HeaderText = "publicacion";
            this.publicacion.Name = "publicacion";
            this.publicacion.Visible = false;
            // 
            // pregunta
            // 
            this.pregunta.DataPropertyName = "pregunta";
            this.pregunta.HeaderText = "Pregunta";
            this.pregunta.Name = "pregunta";
            this.pregunta.ReadOnly = true;
            // 
            // publicacionDescripcion
            // 
            this.publicacionDescripcion.DataPropertyName = "publicacionDescripcion";
            this.publicacionDescripcion.HeaderText = "Publicacion";
            this.publicacionDescripcion.Name = "publicacionDescripcion";
            // 
            // respuesta
            // 
            this.respuesta.DataPropertyName = "respuesta";
            this.respuesta.HeaderText = "Respuesta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // usuario_id
            // 
            this.usuario_id.DataPropertyName = "usuario_id";
            this.usuario_id.HeaderText = "usuario_id";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.Visible = false;
            // 
            // fechaRespuesta
            // 
            this.fechaRespuesta.DataPropertyName = "fechaRespuesta";
            this.fechaRespuesta.HeaderText = "Fecha respuesta";
            this.fechaRespuesta.Name = "fechaRespuesta";
            this.fechaRespuesta.Visible = false;
            // 
            // PreguntasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "PreguntasRealizadas";
            this.Text = "PreguntasRealizadas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listadoPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRespuesta;
    }
}