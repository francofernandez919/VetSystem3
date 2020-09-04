namespace WindowsFormsApp1
{
    partial class Form_Tipos_Actualizar
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
            this.buttonModificarTipo = new System.Windows.Forms.Button();
            this.textBoxModificarTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarTipo = new System.Windows.Forms.ComboBox();
            this.tipoMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoMascota = new WindowsFormsApp1.dbVSDataSetTableTipoMascota();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarTipo = new System.Windows.Forms.Button();
            this.textBoxAgregarTipo = new System.Windows.Forms.TextBox();
            this.tipoMascotaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificarTipo);
            this.groupBox2.Controls.Add(this.textBoxModificarTipo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarTipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Tipo de Animal";
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
            // buttonModificarTipo
            // 
            this.buttonModificarTipo.Location = new System.Drawing.Point(235, 92);
            this.buttonModificarTipo.Name = "buttonModificarTipo";
            this.buttonModificarTipo.Size = new System.Drawing.Size(160, 25);
            this.buttonModificarTipo.TabIndex = 5;
            this.buttonModificarTipo.Text = "Modificar";
            this.buttonModificarTipo.UseVisualStyleBackColor = true;
            this.buttonModificarTipo.Click += new System.EventHandler(this.buttonModificarTipo_Click);
            // 
            // textBoxModificarTipo
            // 
            this.textBoxModificarTipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarTipo.Location = new System.Drawing.Point(235, 56);
            this.textBoxModificarTipo.MaxLength = 50;
            this.textBoxModificarTipo.Name = "textBoxModificarTipo";
            this.textBoxModificarTipo.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarTipo.TabIndex = 4;
            this.textBoxModificarTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarTipo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nombre Tipo de Animal:";
            // 
            // comboBoxModificarTipo
            // 
            this.comboBoxModificarTipo.DataSource = this.tipoMascotaBindingSource;
            this.comboBoxModificarTipo.DisplayMember = "nombre_tipo_mascota";
            this.comboBoxModificarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarTipo.FormattingEnabled = true;
            this.comboBoxModificarTipo.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarTipo.Name = "comboBoxModificarTipo";
            this.comboBoxModificarTipo.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarTipo.TabIndex = 3;
            this.comboBoxModificarTipo.ValueMember = "id_tipo_mascota";
            this.comboBoxModificarTipo.SelectedValueChanged += new System.EventHandler(this.comboBoxModificarTipo_SelectedValueChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Tipo de Animal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregarTipo);
            this.groupBox1.Controls.Add(this.textBoxAgregarTipo);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tipo de Animal";
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
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Tipo de Animal:";
            // 
            // buttonAgregarTipo
            // 
            this.buttonAgregarTipo.Location = new System.Drawing.Point(235, 57);
            this.buttonAgregarTipo.Name = "buttonAgregarTipo";
            this.buttonAgregarTipo.Size = new System.Drawing.Size(160, 25);
            this.buttonAgregarTipo.TabIndex = 2;
            this.buttonAgregarTipo.Text = "Agregar";
            this.buttonAgregarTipo.UseVisualStyleBackColor = true;
            this.buttonAgregarTipo.Click += new System.EventHandler(this.buttonAgregarTipo_Click);
            // 
            // textBoxAgregarTipo
            // 
            this.textBoxAgregarTipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarTipo.Location = new System.Drawing.Point(235, 19);
            this.textBoxAgregarTipo.MaxLength = 50;
            this.textBoxAgregarTipo.Name = "textBoxAgregarTipo";
            this.textBoxAgregarTipo.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarTipo.TabIndex = 1;
            this.textBoxAgregarTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarTipo_KeyPress);
            // 
            // tipoMascotaTableAdapter
            // 
            this.tipoMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Tipos_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Tipos_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Tipos_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarTipo;
        private System.Windows.Forms.TextBox textBoxModificarTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarTipo;
        private System.Windows.Forms.TextBox textBoxAgregarTipo;
        private dbVSDataSetTableTipoMascota dbVSDataSetTableTipoMascota;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource;
        private dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter tipoMascotaTableAdapter;
    }
}