namespace FrbaCommerce.Abm_Cliente
{
    partial class ListadoBusqueda
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.search_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            this.nombre_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(58, 16);
            this.nombre.MaxLength = 100;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(113, 20);
            this.nombre.TabIndex = 15;
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
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(241, 19);
            this.apellido.MaxLength = 100;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(113, 20);
            this.apellido.TabIndex = 17;
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
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(415, 20);
            this.mail.MaxLength = 100;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(113, 20);
            this.mail.TabIndex = 19;
            // 
            // tipoDoc
            // 
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.tipoDoc.Location = new System.Drawing.Point(120, 43);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(49, 21);
            this.tipoDoc.TabIndex = 26;
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
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(175, 43);
            this.documento.MaxLength = 100;
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(129, 20);
            this.documento.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.tipoDoc);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mail);
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
            this.nombre_col,
            this.apellido_col,
            this.tipoDoc_col,
            this.documento_col,
            this.mail_col,
            this.telefono_col,
            this.direccion_col,
            this.codigoPostal_col,
            this.fechaNacimiento_col});
            this.listadoClientes.Location = new System.Drawing.Point(12, 122);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(538, 285);
            this.listadoClientes.TabIndex = 34;
            // 
            // nombre_col
            // 
            this.nombre_col.HeaderText = "Nombre";
            this.nombre_col.Name = "nombre_col";
            // 
            // apellido_col
            // 
            this.apellido_col.HeaderText = "Apellido";
            this.apellido_col.Name = "apellido_col";
            // 
            // tipoDoc_col
            // 
            this.tipoDoc_col.HeaderText = "Tipo";
            this.tipoDoc_col.Name = "tipoDoc_col";
            // 
            // documento_col
            // 
            this.documento_col.HeaderText = "Nº Documento";
            this.documento_col.Name = "documento_col";
            // 
            // mail_col
            // 
            this.mail_col.HeaderText = "E-mail";
            this.mail_col.Name = "mail_col";
            // 
            // telefono_col
            // 
            this.telefono_col.HeaderText = "Teléfono";
            this.telefono_col.Name = "telefono_col";
            // 
            // direccion_col
            // 
            this.direccion_col.HeaderText = "Dirección";
            this.direccion_col.Name = "direccion_col";
            // 
            // codigoPostal_col
            // 
            this.codigoPostal_col.HeaderText = "Código Postal";
            this.codigoPostal_col.Name = "codigoPostal_col";
            // 
            // fechaNacimiento_col
            // 
            this.fechaNacimiento_col.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento_col.Name = "fechaNacimiento_col";
            // 
            // ListadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listadoClientes);
            this.Controls.Add(this.delete_button);
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

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView listadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento_col;
    }
}