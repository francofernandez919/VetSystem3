﻿namespace WindowsFormsApp1
{
    partial class Form_Clientes_ConsultarModificar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableCliente = new WindowsFormsApp1.dbVSDataSetTableCliente();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMailCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoCliente = new System.Windows.Forms.TextBox();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new WindowsFormsApp1.dbVSDataSetTableClienteTableAdapters.clienteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMailCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxDireccionCliente);
            this.groupBox1.Controls.Add(this.textBoxTelefonoCliente);
            this.groupBox1.Controls.Add(this.textBoxApellidoCliente);
            this.groupBox1.Controls.Add(this.textBoxNombreCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar y Modificar Cliente";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 232);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.dniclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn,
            this.mailclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 180);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniclienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // mailclienteDataGridViewTextBoxColumn
            // 
            this.mailclienteDataGridViewTextBoxColumn.DataPropertyName = "mail_cliente";
            this.mailclienteDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailclienteDataGridViewTextBoxColumn.Name = "mailclienteDataGridViewTextBoxColumn";
            this.mailclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            this.direccionclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dbVSDataSetTableCliente;
            // 
            // dbVSDataSetTableCliente
            // 
            this.dbVSDataSetTableCliente.DataSetName = "dbVSDataSetTableCliente";
            this.dbVSDataSetTableCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(235, 19);
            this.textBoxBuscar.MaxLength = 50;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(225, 21);
            this.textBoxBuscar.TabIndex = 2;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(109, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(120, 21);
            this.comboBoxBuscar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Buscar:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDNI.Enabled = false;
            this.textBoxDNI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(235, 232);
            this.textBoxDNI.MaxLength = 50;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(160, 21);
            this.textBoxDNI.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "*DNI:";
            // 
            // textBoxMailCliente
            // 
            this.textBoxMailCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMailCliente.Location = new System.Drawing.Point(235, 340);
            this.textBoxMailCliente.MaxLength = 50;
            this.textBoxMailCliente.Name = "textBoxMailCliente";
            this.textBoxMailCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxMailCliente.TabIndex = 8;
            this.textBoxMailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMailCliente_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDireccionCliente
            // 
            this.textBoxDireccionCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccionCliente.Location = new System.Drawing.Point(235, 367);
            this.textBoxDireccionCliente.MaxLength = 50;
            this.textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            this.textBoxDireccionCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxDireccionCliente.TabIndex = 9;
            // 
            // textBoxTelefonoCliente
            // 
            this.textBoxTelefonoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefonoCliente.Location = new System.Drawing.Point(235, 313);
            this.textBoxTelefonoCliente.MaxLength = 50;
            this.textBoxTelefonoCliente.Name = "textBoxTelefonoCliente";
            this.textBoxTelefonoCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxTelefonoCliente.TabIndex = 7;
            this.textBoxTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefonoCliente_KeyPress);
            // 
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(235, 286);
            this.textBoxApellidoCliente.MaxLength = 50;
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxApellidoCliente.TabIndex = 6;
            this.textBoxApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoCliente_KeyPress);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(235, 259);
            this.textBoxNombreCliente.MaxLength = 50;
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreCliente.TabIndex = 5;
            this.textBoxNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreCliente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nombre:";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Clientes_ConsultarModificar
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Clientes_ConsultarModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMailCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDireccionCliente;
        private System.Windows.Forms.TextBox textBoxTelefonoCliente;
        private System.Windows.Forms.TextBox textBoxApellidoCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbVSDataSetTableCliente dbVSDataSetTableCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbVSDataSetTableClienteTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionclienteDataGridViewTextBoxColumn;
    }
}