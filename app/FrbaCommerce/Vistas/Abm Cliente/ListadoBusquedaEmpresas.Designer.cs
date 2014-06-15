namespace FrbaCommerce.Vistas.Abm_Cliente
{
    partial class ListadoBusquedaEmpresas
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
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.listadoEmpresas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_fallidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contacto_search = new System.Windows.Forms.TextBox();
            this.razon_social_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuit_search = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEmpresas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(437, 385);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 40;
            this.add_button.Text = "Agregar";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(197, 385);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 39;
            this.delete_button.Text = "Dar de baja";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // listadoEmpresas
            // 
            this.listadoEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.rol,
            this.empresa_id,
            this.login_fallidos,
            this.eliminado,
            this.razon_social,
            this.CUIT,
            this.nombreContacto,
            this.mail,
            this.telefono,
            this.codigo_postal,
            this.direccion,
            this.localidad,
            this.habilitado,
            this.fecha_creacion,
            this.username,
            this.password});
            this.listadoEmpresas.Location = new System.Drawing.Point(12, 92);
            this.listadoEmpresas.Name = "listadoEmpresas";
            this.listadoEmpresas.Size = new System.Drawing.Size(538, 287);
            this.listadoEmpresas.TabIndex = 41;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "rol";
            this.rol.Name = "rol";
            this.rol.Visible = false;
            // 
            // empresa_id
            // 
            this.empresa_id.DataPropertyName = "empresa_id";
            this.empresa_id.HeaderText = "empresa_id";
            this.empresa_id.Name = "empresa_id";
            this.empresa_id.Visible = false;
            // 
            // login_fallidos
            // 
            this.login_fallidos.DataPropertyName = "login_fallidos";
            this.login_fallidos.HeaderText = "login fallidos";
            this.login_fallidos.Name = "login_fallidos";
            this.login_fallidos.Visible = false;
            // 
            // eliminado
            // 
            this.eliminado.DataPropertyName = "eliminado";
            this.eliminado.HeaderText = "eliminado";
            this.eliminado.Name = "eliminado";
            this.eliminado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminado.Visible = false;
            // 
            // razon_social
            // 
            this.razon_social.DataPropertyName = "razon_social";
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "cuit";
            this.CUIT.HeaderText = "cuit";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // nombreContacto
            // 
            this.nombreContacto.DataPropertyName = "nombreContacto";
            this.nombreContacto.HeaderText = "Nombre de contacto";
            this.nombreContacto.Name = "nombreContacto";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "E-Mail";
            this.mail.Name = "mail";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Codigo postal";
            this.codigo_postal.Name = "codigo_postal";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "localidad";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha de Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(317, 385);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(113, 23);
            this.modify_button.TabIndex = 38;
            this.modify_button.Text = "Modificar";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(12, 63);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(113, 23);
            this.clean_button.TabIndex = 37;
            this.clean_button.Text = "Borrar todo";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contacto_search);
            this.groupBox1.Controls.Add(this.razon_social_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cuit_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 48);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // contacto_search
            // 
            this.contacto_search.Location = new System.Drawing.Point(419, 20);
            this.contacto_search.MaxLength = 100;
            this.contacto_search.Name = "contacto_search";
            this.contacto_search.Size = new System.Drawing.Size(113, 20);
            this.contacto_search.TabIndex = 17;
            // 
            // razon_social_search
            // 
            this.razon_social_search.Location = new System.Drawing.Point(82, 18);
            this.razon_social_search.MaxLength = 100;
            this.razon_social_search.Name = "razon_social_search";
            this.razon_social_search.Size = new System.Drawing.Size(113, 20);
            this.razon_social_search.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Razon social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "CUIT:";
            // 
            // cuit_search
            // 
            this.cuit_search.Location = new System.Drawing.Point(243, 20);
            this.cuit_search.MaxLength = 100;
            this.cuit_search.Name = "cuit_search";
            this.cuit_search.Size = new System.Drawing.Size(113, 20);
            this.cuit_search.TabIndex = 19;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(437, 63);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(113, 23);
            this.search_button.TabIndex = 36;
            this.search_button.Text = "Buscar";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cambiar Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListadoBusquedaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.listadoEmpresas);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_button);
            this.Name = "ListadoBusquedaEmpresas";
            this.Text = "ListadoBusquedaEmpresas";
            ((System.ComponentModel.ISupportInitialize)(this.listadoEmpresas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridView listadoEmpresas;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contacto_search;
        private System.Windows.Forms.TextBox razon_social_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cuit_search;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_fallidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button button1;

    }
}