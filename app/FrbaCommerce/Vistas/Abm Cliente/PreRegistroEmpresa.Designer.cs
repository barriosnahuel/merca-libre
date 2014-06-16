namespace FrbaCommerce.Vistas.Abm_Cliente
{
    partial class PreRegistroEmpresa
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
            this.username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(76, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 20);
            this.username.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siguiente >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreRegistroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 53);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.Name = "PreRegistroEmpresa";
            this.Text = "PreRegistroEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
    }
}