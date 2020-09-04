namespace WindowsFormsApp1
{
    partial class Form_Mascotas_ConsultarModificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelidMascota = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRazaMascota = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoMascota = new System.Windows.Forms.ComboBox();
            this.tipoMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoMascota = new WindowsFormsApp1.dbVSDataSetTableTipoMascota();
            this.textBoxNombreMascota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombremascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretipomascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrerazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKmascotaclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewmascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetViewMascotas = new WindowsFormsApp1.dbVSDataSetViewMascotas();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.view_mascotasTableAdapter = new WindowsFormsApp1.dbVSDataSetViewMascotasTableAdapters.view_mascotasTableAdapter();
            this.tipoMascotaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmascotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelidMascota);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.textBoxApellidoCliente);
            this.groupBox1.Controls.Add(this.textBoxNombreCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxRazaMascota);
            this.groupBox1.Controls.Add(this.comboBoxTipoMascota);
            this.groupBox1.Controls.Add(this.textBoxNombreMascota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar y Modificar Mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wolf1;
            this.pictureBox1.Location = new System.Drawing.Point(458, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelidMascota
            // 
            this.labelidMascota.AutoSize = true;
            this.labelidMascota.Location = new System.Drawing.Point(103, 243);
            this.labelidMascota.Name = "labelidMascota";
            this.labelidMascota.Size = new System.Drawing.Size(0, 13);
            this.labelidMascota.TabIndex = 56;
            this.labelidMascota.Visible = false;
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
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Enabled = false;
            this.textBoxApellidoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(235, 286);
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.ReadOnly = true;
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxApellidoCliente.TabIndex = 6;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(235, 259);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreCliente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Apellido Dueño:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Enabled = false;
            this.textBoxDNI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(235, 232);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(160, 21);
            this.textBoxDNI.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nombre Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "DNI Dueño:";
            // 
            // comboBoxRazaMascota
            // 
            this.comboBoxRazaMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRazaMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRazaMascota.FormattingEnabled = true;
            this.comboBoxRazaMascota.Location = new System.Drawing.Point(235, 387);
            this.comboBoxRazaMascota.Name = "comboBoxRazaMascota";
            this.comboBoxRazaMascota.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRazaMascota.TabIndex = 9;
            this.comboBoxRazaMascota.DropDown += new System.EventHandler(this.comboBoxRazaMascota_DropDown);
            // 
            // comboBoxTipoMascota
            // 
            this.comboBoxTipoMascota.DataSource = this.tipoMascotaBindingSource;
            this.comboBoxTipoMascota.DisplayMember = "nombre_tipo_mascota";
            this.comboBoxTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoMascota.FormattingEnabled = true;
            this.comboBoxTipoMascota.Location = new System.Drawing.Point(235, 360);
            this.comboBoxTipoMascota.Name = "comboBoxTipoMascota";
            this.comboBoxTipoMascota.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoMascota.TabIndex = 8;
            this.comboBoxTipoMascota.ValueMember = "id_tipo_mascota";
            this.comboBoxTipoMascota.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoMascota_SelectedIndexChanged);
            // 
            // tipoMascotaBindingSource
            // 
            this.tipoMascotaBindingSource.DataMember = "tipoMascota";
            this.tipoMascotaBindingSource.DataSource = this.dbVSDataSetTableTipoMascota;
            // 
            // dbVSDataSetTableTipoMascota
            // 
            this.dbVSDataSetTableTipoMascota.DataSetName = "dbVSDataSetTableTipoMascota";
            this.dbVSDataSetTableTipoMascota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxNombreMascota
            // 
            this.textBoxNombreMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMascota.Location = new System.Drawing.Point(235, 333);
            this.textBoxNombreMascota.MaxLength = 50;
            this.textBoxNombreMascota.Name = "textBoxNombreMascota";
            this.textBoxNombreMascota.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreMascota.TabIndex = 7;
            this.textBoxNombreMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreMascota_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "*Raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "*Tipo Animal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "*Nombre Mascota:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmascotaDataGridViewTextBoxColumn,
            this.nombremascotaDataGridViewTextBoxColumn,
            this.nombretipomascotaDataGridViewTextBoxColumn,
            this.nombrerazaDataGridViewTextBoxColumn,
            this.fKmascotaclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewmascotasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 180);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idmascotaDataGridViewTextBoxColumn
            // 
            this.idmascotaDataGridViewTextBoxColumn.DataPropertyName = "id_mascota";
            this.idmascotaDataGridViewTextBoxColumn.HeaderText = "id_mascota";
            this.idmascotaDataGridViewTextBoxColumn.Name = "idmascotaDataGridViewTextBoxColumn";
            this.idmascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmascotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombremascotaDataGridViewTextBoxColumn
            // 
            this.nombremascotaDataGridViewTextBoxColumn.DataPropertyName = "nombre_mascota";
            this.nombremascotaDataGridViewTextBoxColumn.HeaderText = "Nombre Mascota";
            this.nombremascotaDataGridViewTextBoxColumn.Name = "nombremascotaDataGridViewTextBoxColumn";
            this.nombremascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombretipomascotaDataGridViewTextBoxColumn
            // 
            this.nombretipomascotaDataGridViewTextBoxColumn.DataPropertyName = "nombre_tipo_mascota";
            this.nombretipomascotaDataGridViewTextBoxColumn.HeaderText = "Tipo Animal";
            this.nombretipomascotaDataGridViewTextBoxColumn.Name = "nombretipomascotaDataGridViewTextBoxColumn";
            this.nombretipomascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombretipomascotaDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombrerazaDataGridViewTextBoxColumn
            // 
            this.nombrerazaDataGridViewTextBoxColumn.DataPropertyName = "nombre_raza";
            this.nombrerazaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.nombrerazaDataGridViewTextBoxColumn.Name = "nombrerazaDataGridViewTextBoxColumn";
            this.nombrerazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrerazaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKmascotaclienteDataGridViewTextBoxColumn
            // 
            this.fKmascotaclienteDataGridViewTextBoxColumn.DataPropertyName = "FK_mascota_cliente";
            this.fKmascotaclienteDataGridViewTextBoxColumn.HeaderText = "DNI Dueño";
            this.fKmascotaclienteDataGridViewTextBoxColumn.Name = "fKmascotaclienteDataGridViewTextBoxColumn";
            this.fKmascotaclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKmascotaclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre Dueño";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellido Dueño";
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewmascotasBindingSource
            // 
            this.viewmascotasBindingSource.DataMember = "view_mascotas";
            this.viewmascotasBindingSource.DataSource = this.dbVSDataSetViewMascotas;
            // 
            // dbVSDataSetViewMascotas
            // 
            this.dbVSDataSetViewMascotas.DataSetName = "dbVSDataSetViewMascotas";
            this.dbVSDataSetViewMascotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(235, 19);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(225, 21);
            this.textBoxBuscar.TabIndex = 2;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(109, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(120, 21);
            this.comboBoxBuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Buscar:";
            // 
            // view_mascotasTableAdapter
            // 
            this.view_mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // tipoMascotaTableAdapter
            // 
            this.tipoMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Mascotas_ConsultarModificar
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 474);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Mascotas_ConsultarModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Mascotas_ConsultarModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmascotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxApellidoCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRazaMascota;
        private System.Windows.Forms.ComboBox comboBoxTipoMascota;
        private System.Windows.Forms.TextBox textBoxNombreMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private dbVSDataSetViewMascotas dbVSDataSetViewMascotas;
        private System.Windows.Forms.BindingSource viewmascotasBindingSource;
        private dbVSDataSetViewMascotasTableAdapters.view_mascotasTableAdapter view_mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipomascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrerazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKmascotaclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private dbVSDataSetTableTipoMascota dbVSDataSetTableTipoMascota;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource;
        private dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter tipoMascotaTableAdapter;
        private System.Windows.Forms.Label labelidMascota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}