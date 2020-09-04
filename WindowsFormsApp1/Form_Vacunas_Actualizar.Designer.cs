namespace WindowsFormsApp1
{
    partial class Form_Vacunas_Actualizar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificarVacuna = new System.Windows.Forms.Button();
            this.textBoxModificarVacuna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarVacuna = new System.Windows.Forms.ComboBox();
            this.tipoVacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoVacuna = new WindowsFormsApp1.dbVSDataSetTableTipoVacuna();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarVacuna = new System.Windows.Forms.Button();
            this.textBoxAgregarVacuna = new System.Windows.Forms.TextBox();
            this.tipoVacunaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoVacunaTableAdapters.tipoVacunaTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVacunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoVacuna)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificarVacuna);
            this.groupBox2.Controls.Add(this.textBoxModificarVacuna);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarVacuna);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Vacuna";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::WindowsFormsApp1.Properties.Resources.delete_small;
            this.buttonEliminar.Location = new System.Drawing.Point(519, 82);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificarVacuna
            // 
            this.buttonModificarVacuna.Location = new System.Drawing.Point(235, 92);
            this.buttonModificarVacuna.Name = "buttonModificarVacuna";
            this.buttonModificarVacuna.Size = new System.Drawing.Size(160, 25);
            this.buttonModificarVacuna.TabIndex = 5;
            this.buttonModificarVacuna.Text = "Modificar";
            this.buttonModificarVacuna.UseVisualStyleBackColor = true;
            this.buttonModificarVacuna.Click += new System.EventHandler(this.buttonModificarVacuna_Click);
            // 
            // textBoxModificarVacuna
            // 
            this.textBoxModificarVacuna.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarVacuna.Location = new System.Drawing.Point(235, 56);
            this.textBoxModificarVacuna.MaxLength = 50;
            this.textBoxModificarVacuna.Name = "textBoxModificarVacuna";
            this.textBoxModificarVacuna.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarVacuna.TabIndex = 4;
            this.textBoxModificarVacuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarVacuna_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nombre de Vacuna:";
            // 
            // comboBoxModificarVacuna
            // 
            this.comboBoxModificarVacuna.DataSource = this.tipoVacunaBindingSource;
            this.comboBoxModificarVacuna.DisplayMember = "nombre_tipo_vacuna";
            this.comboBoxModificarVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarVacuna.FormattingEnabled = true;
            this.comboBoxModificarVacuna.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarVacuna.Name = "comboBoxModificarVacuna";
            this.comboBoxModificarVacuna.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarVacuna.TabIndex = 3;
            this.comboBoxModificarVacuna.ValueMember = "id_tipo_vacuna";
            this.comboBoxModificarVacuna.SelectedValueChanged += new System.EventHandler(this.comboBoxModificarVacuna_SelectedValueChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Vacuna:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregarVacuna);
            this.groupBox1.Controls.Add(this.textBoxAgregarVacuna);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Vacuna";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Vacuna:";
            // 
            // buttonAgregarVacuna
            // 
            this.buttonAgregarVacuna.Location = new System.Drawing.Point(235, 57);
            this.buttonAgregarVacuna.Name = "buttonAgregarVacuna";
            this.buttonAgregarVacuna.Size = new System.Drawing.Size(160, 25);
            this.buttonAgregarVacuna.TabIndex = 2;
            this.buttonAgregarVacuna.Text = "Agregar";
            this.buttonAgregarVacuna.UseVisualStyleBackColor = true;
            this.buttonAgregarVacuna.Click += new System.EventHandler(this.buttonAgregarVacuna_Click);
            // 
            // textBoxAgregarVacuna
            // 
            this.textBoxAgregarVacuna.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarVacuna.Location = new System.Drawing.Point(235, 19);
            this.textBoxAgregarVacuna.MaxLength = 50;
            this.textBoxAgregarVacuna.Name = "textBoxAgregarVacuna";
            this.textBoxAgregarVacuna.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarVacuna.TabIndex = 1;
            this.textBoxAgregarVacuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarVacuna_KeyPress);
            // 
            // tipoVacunaTableAdapter
            // 
            this.tipoVacunaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Vacunas_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Vacunas_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Vacunas_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVacunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoVacuna)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarVacuna;
        private System.Windows.Forms.TextBox textBoxModificarVacuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarVacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarVacuna;
        private System.Windows.Forms.TextBox textBoxAgregarVacuna;
        private dbVSDataSetTableTipoVacuna dbVSDataSetTableTipoVacuna;
        private System.Windows.Forms.BindingSource tipoVacunaBindingSource;
        private dbVSDataSetTableTipoVacunaTableAdapters.tipoVacunaTableAdapter tipoVacunaTableAdapter;
    }
}