namespace FrbaCommerce.Abm_Cliente
{
    partial class ListadoBusquedaClientes
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
            this.components = new System.ComponentModel.Container();
            this.nombre_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mail_search = new System.Windows.Forms.TextBox();
            this.tipoDoc_search = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.documento_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.search_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_search
            // 
            this.nombre_search.Location = new System.Drawing.Point(58, 16);
            this.nombre_search.MaxLength = 100;
            this.nombre_search.Name = "nombre_search";
            this.nombre_search.Size = new System.Drawing.Size(113, 20);
            this.nombre_search.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido:";
            // 
            // apellido_search
            // 
            this.apellido_search.Location = new System.Drawing.Point(241, 19);
            this.apellido_search.MaxLength = 100;
            this.apellido_search.Name = "apellido_search";
            this.apellido_search.Size = new System.Drawing.Size(113, 20);
            this.apellido_search.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail:";
            // 
            // mail_search
            // 
            this.mail_search.Location = new System.Drawing.Point(415, 20);
            this.mail_search.MaxLength = 100;
            this.mail_search.Name = "mail_search";
            this.mail_search.Size = new System.Drawing.Size(113, 20);
            this.mail_search.TabIndex = 19;
            // 
            // tipoDoc_search
            // 
            this.tipoDoc_search.FormattingEnabled = true;
            this.tipoDoc_search.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.tipoDoc_search.Location = new System.Drawing.Point(120, 43);
            this.tipoDoc_search.Name = "tipoDoc_search";
            this.tipoDoc_search.Size = new System.Drawing.Size(49, 21);
            this.tipoDoc_search.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tipo y Nº Documento";
            // 
            // documento_search
            // 
            this.documento_search.Location = new System.Drawing.Point(175, 43);
            this.documento_search.MaxLength = 100;
            this.documento_search.Name = "documento_search";
            this.documento_search.Size = new System.Drawing.Size(129, 20);
            this.documento_search.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apellido_search);
            this.groupBox1.Controls.Add(this.tipoDoc_search);
            this.groupBox1.Controls.Add(this.nombre_search);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documento_search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mail_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 75);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(437, 93);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(113, 23);
            this.search_button.TabIndex = 29;
            this.search_button.Text = "Buscar";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(12, 93);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(113, 23);
            this.clean_button.TabIndex = 30;
            this.clean_button.Text = "Borrar todo";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(317, 415);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(113, 23);
            this.modify_button.TabIndex = 31;
            this.modify_button.Text = "Modificar";
            this.modify_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(197, 415);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 32;
            this.delete_button.Text = "Dar de baja";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(437, 415);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 33;
            this.add_button.Text = "Agregar";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // listadoClientes
            // 
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.id,
            this.nombre,
            this.apellido,
            this.dni_tipo,
            this.documento,
            this.mail,
            this.telefono,
            this.direccion,
            this.codigo_postal,
            this.fecha_nacimiento,
            this.habilitado});
            this.listadoClientes.Location = new System.Drawing.Point(12, 122);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(538, 285);
            this.listadoClientes.TabIndex = 34;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // dni_tipo
            // 
            this.dni_tipo.DataPropertyName = "dni_tipo";
            this.dni_tipo.HeaderText = "Tipo";
            this.dni_tipo.Name = "dni_tipo";
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Nº Documento";
            this.documento.Name = "documento";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "E-mail";
            this.mail.Name = "mail";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Código Postal";
            this.codigo_postal.Name = "codigo_postal";
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            // 
            // ListadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.listadoClientes);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_button);
            this.Name = "ListadoBusqueda";
            this.Text = "Listado de clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail_search;
        private System.Windows.Forms.ComboBox tipoDoc_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox documento_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView listadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
    }
}