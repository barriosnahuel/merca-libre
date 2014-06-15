namespace FrbaCommerce.Vistas.Login
{
    partial class Menu
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
            this.listadoFuncionalidades = new System.Windows.Forms.ComboBox();
            this.ir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cuál funcionalidad querés usar?";
            // 
            // listadoFuncionalidades
            // 
            this.listadoFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listadoFuncionalidades.FormattingEnabled = true;
            this.listadoFuncionalidades.Location = new System.Drawing.Point(30, 72);
            this.listadoFuncionalidades.Name = "listadoFuncionalidades";
            this.listadoFuncionalidades.Size = new System.Drawing.Size(193, 24);
            this.listadoFuncionalidades.TabIndex = 1;
            // 
            // ir
            // 
            this.ir.Location = new System.Drawing.Point(229, 72);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(100, 24);
            this.ir.TabIndex = 2;
            this.ir.Text = "Ir";
            this.ir.UseVisualStyleBackColor = true;
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.listadoFuncionalidades);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listadoFuncionalidades;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.Button button1;
    }
}