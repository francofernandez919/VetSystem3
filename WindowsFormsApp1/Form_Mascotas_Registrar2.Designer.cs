namespace WindowsFormsApp1
{
    partial class Form_Mascotas_Registrar2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreMascota = new System.Windows.Forms.TextBox();
            this.comboBoxTipoMascota = new System.Windows.Forms.ComboBox();
            this.tipoMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTableTipoMascota = new WindowsFormsApp1.dbVSDataSetTableTipoMascota();
            this.comboBoxRazaMascota = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoMascotaTableAdapter = new WindowsFormsApp1.dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nombre Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Tipo Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Raza:";
            // 
            // textBoxNombreMascota
            // 
            this.textBoxNombreMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMascota.Location = new System.Drawing.Point(235, 100);
            this.textBoxNombreMascota.MaxLength = 50;
            this.textBoxNombreMascota.Name = "textBoxNombreMascota";
            this.textBoxNombreMascota.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreMascota.TabIndex = 8;
            this.textBoxNombreMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreMascota_KeyPress);
            // 
            // comboBoxTipoMascota
            // 
            this.comboBoxTipoMascota.DataSource = this.tipoMascotaBindingSource;
            this.comboBoxTipoMascota.DisplayMember = "nombre_tipo_mascota";
            this.comboBoxTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoMascota.FormattingEnabled = true;
            this.comboBoxTipoMascota.Location = new System.Drawing.Point(235, 127);
            this.comboBoxTipoMascota.Name = "comboBoxTipoMascota";
            this.comboBoxTipoMascota.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoMascota.TabIndex = 9;
            this.comboBoxTipoMascota.ValueMember = "id_tipo_mascota";
            this.comboBoxTipoMascota.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoMascota_SelectedIndexChanged);
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
            // comboBoxRazaMascota
            // 
            this.comboBoxRazaMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRazaMascota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRazaMascota.FormattingEnabled = true;
            this.comboBoxRazaMascota.Location = new System.Drawing.Point(235, 154);
            this.comboBoxRazaMascota.Name = "comboBoxRazaMascota";
            this.comboBoxRazaMascota.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRazaMascota.TabIndex = 10;
            this.comboBoxRazaMascota.DropDown += new System.EventHandler(this.comboBoxRazaMascota_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBoxApellidoCliente);
            this.groupBox1.Controls.Add(this.textBoxNombreCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxRazaMascota);
            this.groupBox1.Controls.Add(this.comboBoxTipoMascota);
            this.groupBox1.Controls.Add(this.textBoxNombreMascota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wolf1;
            this.pictureBox1.Location = new System.Drawing.Point(458, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver al Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Enabled = false;
            this.textBoxApellidoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(235, 73);
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.ReadOnly = true;
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxApellidoCliente.TabIndex = 6;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCliente.Location = new System.Drawing.Point(235, 46);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(160, 21);
            this.textBoxNombreCliente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellido Dueño:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Enabled = false;
            this.textBoxDNI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(235, 19);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(160, 21);
            this.textBoxDNI.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI Dueño:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoMascotaTableAdapter
            // 
            this.tipoMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Mascotas_Registrar2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 247);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Mascotas_Registrar2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Mascotas_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTableTipoMascota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreMascota;
        private System.Windows.Forms.ComboBox comboBoxTipoMascota;
        private System.Windows.Forms.ComboBox comboBoxRazaMascota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private dbVSDataSetTableTipoMascota dbVSDataSetTableTipoMascota;
        private System.Windows.Forms.BindingSource tipoMascotaBindingSource;
        private dbVSDataSetTableTipoMascotaTableAdapters.tipoMascotaTableAdapter tipoMascotaTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxDNI;
        public System.Windows.Forms.TextBox textBoxApellidoCliente;
        public System.Windows.Forms.TextBox textBoxNombreCliente;
    }
}