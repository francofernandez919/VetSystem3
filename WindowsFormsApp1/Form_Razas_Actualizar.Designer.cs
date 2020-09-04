namespace WindowsFormsApp1
{
    partial class Form_Razas_Actualizar
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonAgregarRaza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAgregarRaza = new System.Windows.Forms.TextBox();
            this.comboBoxAgregarTipo = new System.Windows.Forms.ComboBox();
            this.tipoMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoMascota = new WindowsFormsApp1.dbVSDataSetTableTipoMascota();
            this.tipoMascotaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxModificarTipo = new System.Windows.Forms.ComboBox();
            this.tipoMascotaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificarRaza = new System.Windows.Forms.Button();
            this.textBoxModificarNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarRaza = new System.Windows.Forms.ComboBox();
            this.razaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableRaza = new WindowsFormsApp1.dbVSDataSetTableRaza();
            this.label4 = new System.Windows.Forms.Label();
            this.razaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableRazaTableAdapters.razaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.buttonAgregarRaza);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAgregarRaza);
            this.groupBox1.Controls.Add(this.comboBoxAgregarTipo);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Raza";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(486, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonAgregarRaza
            // 
            this.buttonAgregarRaza.Location = new System.Drawing.Point(235, 103);
            this.buttonAgregarRaza.Name = "buttonAgregarRaza";
            this.buttonAgregarRaza.Size = new System.Drawing.Size(160, 23);
            this.buttonAgregarRaza.TabIndex = 4;
            this.buttonAgregarRaza.Text = "Agregar";
            this.buttonAgregarRaza.UseVisualStyleBackColor = true;
            this.buttonAgregarRaza.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Tipo de Animal:";
            // 
            // textBoxAgregarRaza
            // 
            this.textBoxAgregarRaza.Location = new System.Drawing.Point(235, 61);
            this.textBoxAgregarRaza.Name = "textBoxAgregarRaza";
            this.textBoxAgregarRaza.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarRaza.TabIndex = 1;
            this.textBoxAgregarRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarRaza_KeyPress);
            // 
            // comboBoxAgregarTipo
            // 
            this.comboBoxAgregarTipo.DataSource = this.tipoMascotaBindingSource;
            this.comboBoxAgregarTipo.DisplayMember = "nombre_tipo_mascota";
            this.comboBoxAgregarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgregarTipo.FormattingEnabled = true;
            this.comboBoxAgregarTipo.Location = new System.Drawing.Point(235, 19);
            this.comboBoxAgregarTipo.Name = "comboBoxAgregarTipo";
            this.comboBoxAgregarTipo.Size = new System.Drawing.Size(160, 21);
            this.comboBoxAgregarTipo.TabIndex = 0;
            this.comboBoxAgregarTipo.ValueMember = "id_tipo_mascota";
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
            // tipoMascotaTableAdapter
            // 
            this.tipoMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxModificarTipo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificarRaza);
            this.groupBox2.Controls.Add(this.textBoxModificarNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarRaza);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Raza";
            // 
            // comboBoxModificarTipo
            // 
            this.comboBoxModificarTipo.DataSource = this.tipoMascotaBindingSource1;
            this.comboBoxModificarTipo.DisplayMember = "nombre_tipo_mascota";
            this.comboBoxModificarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarTipo.FormattingEnabled = true;
            this.comboBoxModificarTipo.Location = new System.Drawing.Point(235, 57);
            this.comboBoxModificarTipo.Name = "comboBoxModificarTipo";
            this.comboBoxModificarTipo.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarTipo.TabIndex = 16;
            this.comboBoxModificarTipo.ValueMember = "id_tipo_mascota";
            // 
            // tipoMascotaBindingSource1
            // 
            this.tipoMascotaBindingSource1.DataMember = "tipoMascota";
            this.tipoMascotaBindingSource1.DataSource = this.dbVSDataSetTableTipoMascota;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "*Tipo de Animal:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::WindowsFormsApp1.Properties.Resources.delete_small;
            this.buttonEliminar.Location = new System.Drawing.Point(519, 125);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificarRaza
            // 
            this.buttonModificarRaza.Location = new System.Drawing.Point(235, 135);
            this.buttonModificarRaza.Name = "buttonModificarRaza";
            this.buttonModificarRaza.Size = new System.Drawing.Size(160, 25);
            this.buttonModificarRaza.TabIndex = 12;
            this.buttonModificarRaza.Text = "Modificar";
            this.buttonModificarRaza.UseVisualStyleBackColor = true;
            this.buttonModificarRaza.Click += new System.EventHandler(this.buttonModificarRaza_Click);
            // 
            // textBoxModificarNombre
            // 
            this.textBoxModificarNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarNombre.Location = new System.Drawing.Point(235, 96);
            this.textBoxModificarNombre.MaxLength = 50;
            this.textBoxModificarNombre.Name = "textBoxModificarNombre";
            this.textBoxModificarNombre.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarNombre.TabIndex = 11;
            this.textBoxModificarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreModificar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Nombre de Raza:";
            // 
            // comboBoxModificarRaza
            // 
            this.comboBoxModificarRaza.DataSource = this.razaBindingSource;
            this.comboBoxModificarRaza.DisplayMember = "nombre_raza";
            this.comboBoxModificarRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarRaza.FormattingEnabled = true;
            this.comboBoxModificarRaza.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarRaza.Name = "comboBoxModificarRaza";
            this.comboBoxModificarRaza.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarRaza.TabIndex = 10;
            this.comboBoxModificarRaza.ValueMember = "id_raza";
            this.comboBoxModificarRaza.SelectedValueChanged += new System.EventHandler(this.comboBoxRazaModificar_SelectedValueChanged);
            // 
            // razaBindingSource
            // 
            this.razaBindingSource.DataMember = "raza";
            this.razaBindingSource.DataSource = this.dbVSDataSetTableRaza;
            // 
            // dbVSDataSetTableRaza
            // 
            this.dbVSDataSetTableRaza.DataSetName = "dbVSDataSetTableRaza";
            this.dbVSDataSetTableRaza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Seleccionar Raza:";
            // 
            // razaTableAdapter
            // 
            this.razaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Razas_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Razas_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableRaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAgregarRaza;
        private System.Windows.Forms.ComboBox comboBoxAgregarTipo;
        private System.Windows.Forms.Button buttonAgregarRaza;
        private System.Windows.Forms.Label label2;
        private dbVSDataSetTableTipoMascota dbVSDataSetTableTipoMascota;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource;
        private dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter tipoMascotaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarRaza;
        private System.Windows.Forms.TextBox textBoxModificarNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarRaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private dbVSDataSetTableRaza dbVSDataSetTableRaza;
        private System.Windows.Forms.BindingSource razaBindingSource;
        private dbVSDataSetTableRazaTableAdapters.razaTableAdapter razaTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxModificarTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource1;
    }
}