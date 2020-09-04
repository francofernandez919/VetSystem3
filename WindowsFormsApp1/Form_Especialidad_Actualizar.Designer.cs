namespace WindowsFormsApp1
{
    partial class Form_Especialidad_Actualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Especialidad_Actualizar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificarEspecialidad = new System.Windows.Forms.Button();
            this.textBoxModificarEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadVeterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableEspecialidad = new WindowsFormsApp1.dbVSDataSetTableEspecialidad();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarEspecialidad = new System.Windows.Forms.Button();
            this.textBoxAgregarEspecialidad = new System.Windows.Forms.TextBox();
            this.especialidadVeterinarioTableAdapter = new WindowsFormsApp1.dbVSDataSetTableEspecialidadTableAdapters.especialidadVeterinarioTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadVeterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableEspecialidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificarEspecialidad);
            this.groupBox2.Controls.Add(this.textBoxModificarEspecialidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarEspecialidad);
            this.groupBox2.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::WindowsFormsApp1.Properties.Resources.delete_small;
            resources.ApplyResources(this.buttonEliminar, "buttonEliminar");
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificarEspecialidad
            // 
            resources.ApplyResources(this.buttonModificarEspecialidad, "buttonModificarEspecialidad");
            this.buttonModificarEspecialidad.Name = "buttonModificarEspecialidad";
            this.buttonModificarEspecialidad.UseVisualStyleBackColor = true;
            this.buttonModificarEspecialidad.Click += new System.EventHandler(this.buttonModificarEspecialidad_Click);
            // 
            // textBoxModificarEspecialidad
            // 
            resources.ApplyResources(this.textBoxModificarEspecialidad, "textBoxModificarEspecialidad");
            this.textBoxModificarEspecialidad.Name = "textBoxModificarEspecialidad";
            this.textBoxModificarEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarEspecialidad_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBoxModificarEspecialidad
            // 
            this.comboBoxModificarEspecialidad.DataSource = this.especialidadVeterinarioBindingSource;
            this.comboBoxModificarEspecialidad.DisplayMember = "nombre_especialidad";
            this.comboBoxModificarEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarEspecialidad.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxModificarEspecialidad, "comboBoxModificarEspecialidad");
            this.comboBoxModificarEspecialidad.Name = "comboBoxModificarEspecialidad";
            this.comboBoxModificarEspecialidad.ValueMember = "id_especialidad";
            this.comboBoxModificarEspecialidad.SelectedValueChanged += new System.EventHandler(this.comboBoxModificarEspecialidad_SelectedValueChanged);
            // 
            // especialidadVeterinarioBindingSource
            // 
            this.especialidadVeterinarioBindingSource.DataMember = "especialidadVeterinario";
            this.especialidadVeterinarioBindingSource.DataSource = this.dbVSDataSetTableEspecialidad;
            // 
            // dbVSDataSetTableEspecialidad
            // 
            this.dbVSDataSetTableEspecialidad.DataSetName = "dbVSDataSetTableEspecialidad";
            this.dbVSDataSetTableEspecialidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregarEspecialidad);
            this.groupBox1.Controls.Add(this.textBoxAgregarEspecialidad);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonAgregarEspecialidad
            // 
            resources.ApplyResources(this.buttonAgregarEspecialidad, "buttonAgregarEspecialidad");
            this.buttonAgregarEspecialidad.Name = "buttonAgregarEspecialidad";
            this.buttonAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.buttonAgregarEspecialidad.Click += new System.EventHandler(this.buttonAgregarEspecialidad_Click);
            // 
            // textBoxAgregarEspecialidad
            // 
            resources.ApplyResources(this.textBoxAgregarEspecialidad, "textBoxAgregarEspecialidad");
            this.textBoxAgregarEspecialidad.Name = "textBoxAgregarEspecialidad";
            this.textBoxAgregarEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarEspecialidad_KeyPress);
            // 
            // especialidadVeterinarioTableAdapter
            // 
            this.especialidadVeterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Especialidad_Actualizar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Especialidad_Actualizar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Especialidad_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadVeterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableEspecialidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarEspecialidad;
        private System.Windows.Forms.TextBox textBoxModificarEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarEspecialidad;
        private System.Windows.Forms.TextBox textBoxAgregarEspecialidad;
        private dbVSDataSetTableEspecialidad dbVSDataSetTableEspecialidad;
        private System.Windows.Forms.BindingSource especialidadVeterinarioBindingSource;
        private dbVSDataSetTableEspecialidadTableAdapters.especialidadVeterinarioTableAdapter especialidadVeterinarioTableAdapter;
    }
}