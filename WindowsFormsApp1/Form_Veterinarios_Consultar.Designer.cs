namespace WindowsFormsApp1
{
    partial class Form_Veterinarios_Consultar
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidoVeterinario = new System.Windows.Forms.TextBox();
            this.textBoxNombreVeterinario = new System.Windows.Forms.TextBox();
            this.textBoxMatriculaVeterinario = new System.Windows.Forms.TextBox();
            this.dbVSDataSetViewVeterinarios = new WindowsFormsApp1.dbVSDataSetViewVeterinarios();
            this.viewveterinariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_veterinariosTableAdapter = new WindowsFormsApp1.dbVSDataSetViewVeterinariosTableAdapters.view_veterinariosTableAdapter();
            this.idveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoveterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxEspecialidadVeterinario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewVeterinarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewveterinariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEspecialidadVeterinario);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxApellidoVeterinario);
            this.groupBox1.Controls.Add(this.textBoxNombreVeterinario);
            this.groupBox1.Controls.Add(this.textBoxMatriculaVeterinario);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Veterinario";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 232);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 9;
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
            this.idveterinarioDataGridViewTextBoxColumn,
            this.matriculaveterinarioDataGridViewTextBoxColumn,
            this.nombreveterinarioDataGridViewTextBoxColumn,
            this.apellidoveterinarioDataGridViewTextBoxColumn,
            this.nombreespecialidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewveterinariosBindingSource;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Matricula:";
            // 
            // textBoxApellidoVeterinario
            // 
            this.textBoxApellidoVeterinario.Enabled = false;
            this.textBoxApellidoVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoVeterinario.Location = new System.Drawing.Point(235, 286);
            this.textBoxApellidoVeterinario.MaxLength = 50;
            this.textBoxApellidoVeterinario.Name = "textBoxApellidoVeterinario";
            this.textBoxApellidoVeterinario.ReadOnly = true;
            this.textBoxApellidoVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxApellidoVeterinario.TabIndex = 6;
            // 
            // textBoxNombreVeterinario
            // 
            this.textBoxNombreVeterinario.Enabled = false;
            this.textBoxNombreVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreVeterinario.Location = new System.Drawing.Point(235, 259);
            this.textBoxNombreVeterinario.MaxLength = 50;
            this.textBoxNombreVeterinario.Name = "textBoxNombreVeterinario";
            this.textBoxNombreVeterinario.ReadOnly = true;
            this.textBoxNombreVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreVeterinario.TabIndex = 5;
            // 
            // textBoxMatriculaVeterinario
            // 
            this.textBoxMatriculaVeterinario.Enabled = false;
            this.textBoxMatriculaVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatriculaVeterinario.Location = new System.Drawing.Point(235, 232);
            this.textBoxMatriculaVeterinario.Name = "textBoxMatriculaVeterinario";
            this.textBoxMatriculaVeterinario.ReadOnly = true;
            this.textBoxMatriculaVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxMatriculaVeterinario.TabIndex = 4;
            // 
            // dbVSDataSetViewVeterinarios
            // 
            this.dbVSDataSetViewVeterinarios.DataSetName = "dbVSDataSetViewVeterinarios";
            this.dbVSDataSetViewVeterinarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewveterinariosBindingSource
            // 
            this.viewveterinariosBindingSource.DataMember = "view_veterinarios";
            this.viewveterinariosBindingSource.DataSource = this.dbVSDataSetViewVeterinarios;
            // 
            // view_veterinariosTableAdapter
            // 
            this.view_veterinariosTableAdapter.ClearBeforeFill = true;
            // 
            // idveterinarioDataGridViewTextBoxColumn
            // 
            this.idveterinarioDataGridViewTextBoxColumn.DataPropertyName = "id_veterinario";
            this.idveterinarioDataGridViewTextBoxColumn.HeaderText = "id_veterinario";
            this.idveterinarioDataGridViewTextBoxColumn.Name = "idveterinarioDataGridViewTextBoxColumn";
            this.idveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idveterinarioDataGridViewTextBoxColumn.Visible = false;
            this.idveterinarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // matriculaveterinarioDataGridViewTextBoxColumn
            // 
            this.matriculaveterinarioDataGridViewTextBoxColumn.DataPropertyName = "matricula_veterinario";
            this.matriculaveterinarioDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaveterinarioDataGridViewTextBoxColumn.Name = "matriculaveterinarioDataGridViewTextBoxColumn";
            this.matriculaveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaveterinarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreveterinarioDataGridViewTextBoxColumn
            // 
            this.nombreveterinarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_veterinario";
            this.nombreveterinarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreveterinarioDataGridViewTextBoxColumn.Name = "nombreveterinarioDataGridViewTextBoxColumn";
            this.nombreveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreveterinarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoveterinarioDataGridViewTextBoxColumn
            // 
            this.apellidoveterinarioDataGridViewTextBoxColumn.DataPropertyName = "apellido_veterinario";
            this.apellidoveterinarioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoveterinarioDataGridViewTextBoxColumn.Name = "apellidoveterinarioDataGridViewTextBoxColumn";
            this.apellidoveterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoveterinarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreespecialidadDataGridViewTextBoxColumn
            // 
            this.nombreespecialidadDataGridViewTextBoxColumn.DataPropertyName = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn.Name = "nombreespecialidadDataGridViewTextBoxColumn";
            this.nombreespecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreespecialidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // textBoxEspecialidadVeterinario
            // 
            this.textBoxEspecialidadVeterinario.Enabled = false;
            this.textBoxEspecialidadVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspecialidadVeterinario.Location = new System.Drawing.Point(235, 313);
            this.textBoxEspecialidadVeterinario.Name = "textBoxEspecialidadVeterinario";
            this.textBoxEspecialidadVeterinario.ReadOnly = true;
            this.textBoxEspecialidadVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxEspecialidadVeterinario.TabIndex = 16;
            // 
            // Form_Veterinarios_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 387);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Veterinarios_Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.Load += new System.EventHandler(this.Form_Veterinarios_Consultar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetViewVeterinarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewveterinariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellidoVeterinario;
        private System.Windows.Forms.TextBox textBoxNombreVeterinario;
        private System.Windows.Forms.TextBox textBoxMatriculaVeterinario;
        private dbVSDataSetViewVeterinarios dbVSDataSetViewVeterinarios;
        private System.Windows.Forms.BindingSource viewveterinariosBindingSource;
        private dbVSDataSetViewVeterinariosTableAdapters.view_veterinariosTableAdapter view_veterinariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoveterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxEspecialidadVeterinario;
    }
}