namespace WindowsFormsApp1
{
    partial class Form_Turnos_Listado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewturnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetViewTurnos = new WindowsFormsApp1.dbVSDataSetViewTurnos();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonEmitir = new System.Windows.Forms.Button();
            this.view_turnosTableAdapter = new WindowsFormsApp1.dbVSDataSetViewTurnosTableAdapters.view_turnosTableAdapter();
            this.idturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretipoturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewturnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Turnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idturnoDataGridViewTextBoxColumn,
            this.fechaturnoDataGridViewTextBoxColumn,
            this.horaturnoDataGridViewTextBoxColumn,
            this.nombretipoturnoDataGridViewTextBoxColumn,
            this.observacionturnoDataGridViewTextBoxColumn,
            this.nombreveterinarioDataGridViewTextBoxColumn,
            this.apellidoveterinarioDataGridViewTextBoxColumn,
            this.dniclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.apellidoclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewturnosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 250);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Fecha:";
            // 
            // buttonEmitir
            // 
            this.buttonEmitir.Location = new System.Drawing.Point(276, 329);
            this.buttonEmitir.Name = "buttonEmitir";
            this.buttonEmitir.Size = new System.Drawing.Size(75, 25);
            this.buttonEmitir.TabIndex = 2;
            this.buttonEmitir.Text = "Emitir";
            this.buttonEmitir.UseVisualStyleBackColor = true;
            this.buttonEmitir.Click += new System.EventHandler(this.buttonEmitir_Click);
            // 
            // view_turnosTableAdapter
            // 
            this.view_turnosTableAdapter.ClearBeforeFill = true;
            // 
            // idturnoDataGridViewTextBoxColumn
            // 
            this.idturnoDataGridViewTextBoxColumn.DataPropertyName = "id_turno";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idturnoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idturnoDataGridViewTextBoxColumn.HeaderText = "Nro. de Turno";
            this.idturnoDataGridViewTextBoxColumn.Name = "idturnoDataGridViewTextBoxColumn";
            this.idturnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaturnoDataGridViewTextBoxColumn
            // 
            this.fechaturnoDataGridViewTextBoxColumn.DataPropertyName = "fecha_turno";
            this.fechaturnoDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaturnoDataGridViewTextBoxColumn.Name = "fechaturnoDataGridViewTextBoxColumn";
            this.fechaturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaturnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // horaturnoDataGridViewTextBoxColumn
            // 
            this.horaturnoDataGridViewTextBoxColumn.DataPropertyName = "hora_turno";
            this.horaturnoDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaturnoDataGridViewTextBoxColumn.Name = "horaturnoDataGridViewTextBoxColumn";
            this.horaturnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombretipoturnoDataGridViewTextBoxColumn
            // 
            this.nombretipoturnoDataGridViewTextBoxColumn.DataPropertyName = "nombre_tipo_turno";
            this.nombretipoturnoDataGridViewTextBoxColumn.HeaderText = "Tipo de Atención Médica";
            this.nombretipoturnoDataGridViewTextBoxColumn.Name = "nombretipoturnoDataGridViewTextBoxColumn";
            this.nombretipoturnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionturnoDataGridViewTextBoxColumn
            // 
            this.observacionturnoDataGridViewTextBoxColumn.DataPropertyName = "observacion_turno";
            this.observacionturnoDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.observacionturnoDataGridViewTextBoxColumn.Name = "observacionturnoDataGridViewTextBoxColumn";
            this.observacionturnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreveterinarioDataGridViewTextBoxColumn
            // 
            this.nombreveterinarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_veterinario";
            this.nombreveterinarioDataGridViewTextBoxColumn.HeaderText = "nombre_veterinario";
            this.nombreveterinarioDataGridViewTextBoxColumn.Name = "nombreveterinarioDataGridViewTextBoxColumn";
            this.nombreveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreveterinarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoveterinarioDataGridViewTextBoxColumn
            // 
            this.apellidoveterinarioDataGridViewTextBoxColumn.DataPropertyName = "apellido_veterinario";
            this.apellidoveterinarioDataGridViewTextBoxColumn.HeaderText = "Veterinario";
            this.apellidoveterinarioDataGridViewTextBoxColumn.Name = "apellidoveterinarioDataGridViewTextBoxColumn";
            this.apellidoveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniclienteDataGridViewTextBoxColumn
            // 
            this.dniclienteDataGridViewTextBoxColumn.DataPropertyName = "dni_cliente";
            this.dniclienteDataGridViewTextBoxColumn.HeaderText = "DNI Cliente";
            this.dniclienteDataGridViewTextBoxColumn.Name = "dniclienteDataGridViewTextBoxColumn";
            this.dniclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellido Cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Turnos_Listado
            // 
            this.AcceptButton = this.buttonEmitir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.buttonEmitir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Turnos_Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.Load += new System.EventHandler(this.Form_Turnos_Emitir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewturnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonEmitir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbVSDataSetViewTurnos dbVSDataSetViewTurnos;
        private System.Windows.Forms.BindingSource viewturnosBindingSource;
        private dbVSDataSetViewTurnosTableAdapters.view_turnosTableAdapter view_turnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipoturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
    }
}