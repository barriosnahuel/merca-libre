﻿namespace FrbaCommerce
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.generarPublicacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comprar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.misPreguntas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.visibilidadesABM = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarseToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.registrarseToolStripMenuItem.Text = "Registrarse";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem.Text = "Nuevo";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bajaToolStripMenuItem.Text = "Eliminar";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHistorialToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // miHistorialToolStripMenuItem
            // 
            this.miHistorialToolStripMenuItem.Name = "miHistorialToolStripMenuItem";
            this.miHistorialToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.miHistorialToolStripMenuItem.Text = "Mi historial";
            this.miHistorialToolStripMenuItem.Click += new System.EventHandler(this.miHistorialToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // generarPublicacion
            // 
            this.generarPublicacion.Location = new System.Drawing.Point(391, 246);
            this.generarPublicacion.Name = "generarPublicacion";
            this.generarPublicacion.Size = new System.Drawing.Size(155, 23);
            this.generarPublicacion.TabIndex = 2;
            this.generarPublicacion.Text = "Generar Publicacion";
            this.generarPublicacion.UseVisualStyleBackColor = true;
            this.generarPublicacion.Click += new System.EventHandler(this.generarPublicacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver publicaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(222, 184);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(135, 23);
            this.comprar.TabIndex = 4;
            this.comprar.Text = "Comprar / Ofertar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "modificar publicacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 68);
            this.button3.TabIndex = 6;
            this.button3.Text = "loggearte como user id 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // misPreguntas
            // 
            this.misPreguntas.Location = new System.Drawing.Point(29, 183);
            this.misPreguntas.Name = "misPreguntas";
            this.misPreguntas.Size = new System.Drawing.Size(155, 23);
            this.misPreguntas.TabIndex = 7;
            this.misPreguntas.Text = "Preguntas que realizé";
            this.misPreguntas.UseVisualStyleBackColor = true;
            this.misPreguntas.Click += new System.EventHandler(this.misPreguntas_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 68);
            this.button4.TabIndex = 8;
            this.button4.Text = "loggearte como user id 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(222, 246);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(137, 21);
            this.btnCalificar.TabIndex = 9;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // visibilidadesABM
            // 
            this.visibilidadesABM.Location = new System.Drawing.Point(57, 72);
            this.visibilidadesABM.Name = "visibilidadesABM";
            this.visibilidadesABM.Size = new System.Drawing.Size(127, 23);
            this.visibilidadesABM.TabIndex = 10;
            this.visibilidadesABM.Text = "visibilidadesABM";
            this.visibilidadesABM.UseVisualStyleBackColor = true;
            this.visibilidadesABM.Click += new System.EventHandler(this.visibilidadesABM_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 328);
            this.Controls.Add(this.visibilidadesABM);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.misPreguntas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generarPublicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "FrbaCommerce by GOODTIMES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Button generarPublicacion;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button comprar;        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHistorialToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button misPreguntas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button visibilidadesABM;

    }
}

