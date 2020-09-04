namespace WindowsFormsApp1
{
    partial class Form_Vacunacion_Registrar
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
            this.labelidMascota = new System.Windows.Forms.Label();
            this.textBoxRazaMascota = new System.Windows.Forms.TextBox();
            this.textBoxTipoMascota = new System.Windows.Forms.TextBox();
            this.textBoxNombreMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKmascotaclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombremascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretipomascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrerazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewmascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetViewMascotas = new WindowsFormsApp1.dbVSDataSetViewMascotas();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoVacuna = new System.Windows.Forms.ComboBox();
            this.tipoVacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoVacuna = new WindowsFormsApp1.dbVSDataSetTableTipoVacuna();
            this.label1 = new System.Windows.Forms.Label();
            this.view_mascotasTableAdapter = new WindowsFormsApp1.dbVSDataSetViewMascotasTableAdapters.view_mascotasTableAdapter();
            this.dbVSDataSetTableTipoMascota = new WindowsFormsApp1.dbVSDataSetTableTipoMascota();
            this.tipoMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMascotaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter();
            this.tipoVacunaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoVacunaTableAdapters.tipoVacunaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmascotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVacunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoVacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelidMascota);
            this.groupBox1.Controls.Add(this.textBoxRazaMascota);
            this.groupBox1.Controls.Add(this.textBoxTipoMascota);
            this.groupBox1.Controls.Add(this.textBoxNombreMascota);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTipoVacuna);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Vacunación";
            // 
            // labelidMascota
            // 
            this.labelidMascota.AutoSize = true;
            this.labelidMascota.Location = new System.Drawing.Point(78, 286);
            this.labelidMascota.Name = "labelidMascota";
            this.labelidMascota.Size = new System.Drawing.Size(0, 13);
            this.labelidMascota.TabIndex = 63;
            this.labelidMascota.Visible = false;
            // 
            // textBoxRazaMascota
            // 
            this.textBoxRazaMascota.Enabled = false;
            this.textBoxRazaMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRazaMascota.Location = new System.Drawing.Point(235, 286);
            this.textBoxRazaMascota.MaxLength = 50;
            this.textBoxRazaMascota.Name = "textBoxRazaMascota";
            this.textBoxRazaMascota.ReadOnly = true;
            this.textBoxRazaMascota.Size = new System.Drawing.Size(160, 21);
            this.textBoxRazaMascota.TabIndex = 4;
            // 
            // textBoxTipoMascota
            // 
            this.textBoxTipoMascota.Enabled = false;
            this.textBoxTipoMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoMascota.Location = new System.Drawing.Point(235, 259);
            this.textBoxTipoMascota.MaxLength = 50;
            this.textBoxTipoMascota.Name = "textBoxTipoMascota";
            this.textBoxTipoMascota.ReadOnly = true;
            this.textBoxTipoMascota.Size = new System.Drawing.Size(160, 21);
            this.textBoxTipoMascota.TabIndex = 4;
            // 
            // textBoxNombreMascota
            // 
            this.textBoxNombreMascota.Enabled = false;
            this.textBoxNombreMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMascota.Location = new System.Drawing.Point(235, 232);
            this.textBoxNombreMascota.MaxLength = 50;
            this.textBoxNombreMascota.Name = "textBoxNombreMascota";
            this.textBoxNombreMascota.ReadOnly = true;
            this.textBoxNombreMascota.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreMascota.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Raza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tipo de Animal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nombre Mascota:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 232);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            this.fKmascotaclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn,
            this.nombremascotaDataGridViewTextBoxColumn,
            this.nombretipomascotaDataGridViewTextBoxColumn,
            this.nombrerazaDataGridViewTextBoxColumn});
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
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            // 
            // idmascotaDataGridViewTextBoxColumn
            // 
            this.idmascotaDataGridViewTextBoxColumn.DataPropertyName = "id_mascota";
            this.idmascotaDataGridViewTextBoxColumn.HeaderText = "id_mascota";
            this.idmascotaDataGridViewTextBoxColumn.Name = "idmascotaDataGridViewTextBoxColumn";
            this.idmascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmascotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKmascotaclienteDataGridViewTextBoxColumn
            // 
            this.fKmascotaclienteDataGridViewTextBoxColumn.DataPropertyName = "FK_mascota_cliente";
            this.fKmascotaclienteDataGridViewTextBoxColumn.HeaderText = "DNI Dueño";
            this.fKmascotaclienteDataGridViewTextBoxColumn.Name = "fKmascotaclienteDataGridViewTextBoxColumn";
            this.fKmascotaclienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.nombretipomascotaDataGridViewTextBoxColumn.HeaderText = "Tipo de Animal";
            this.nombretipomascotaDataGridViewTextBoxColumn.Name = "nombretipomascotaDataGridViewTextBoxColumn";
            this.nombretipomascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrerazaDataGridViewTextBoxColumn
            // 
            this.nombrerazaDataGridViewTextBoxColumn.DataPropertyName = "nombre_raza";
            this.nombrerazaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.nombrerazaDataGridViewTextBoxColumn.Name = "nombrerazaDataGridViewTextBoxColumn";
            this.nombrerazaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(114, 19);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBuscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(235, 326);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(160, 21);
            this.dateTimePickerFecha.TabIndex = 7;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Tipo de Vacuna:";
            // 
            // comboBoxTipoVacuna
            // 
            this.comboBoxTipoVacuna.DataSource = this.tipoVacunaBindingSource;
            this.comboBoxTipoVacuna.DisplayMember = "nombre_tipo_vacuna";
            this.comboBoxTipoVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoVacuna.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoVacuna.FormattingEnabled = true;
            this.comboBoxTipoVacuna.Location = new System.Drawing.Point(235, 353);
            this.comboBoxTipoVacuna.Name = "comboBoxTipoVacuna";
            this.comboBoxTipoVacuna.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoVacuna.TabIndex = 8;
            this.comboBoxTipoVacuna.ValueMember = "id_tipo_vacuna";
            // 
            // tipoVacunaBindingSource
            // 
            this.tipoVacunaBindingSource.DataMember = "tipoVacuna";
            this.tipoVacunaBindingSource.DataSource = this.dbVSDataSetTableTipoVacuna;
            // 
            // dbVSDataSetTableTipoVacuna
            // 
            this.dbVSDataSetTableTipoVacuna.DataSetName = "dbVSDataSetTableTipoVacuna";
            this.dbVSDataSetTableTipoVacuna.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Fecha:";
            // 
            // view_mascotasTableAdapter
            // 
            this.view_mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // dbVSDataSetTableTipoMascota
            // 
            this.dbVSDataSetTableTipoMascota.DataSetName = "dbVSDataSetTableTipoMascota";
            this.dbVSDataSetTableTipoMascota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoMascotaBindingSource
            // 
            this.tipoMascotaBindingSource.DataMember = "tipoMascota";
            this.tipoMascotaBindingSource.DataSource = this.dbVSDataSetTableTipoMascota;
            // 
            // tipoMascotaTableAdapter
            // 
            this.tipoMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoVacunaTableAdapter
            // 
            this.tipoVacunaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Vacunacion_Registrar
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 438);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Vacunacion_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Vacunacion_Registrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmascotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVacunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoVacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoVacuna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelidMascota;
        private System.Windows.Forms.TextBox textBoxNombreMascota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private dbVSDataSetViewMascotas dbVSDataSetViewMascotas;
        private System.Windows.Forms.BindingSource viewmascotasBindingSource;
        private dbVSDataSetViewMascotasTableAdapters.view_mascotasTableAdapter view_mascotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKmascotaclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipomascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrerazaDataGridViewTextBoxColumn;
        private dbVSDataSetTableTipoMascota dbVSDataSetTableTipoMascota;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource;
        private dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter tipoMascotaTableAdapter;
        private dbVSDataSetTableTipoVacuna dbVSDataSetTableTipoVacuna;
        private System.Windows.Forms.BindingSource tipoVacunaBindingSource;
        private dbVSDataSetTableTipoVacunaTableAdapters.tipoVacunaTableAdapter tipoVacunaTableAdapter;
        private System.Windows.Forms.TextBox textBoxRazaMascota;
        private System.Windows.Forms.TextBox textBoxTipoMascota;
    }
}