namespace FrbaCommerce.Vistas.Gestion_de_Preguntas
{
    partial class CuadroPreguntar
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
            this.pregunta = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.Location = new System.Drawing.Point(12, 12);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(348, 96);
            this.pregunta.TabIndex = 3;
            this.pregunta.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Preguntar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuadroPreguntar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 151);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.button1);
            this.Name = "CuadroPreguntar";
            this.Text = "CuadroPreguntar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox pregunta;
        private System.Windows.Forms.Button button1;
    }
}