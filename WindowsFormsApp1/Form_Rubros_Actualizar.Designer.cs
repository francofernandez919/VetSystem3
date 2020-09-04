namespace WindowsFormsApp1
{
    partial class Form_Rubros_Actualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarRubro = new System.Windows.Forms.Button();
            this.textBoxAgregarRubro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonModificarRubro = new System.Windows.Forms.Button();
            this.textBoxModificarRubro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarRubro = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableRubro = new WindowsFormsApp1.dbVSDataSetTableRubro();
            this.label2 = new System.Windows.Forms.Label();
            this.rubroTableAdapter = new WindowsFormsApp1.dbVSDataSetTableRubroTableAdapters.rubroTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregarRubro);
            this.groupBox1.Controls.Add(this.textBoxAgregarRubro);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Rubro";
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
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Rubro:";
            // 
            // buttonAgregarRubro
            // 
            this.buttonAgregarRubro.Location = new System.Drawing.Point(235, 57);
            this.buttonAgregarRubro.Name = "buttonAgregarRubro";
            this.buttonAgregarRubro.Size = new System.Drawing.Size(160, 25);
            this.buttonAgregarRubro.TabIndex = 2;
            this.buttonAgregarRubro.Text = "Agregar";
            this.buttonAgregarRubro.UseVisualStyleBackColor = true;
            this.buttonAgregarRubro.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAgregarRubro
            // 
            this.textBoxAgregarRubro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarRubro.Location = new System.Drawing.Point(235, 19);
            this.textBoxAgregarRubro.MaxLength = 50;
            this.textBoxAgregarRubro.Name = "textBoxAgregarRubro";
            this.textBoxAgregarRubro.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarRubro.TabIndex = 1;
            this.textBoxAgregarRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarRubro_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonModificarRubro);
            this.groupBox2.Controls.Add(this.textBoxModificarRubro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarRubro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Rubro";
            // 
            // button4
            // 
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.button4.Location = new System.Drawing.Point(519, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources.delete_small;
            this.button3.Location = new System.Drawing.Point(519, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonModificarRubro
            // 
            this.buttonModificarRubro.Location = new System.Drawing.Point(235, 92);
            this.buttonModificarRubro.Name = "buttonModificarRubro";
            this.buttonModificarRubro.Size = new System.Drawing.Size(160, 25);
            this.buttonModificarRubro.TabIndex = 5;
            this.buttonModificarRubro.Text = "Modificar";
            this.buttonModificarRubro.UseVisualStyleBackColor = true;
            this.buttonModificarRubro.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxModificarRubro
            // 
            this.textBoxModificarRubro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarRubro.Location = new System.Drawing.Point(235, 56);
            this.textBoxModificarRubro.MaxLength = 50;
            this.textBoxModificarRubro.Name = "textBoxModificarRubro";
            this.textBoxModificarRubro.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarRubro.TabIndex = 4;
            this.textBoxModificarRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarRubro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nombre de Rubro:";
            // 
            // comboBoxModificarRubro
            // 
            this.comboBoxModificarRubro.DataSource = this.rubroBindingSource;
            this.comboBoxModificarRubro.DisplayMember = "nombre_rubro";
            this.comboBoxModificarRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarRubro.FormattingEnabled = true;
            this.comboBoxModificarRubro.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarRubro.Name = "comboBoxModificarRubro";
            this.comboBoxModificarRubro.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarRubro.TabIndex = 3;
            this.comboBoxModificarRubro.ValueMember = "id_rubro";
            this.comboBoxModificarRubro.SelectedValueChanged += new System.EventHandler(this.comboBoxRubros_SelectedValueChanged);
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "rubro";
            this.rubroBindingSource.DataSource = this.dbVSDataSetTableRubro;
            // 
            // dbVSDataSetTableRubro
            // 
            this.dbVSDataSetTableRubro.DataSetName = "dbVSDataSetTableRubro";
            this.dbVSDataSetTableRubro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Rubro:";
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Rubros_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Rubros_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.Load += new System.EventHandler(this.Form_Rubros_Actualizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableRubro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarRubro;
        private System.Windows.Forms.TextBox textBoxAgregarRubro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonModificarRubro;
        private System.Windows.Forms.TextBox textBoxModificarRubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarRubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private dbVSDataSetTableRubro dbVSDataSetTableRubro;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private dbVSDataSetTableRubroTableAdapters.rubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}