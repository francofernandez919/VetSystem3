namespace WindowsFormsApp1
{
    partial class Form_Presentacion_Actualizar
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
            this.buttonModificarPresentacion = new System.Windows.Forms.Button();
            this.textBoxModificarPresentacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarPresentacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarPresentacion = new System.Windows.Forms.Button();
            this.textBoxAgregarPresentacion = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dbVSDataSetTablePresentacion = new WindowsFormsApp1.dbVSDataSetTablePresentacion();
            this.tipoPresentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPresentacionTableAdapter = new WindowsFormsApp1.dbVSDataSetTablePresentacionTableAdapters.tipoPresentacionTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTablePresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPresentacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificarPresentacion);
            this.groupBox2.Controls.Add(this.textBoxModificarPresentacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarPresentacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Tipo de Presentación";
            // 
            // buttonModificarPresentacion
            // 
            this.buttonModificarPresentacion.Location = new System.Drawing.Point(235, 92);
            this.buttonModificarPresentacion.Name = "buttonModificarPresentacion";
            this.buttonModificarPresentacion.Size = new System.Drawing.Size(160, 25);
            this.buttonModificarPresentacion.TabIndex = 5;
            this.buttonModificarPresentacion.Text = "Modificar";
            this.buttonModificarPresentacion.UseVisualStyleBackColor = true;
            this.buttonModificarPresentacion.Click += new System.EventHandler(this.buttonModificarPresentacion_Click);
            // 
            // textBoxModificarPresentacion
            // 
            this.textBoxModificarPresentacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarPresentacion.Location = new System.Drawing.Point(235, 56);
            this.textBoxModificarPresentacion.MaxLength = 50;
            this.textBoxModificarPresentacion.Name = "textBoxModificarPresentacion";
            this.textBoxModificarPresentacion.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarPresentacion.TabIndex = 4;
            this.textBoxModificarPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarPresentacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nombre Tipo de Presentación:";
            // 
            // comboBoxModificarPresentacion
            // 
            this.comboBoxModificarPresentacion.DataSource = this.tipoPresentacionBindingSource;
            this.comboBoxModificarPresentacion.DisplayMember = "nombre_tipo_presentacion";
            this.comboBoxModificarPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarPresentacion.FormattingEnabled = true;
            this.comboBoxModificarPresentacion.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarPresentacion.Name = "comboBoxModificarPresentacion";
            this.comboBoxModificarPresentacion.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarPresentacion.TabIndex = 3;
            this.comboBoxModificarPresentacion.ValueMember = "id_tipo_presentacion";
            this.comboBoxModificarPresentacion.SelectedValueChanged += new System.EventHandler(this.comboBoxModificarPresentacion_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Tipo de Presentación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregarPresentacion);
            this.groupBox1.Controls.Add(this.textBoxAgregarPresentacion);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tipo de Presentación";
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
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Tipo de Presentación:";
            // 
            // buttonAgregarPresentacion
            // 
            this.buttonAgregarPresentacion.Location = new System.Drawing.Point(235, 57);
            this.buttonAgregarPresentacion.Name = "buttonAgregarPresentacion";
            this.buttonAgregarPresentacion.Size = new System.Drawing.Size(160, 25);
            this.buttonAgregarPresentacion.TabIndex = 2;
            this.buttonAgregarPresentacion.Text = "Agregar";
            this.buttonAgregarPresentacion.UseVisualStyleBackColor = true;
            this.buttonAgregarPresentacion.Click += new System.EventHandler(this.buttonAgregarPresentacion_Click);
            // 
            // textBoxAgregarPresentacion
            // 
            this.textBoxAgregarPresentacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarPresentacion.Location = new System.Drawing.Point(235, 19);
            this.textBoxAgregarPresentacion.MaxLength = 50;
            this.textBoxAgregarPresentacion.Name = "textBoxAgregarPresentacion";
            this.textBoxAgregarPresentacion.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarPresentacion.TabIndex = 1;
            this.textBoxAgregarPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarPresentacion_KeyPress);
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
            // dbVSDataSetTablePresentacion
            // 
            this.dbVSDataSetTablePresentacion.DataSetName = "dbVSDataSetTablePresentacion";
            this.dbVSDataSetTablePresentacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoPresentacionBindingSource
            // 
            this.tipoPresentacionBindingSource.DataMember = "tipoPresentacion";
            this.tipoPresentacionBindingSource.DataSource = this.dbVSDataSetTablePresentacion;
            // 
            // tipoPresentacionTableAdapter
            // 
            this.tipoPresentacionTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Presentacion_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Presentacion_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Presentacion_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTablePresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPresentacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarPresentacion;
        private System.Windows.Forms.TextBox textBoxModificarPresentacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarPresentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarPresentacion;
        private System.Windows.Forms.TextBox textBoxAgregarPresentacion;
        private dbVSDataSetTablePresentacion dbVSDataSetTablePresentacion;
        private System.Windows.Forms.BindingSource tipoPresentacionBindingSource;
        private dbVSDataSetTablePresentacionTableAdapters.tipoPresentacionTableAdapter tipoPresentacionTableAdapter;
    }
}