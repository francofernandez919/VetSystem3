namespace WindowsFormsApp1
{
    partial class Form_Historia_Clinica3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHCidMascota = new System.Windows.Forms.Label();
            this.textBoxHCPeso = new System.Windows.Forms.TextBox();
            this.labelHCSexo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxHCFoto = new System.Windows.Forms.TextBox();
            this.buttonImgAdd = new System.Windows.Forms.Button();
            this.buttonImgDelete = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.dateTimeHCFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHCRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHCTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHCNombre = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHCidMascota);
            this.groupBox1.Controls.Add(this.textBoxHCPeso);
            this.groupBox1.Controls.Add(this.labelHCSexo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxHCFoto);
            this.groupBox1.Controls.Add(this.buttonImgAdd);
            this.groupBox1.Controls.Add(this.buttonImgDelete);
            this.groupBox1.Controls.Add(this.buttonAbrir);
            this.groupBox1.Controls.Add(this.dateTimeHCFechaNac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButtonH);
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxHCRaza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHCTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxHCNombre);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar Historia Clinica";
            // 
            // labelHCidMascota
            // 
            this.labelHCidMascota.AutoSize = true;
            this.labelHCidMascota.Location = new System.Drawing.Point(339, 25);
            this.labelHCidMascota.Name = "labelHCidMascota";
            this.labelHCidMascota.Size = new System.Drawing.Size(0, 13);
            this.labelHCidMascota.TabIndex = 24;
            this.labelHCidMascota.Visible = false;
            // 
            // textBoxHCPeso
            // 
            this.textBoxHCPeso.Location = new System.Drawing.Point(116, 139);
            this.textBoxHCPeso.MaxLength = 6;
            this.textBoxHCPeso.Name = "textBoxHCPeso";
            this.textBoxHCPeso.Size = new System.Drawing.Size(73, 21);
            this.textBoxHCPeso.TabIndex = 4;
            this.textBoxHCPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHCPeso_KeyPress);
            // 
            // labelHCSexo
            // 
            this.labelHCSexo.AutoSize = true;
            this.labelHCSexo.Location = new System.Drawing.Point(203, 178);
            this.labelHCSexo.Name = "labelHCSexo";
            this.labelHCSexo.Size = new System.Drawing.Size(0, 13);
            this.labelHCSexo.TabIndex = 23;
            this.labelHCSexo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(336, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 157);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxHCFoto
            // 
            this.textBoxHCFoto.Location = new System.Drawing.Point(336, 204);
            this.textBoxHCFoto.Name = "textBoxHCFoto";
            this.textBoxHCFoto.ReadOnly = true;
            this.textBoxHCFoto.Size = new System.Drawing.Size(228, 21);
            this.textBoxHCFoto.TabIndex = 9;
            // 
            // buttonImgAdd
            // 
            this.buttonImgAdd.Location = new System.Drawing.Point(336, 236);
            this.buttonImgAdd.Name = "buttonImgAdd";
            this.buttonImgAdd.Size = new System.Drawing.Size(110, 25);
            this.buttonImgAdd.TabIndex = 10;
            this.buttonImgAdd.Text = "Subir Foto";
            this.buttonImgAdd.UseVisualStyleBackColor = true;
            this.buttonImgAdd.Click += new System.EventHandler(this.buttonImgAdd_Click);
            // 
            // buttonImgDelete
            // 
            this.buttonImgDelete.Location = new System.Drawing.Point(454, 236);
            this.buttonImgDelete.Name = "buttonImgDelete";
            this.buttonImgDelete.Size = new System.Drawing.Size(110, 25);
            this.buttonImgDelete.TabIndex = 11;
            this.buttonImgDelete.Text = "Eliminar Foto";
            this.buttonImgDelete.UseVisualStyleBackColor = true;
            this.buttonImgDelete.Click += new System.EventHandler(this.buttonImgDelete_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(117, 236);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(162, 25);
            this.buttonAbrir.TabIndex = 8;
            this.buttonAbrir.Text = "Guardar";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dateTimeHCFechaNac
            // 
            this.dateTimeHCFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHCFechaNac.Location = new System.Drawing.Point(119, 204);
            this.dateTimeHCFechaNac.Name = "dateTimeHCFechaNac";
            this.dateTimeHCFechaNac.Size = new System.Drawing.Size(160, 21);
            this.dateTimeHCFechaNac.TabIndex = 7;
            this.dateTimeHCFechaNac.ValueChanged += new System.EventHandler(this.dateTimeHCFechaNac_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha de Nac.:";
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Location = new System.Drawing.Point(116, 174);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(33, 17);
            this.radioButtonH.TabIndex = 5;
            this.radioButtonH.Text = "H";
            this.radioButtonH.UseVisualStyleBackColor = true;
            this.radioButtonH.CheckedChanged += new System.EventHandler(this.radioButtonH_CheckedChanged);
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(155, 174);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 6;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.CheckedChanged += new System.EventHandler(this.radioButtonM_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "(Kg.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "*Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Peso:";
            // 
            // textBoxHCRaza
            // 
            this.textBoxHCRaza.Location = new System.Drawing.Point(116, 104);
            this.textBoxHCRaza.MaxLength = 50;
            this.textBoxHCRaza.Name = "textBoxHCRaza";
            this.textBoxHCRaza.ReadOnly = true;
            this.textBoxHCRaza.Size = new System.Drawing.Size(160, 21);
            this.textBoxHCRaza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Raza:";
            // 
            // textBoxHCTipo
            // 
            this.textBoxHCTipo.Location = new System.Drawing.Point(116, 69);
            this.textBoxHCTipo.MaxLength = 50;
            this.textBoxHCTipo.Name = "textBoxHCTipo";
            this.textBoxHCTipo.ReadOnly = true;
            this.textBoxHCTipo.Size = new System.Drawing.Size(160, 21);
            this.textBoxHCTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo Animal:";
            // 
            // textBoxHCNombre
            // 
            this.textBoxHCNombre.Location = new System.Drawing.Point(117, 33);
            this.textBoxHCNombre.MaxLength = 50;
            this.textBoxHCNombre.Name = "textBoxHCNombre";
            this.textBoxHCNombre.ReadOnly = true;
            this.textBoxHCNombre.Size = new System.Drawing.Size(160, 21);
            this.textBoxHCNombre.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(496, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Volver atras";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Historia_Clinica3
            // 
            this.AcceptButton = this.buttonAbrir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(624, 297);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Historia_Clinica3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Historia_Clinica3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonImgAdd;
        private System.Windows.Forms.Button buttonImgDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBoxHCTipo;
        public System.Windows.Forms.TextBox textBoxHCNombre;
        public System.Windows.Forms.TextBox textBoxHCRaza;
        public System.Windows.Forms.DateTimePicker dateTimeHCFechaNac;
        public System.Windows.Forms.RadioButton radioButtonH;
        public System.Windows.Forms.RadioButton radioButtonM;
        public System.Windows.Forms.TextBox textBoxHCFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxHCPeso;
        public System.Windows.Forms.Label labelHCSexo;
        public System.Windows.Forms.Label labelHCidMascota;
    }
}