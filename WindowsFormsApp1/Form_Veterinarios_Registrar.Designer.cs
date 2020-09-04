namespace WindowsFormsApp1
{
    partial class Form_Veterinarios_Registrar
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
            this.textBoxMatriculaVeterinario = new System.Windows.Forms.TextBox();
            this.textBoxNombreVeterinario = new System.Windows.Forms.TextBox();
            this.textBoxApellidoVeterinario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEspecialidadVeterinario = new System.Windows.Forms.ComboBox();
            this.especialidadVeterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableEspecialidad = new WindowsFormsApp1.dbVSDataSetTableEspecialidad();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.especialidadVeterinarioTableAdapter = new WindowsFormsApp1.dbVSDataSetTableEspecialidadTableAdapters.especialidadVeterinarioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadVeterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMatriculaVeterinario
            // 
            this.textBoxMatriculaVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatriculaVeterinario.Location = new System.Drawing.Point(275, 20);
            this.textBoxMatriculaVeterinario.Name = "textBoxMatriculaVeterinario";
            this.textBoxMatriculaVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxMatriculaVeterinario.TabIndex = 1;
            this.textBoxMatriculaVeterinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMatriculaVeterinario_KeyPress);
            // 
            // textBoxNombreVeterinario
            // 
            this.textBoxNombreVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreVeterinario.Location = new System.Drawing.Point(275, 47);
            this.textBoxNombreVeterinario.MaxLength = 50;
            this.textBoxNombreVeterinario.Name = "textBoxNombreVeterinario";
            this.textBoxNombreVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreVeterinario.TabIndex = 2;
            this.textBoxNombreVeterinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreVeterinario_KeyPress);
            // 
            // textBoxApellidoVeterinario
            // 
            this.textBoxApellidoVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoVeterinario.Location = new System.Drawing.Point(275, 74);
            this.textBoxApellidoVeterinario.MaxLength = 50;
            this.textBoxApellidoVeterinario.Name = "textBoxApellidoVeterinario";
            this.textBoxApellidoVeterinario.Size = new System.Drawing.Size(160, 21);
            this.textBoxApellidoVeterinario.TabIndex = 3;
            this.textBoxApellidoVeterinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoVeterinario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Apellido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBoxEspecialidadVeterinario);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
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
            this.groupBox1.Size = new System.Drawing.Size(600, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Veterinario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.vete;
            this.pictureBox1.Location = new System.Drawing.Point(17, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxEspecialidadVeterinario
            // 
            this.comboBoxEspecialidadVeterinario.DataSource = this.especialidadVeterinarioBindingSource;
            this.comboBoxEspecialidadVeterinario.DisplayMember = "nombre_especialidad";
            this.comboBoxEspecialidadVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEspecialidadVeterinario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEspecialidadVeterinario.FormattingEnabled = true;
            this.comboBoxEspecialidadVeterinario.Location = new System.Drawing.Point(275, 101);
            this.comboBoxEspecialidadVeterinario.Name = "comboBoxEspecialidadVeterinario";
            this.comboBoxEspecialidadVeterinario.Size = new System.Drawing.Size(160, 21);
            this.comboBoxEspecialidadVeterinario.TabIndex = 4;
            this.comboBoxEspecialidadVeterinario.ValueMember = "id_especialidad";
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Especialidad:";
            // 
            // especialidadVeterinarioTableAdapter
            // 
            this.especialidadVeterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Veterinarios_Registrar
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 236);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Veterinarios_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form13_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadVeterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatriculaVeterinario;
        private System.Windows.Forms.TextBox textBoxNombreVeterinario;
        private System.Windows.Forms.TextBox textBoxApellidoVeterinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBoxEspecialidadVeterinario;
        private System.Windows.Forms.Label label4;
        private dbVSDataSetTableEspecialidad dbVSDataSetTableEspecialidad;
        private System.Windows.Forms.BindingSource especialidadVeterinarioBindingSource;
        private dbVSDataSetTableEspecialidadTableAdapters.especialidadVeterinarioTableAdapter especialidadVeterinarioTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}