﻿namespace WindowsFormsApp1
{
    partial class Form_Turnos_Registrar2
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
            this.labelToday = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoTurno = new System.Windows.Forms.ComboBox();
            this.tipoTurnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoTurno = new WindowsFormsApp1.dbVSDataSetTableTipoTurno();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.veterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableVeterinario = new WindowsFormsApp1.dbVSDataSetTableVeterinario();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretipoturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewturnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetViewTurnos = new WindowsFormsApp1.dbVSDataSetViewTurnos();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.view_turnosTableAdapter = new WindowsFormsApp1.dbVSDataSetViewTurnosTableAdapters.view_turnosTableAdapter();
            this.veterinarioTableAdapter = new WindowsFormsApp1.dbVSDataSetTableVeterinarioTableAdapters.veterinarioTableAdapter();
            this.tipoTurnoTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoTurnoTableAdapters.tipoTurnoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTurnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewturnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelToday);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxTipoTurno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxHora);
            this.groupBox1.Controls.Add(this.textBoxObservaciones);
            this.groupBox1.Controls.Add(this.comboBoxVeterinario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Turno";
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Location = new System.Drawing.Point(43, 266);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(24, 13);
            this.labelToday.TabIndex = 33;
            this.labelToday.Text = "dia";
            this.labelToday.Visible = false;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(43, 242);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(24, 13);
            this.labelDNI.TabIndex = 32;
            this.labelDNI.Text = "dni";
            this.labelDNI.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxTipoTurno
            // 
            this.comboBoxTipoTurno.DataSource = this.tipoTurnoBindingSource;
            this.comboBoxTipoTurno.DisplayMember = "nombre_tipo_turno";
            this.comboBoxTipoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoTurno.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoTurno.FormattingEnabled = true;
            this.comboBoxTipoTurno.Location = new System.Drawing.Point(235, 285);
            this.comboBoxTipoTurno.Name = "comboBoxTipoTurno";
            this.comboBoxTipoTurno.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoTurno.TabIndex = 5;
            this.comboBoxTipoTurno.ValueMember = "id_tipo_turno";
            // 
            // tipoTurnoBindingSource
            // 
            this.tipoTurnoBindingSource.DataMember = "tipoTurno";
            this.tipoTurnoBindingSource.DataSource = this.dbVSDataSetTableTipoTurno;
            // 
            // dbVSDataSetTableTipoTurno
            // 
            this.dbVSDataSetTableTipoTurno.DataSetName = "dbVSDataSetTableTipoTurno";
            this.dbVSDataSetTableTipoTurno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "*Tipo de Atención Médica:";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DisplayMember = "09:00";
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00"});
            this.comboBoxHora.Location = new System.Drawing.Point(235, 231);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(160, 21);
            this.comboBoxHora.TabIndex = 3;
            this.comboBoxHora.ValueMember = "09:00";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(235, 312);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(160, 75);
            this.textBoxObservaciones.TabIndex = 6;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.DataSource = this.veterinarioBindingSource;
            this.comboBoxVeterinario.DisplayMember = "apellido_veterinario";
            this.comboBoxVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(235, 258);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(160, 21);
            this.comboBoxVeterinario.TabIndex = 4;
            this.comboBoxVeterinario.ValueMember = "matricula_veterinario";
            // 
            // veterinarioBindingSource
            // 
            this.veterinarioBindingSource.DataMember = "veterinario";
            this.veterinarioBindingSource.DataSource = this.dbVSDataSetTableVeterinario;
            // 
            // dbVSDataSetTableVeterinario
            // 
            this.dbVSDataSetTableVeterinario.DataSetName = "dbVSDataSetTableVeterinario";
            this.dbVSDataSetTableVeterinario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Observaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "*Veterinario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "*Hora:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 231);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 8;
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
            this.idturnoDataGridViewTextBoxColumn,
            this.fechaturnoDataGridViewTextBoxColumn,
            this.horaturnoDataGridViewTextBoxColumn,
            this.observacionturnoDataGridViewTextBoxColumn,
            this.nombretipoturnoDataGridViewTextBoxColumn,
            this.nombreveterinarioDataGridViewTextBoxColumn,
            this.apellidoveterinarioDataGridViewTextBoxColumn,
            this.dniclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewturnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 180);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // idturnoDataGridViewTextBoxColumn
            // 
            this.idturnoDataGridViewTextBoxColumn.DataPropertyName = "id_turno";
            this.idturnoDataGridViewTextBoxColumn.HeaderText = "Número de Turno";
            this.idturnoDataGridViewTextBoxColumn.Name = "idturnoDataGridViewTextBoxColumn";
            this.idturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idturnoDataGridViewTextBoxColumn.Width = 50;
            // 
            // fechaturnoDataGridViewTextBoxColumn
            // 
            this.fechaturnoDataGridViewTextBoxColumn.DataPropertyName = "fecha_turno";
            this.fechaturnoDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaturnoDataGridViewTextBoxColumn.Name = "fechaturnoDataGridViewTextBoxColumn";
            this.fechaturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaturnoDataGridViewTextBoxColumn.Width = 75;
            // 
            // horaturnoDataGridViewTextBoxColumn
            // 
            this.horaturnoDataGridViewTextBoxColumn.DataPropertyName = "hora_turno";
            this.horaturnoDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaturnoDataGridViewTextBoxColumn.Name = "horaturnoDataGridViewTextBoxColumn";
            this.horaturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaturnoDataGridViewTextBoxColumn.Width = 75;
            // 
            // observacionturnoDataGridViewTextBoxColumn
            // 
            this.observacionturnoDataGridViewTextBoxColumn.DataPropertyName = "observacion_turno";
            this.observacionturnoDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.observacionturnoDataGridViewTextBoxColumn.Name = "observacionturnoDataGridViewTextBoxColumn";
            this.observacionturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionturnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombretipoturnoDataGridViewTextBoxColumn
            // 
            this.nombretipoturnoDataGridViewTextBoxColumn.DataPropertyName = "nombre_tipo_turno";
            this.nombretipoturnoDataGridViewTextBoxColumn.HeaderText = "Tipo de Atención Médica";
            this.nombretipoturnoDataGridViewTextBoxColumn.Name = "nombretipoturnoDataGridViewTextBoxColumn";
            this.nombretipoturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombretipoturnoDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreveterinarioDataGridViewTextBoxColumn
            // 
            this.nombreveterinarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_veterinario";
            this.nombreveterinarioDataGridViewTextBoxColumn.HeaderText = "Nombre Veterinario";
            this.nombreveterinarioDataGridViewTextBoxColumn.Name = "nombreveterinarioDataGridViewTextBoxColumn";
            this.nombreveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreveterinarioDataGridViewTextBoxColumn.Visible = false;
            this.nombreveterinarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // apellidoveterinarioDataGridViewTextBoxColumn
            // 
            this.apellidoveterinarioDataGridViewTextBoxColumn.DataPropertyName = "apellido_veterinario";
            this.apellidoveterinarioDataGridViewTextBoxColumn.HeaderText = "Apellido Veterinario";
            this.apellidoveterinarioDataGridViewTextBoxColumn.Name = "apellidoveterinarioDataGridViewTextBoxColumn";
            this.apellidoveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoveterinarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI Dueño";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre Dueño";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellido Dueño";
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // viewturnosBindingSource
            // 
            this.viewturnosBindingSource.DataMember = "view_turnos";
            this.viewturnosBindingSource.DataSource = this.dbVSDataSetViewTurnos;
            // 
            // dbVSDataSetViewTurnos
            // 
            this.dbVSDataSetViewTurnos.DataSetName = "dbVSDataSetViewTurnos";
            this.dbVSDataSetViewTurnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seleccionar Fecha:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(495, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver Atrás";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_turnosTableAdapter
            // 
            this.view_turnosTableAdapter.ClearBeforeFill = true;
            // 
            // veterinarioTableAdapter
            // 
            this.veterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // tipoTurnoTableAdapter
            // 
            this.tipoTurnoTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Turnos_Registrar2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Turnos_Registrar2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Turnos_Registrar2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTurnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewturnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxTipoTurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.ComboBox comboBoxVeterinario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelToday;
        private dbVSDataSetViewTurnos dbVSDataSetViewTurnos;
        private System.Windows.Forms.BindingSource viewturnosBindingSource;
        private dbVSDataSetViewTurnosTableAdapters.view_turnosTableAdapter view_turnosTableAdapter;
        private dbVSDataSetTableVeterinario dbVSDataSetTableVeterinario;
        private System.Windows.Forms.BindingSource veterinarioBindingSource;
        private dbVSDataSetTableVeterinarioTableAdapters.veterinarioTableAdapter veterinarioTableAdapter;
        private dbVSDataSetTableTipoTurno dbVSDataSetTableTipoTurno;
        private System.Windows.Forms.BindingSource tipoTurnoBindingSource;
        private dbVSDataSetTableTipoTurnoTableAdapters.tipoTurnoTableAdapter tipoTurnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipoturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
    }
}