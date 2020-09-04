namespace WindowsFormsApp1
{
    partial class Form_Usuarios_Actualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios_Actualizar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonShow3 = new System.Windows.Forms.Button();
            this.buttonShow2 = new System.Windows.Forms.Button();
            this.comboBoxModificarUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVetSystemDataSet = new WindowsFormsApp1.dbVetSystemDataSet();
            this.buttonShow1 = new System.Windows.Forms.Button();
            this.comboBoxModificarRol = new System.Windows.Forms.ComboBox();
            this.buttonActualizarUsuario = new System.Windows.Forms.Button();
            this.textBoxModificarNombre = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new WindowsFormsApp1.dbVetSystemDataSetTableAdapters.usuarioTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBoxRegistrarRol = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarUsuario = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.buttonShowPass2 = new System.Windows.Forms.Button();
            this.buttonShowPass1 = new System.Windows.Forms.Button();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxRegistrarNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVetSystemDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonShow3);
            this.groupBox2.Controls.Add(this.buttonShow2);
            this.groupBox2.Controls.Add(this.comboBoxModificarUsuario);
            this.groupBox2.Controls.Add(this.buttonShow1);
            this.groupBox2.Controls.Add(this.comboBoxModificarRol);
            this.groupBox2.Controls.Add(this.buttonActualizarUsuario);
            this.groupBox2.Controls.Add(this.textBoxModificarNombre);
            this.groupBox2.Controls.Add(this.textBoxOldPass);
            this.groupBox2.Controls.Add(this.textBoxNewPassword1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxNewPassword2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 303);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Usuario";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh_small;
            this.buttonRefresh.Location = new System.Drawing.Point(519, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 35);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::WindowsFormsApp1.Properties.Resources.delete_small;
            this.buttonEliminar.Location = new System.Drawing.Point(519, 249);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonShow3
            // 
            this.buttonShow3.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow3.Image")));
            this.buttonShow3.Location = new System.Drawing.Point(401, 177);
            this.buttonShow3.Name = "buttonShow3";
            this.buttonShow3.Size = new System.Drawing.Size(35, 23);
            this.buttonShow3.TabIndex = 15;
            this.buttonShow3.UseVisualStyleBackColor = true;
            this.buttonShow3.Click += new System.EventHandler(this.buttonShow3_Click);
            // 
            // buttonShow2
            // 
            this.buttonShow2.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow2.Image")));
            this.buttonShow2.Location = new System.Drawing.Point(401, 136);
            this.buttonShow2.Name = "buttonShow2";
            this.buttonShow2.Size = new System.Drawing.Size(35, 23);
            this.buttonShow2.TabIndex = 13;
            this.buttonShow2.UseVisualStyleBackColor = true;
            this.buttonShow2.Click += new System.EventHandler(this.buttonShow2_Click);
            // 
            // comboBoxModificarUsuario
            // 
            this.comboBoxModificarUsuario.DataSource = this.usuarioBindingSource;
            this.comboBoxModificarUsuario.DisplayMember = "nombre_usuario";
            this.comboBoxModificarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarUsuario.FormattingEnabled = true;
            this.comboBoxModificarUsuario.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarUsuario.Name = "comboBoxModificarUsuario";
            this.comboBoxModificarUsuario.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarUsuario.TabIndex = 8;
            this.comboBoxModificarUsuario.ValueMember = "id_usuario";
            this.comboBoxModificarUsuario.SelectedValueChanged += new System.EventHandler(this.comboBoxUsuario_SelectedValueChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dbVetSystemDataSet;
            // 
            // dbVetSystemDataSet
            // 
            this.dbVetSystemDataSet.DataSetName = "dbVetSystemDataSet";
            this.dbVetSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonShow1
            // 
            this.buttonShow1.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow1.Image")));
            this.buttonShow1.Location = new System.Drawing.Point(401, 97);
            this.buttonShow1.Name = "buttonShow1";
            this.buttonShow1.Size = new System.Drawing.Size(35, 23);
            this.buttonShow1.TabIndex = 11;
            this.buttonShow1.UseVisualStyleBackColor = true;
            this.buttonShow1.Click += new System.EventHandler(this.buttonShow1_Click);
            // 
            // comboBoxModificarRol
            // 
            this.comboBoxModificarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarRol.FormattingEnabled = true;
            this.comboBoxModificarRol.Items.AddRange(new object[] {
            "Administrador",
            "Secretario",
            "Veterinario"});
            this.comboBoxModificarRol.Location = new System.Drawing.Point(235, 219);
            this.comboBoxModificarRol.Name = "comboBoxModificarRol";
            this.comboBoxModificarRol.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarRol.TabIndex = 16;
            // 
            // buttonActualizarUsuario
            // 
            this.buttonActualizarUsuario.Location = new System.Drawing.Point(235, 259);
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.Size = new System.Drawing.Size(160, 25);
            this.buttonActualizarUsuario.TabIndex = 17;
            this.buttonActualizarUsuario.Text = "Actualizar";
            this.buttonActualizarUsuario.UseVisualStyleBackColor = true;
            this.buttonActualizarUsuario.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // textBoxModificarNombre
            // 
            this.textBoxModificarNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarNombre.Location = new System.Drawing.Point(235, 59);
            this.textBoxModificarNombre.MaxLength = 50;
            this.textBoxModificarNombre.Name = "textBoxModificarNombre";
            this.textBoxModificarNombre.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarNombre.TabIndex = 9;
            this.textBoxModificarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarNombre_KeyPress);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(235, 98);
            this.textBoxOldPass.MaxLength = 50;
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.ReadOnly = true;
            this.textBoxOldPass.Size = new System.Drawing.Size(160, 21);
            this.textBoxOldPass.TabIndex = 10;
            this.textBoxOldPass.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword1
            // 
            this.textBoxNewPassword1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword1.Location = new System.Drawing.Point(235, 137);
            this.textBoxNewPassword1.MaxLength = 50;
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Size = new System.Drawing.Size(160, 21);
            this.textBoxNewPassword1.TabIndex = 12;
            this.textBoxNewPassword1.UseSystemPasswordChar = true;
            this.textBoxNewPassword1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPassword1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "*Nombre:";
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword2.Location = new System.Drawing.Point(235, 178);
            this.textBoxNewPassword2.MaxLength = 50;
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.Size = new System.Drawing.Size(160, 21);
            this.textBoxNewPassword2.TabIndex = 14;
            this.textBoxNewPassword2.UseSystemPasswordChar = true;
            this.textBoxNewPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPassword2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Usuario:";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.comboBoxRegistrarRol);
            this.groupBox1.Controls.Add(this.buttonRegistrarUsuario);
            this.groupBox1.Controls.Add(this.textBoxPassword1);
            this.groupBox1.Controls.Add(this.buttonShowPass2);
            this.groupBox1.Controls.Add(this.buttonShowPass1);
            this.groupBox1.Controls.Add(this.textBoxPassword2);
            this.groupBox1.Controls.Add(this.textBoxRegistrarNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Usuario";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(481, 17);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(113, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "<< Volver al Menu";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // comboBoxRegistrarRol
            // 
            this.comboBoxRegistrarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegistrarRol.FormattingEnabled = true;
            this.comboBoxRegistrarRol.Items.AddRange(new object[] {
            "Administrador",
            "Secretario",
            "Veterinario"});
            this.comboBoxRegistrarRol.Location = new System.Drawing.Point(235, 144);
            this.comboBoxRegistrarRol.Name = "comboBoxRegistrarRol";
            this.comboBoxRegistrarRol.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRegistrarRol.TabIndex = 6;
            // 
            // buttonRegistrarUsuario
            // 
            this.buttonRegistrarUsuario.Location = new System.Drawing.Point(235, 186);
            this.buttonRegistrarUsuario.Name = "buttonRegistrarUsuario";
            this.buttonRegistrarUsuario.Size = new System.Drawing.Size(160, 25);
            this.buttonRegistrarUsuario.TabIndex = 7;
            this.buttonRegistrarUsuario.Text = "Registrar";
            this.buttonRegistrarUsuario.UseVisualStyleBackColor = true;
            this.buttonRegistrarUsuario.Click += new System.EventHandler(this.buttonRegistrarUsuario_Click);
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword1.Location = new System.Drawing.Point(235, 60);
            this.textBoxPassword1.MaxLength = 50;
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(160, 21);
            this.textBoxPassword1.TabIndex = 2;
            this.textBoxPassword1.UseSystemPasswordChar = true;
            this.textBoxPassword1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword1_KeyPress);
            // 
            // buttonShowPass2
            // 
            this.buttonShowPass2.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPass2.Image")));
            this.buttonShowPass2.Location = new System.Drawing.Point(401, 102);
            this.buttonShowPass2.Name = "buttonShowPass2";
            this.buttonShowPass2.Size = new System.Drawing.Size(35, 23);
            this.buttonShowPass2.TabIndex = 5;
            this.buttonShowPass2.UseVisualStyleBackColor = true;
            this.buttonShowPass2.Click += new System.EventHandler(this.buttonShowPass2_Click);
            // 
            // buttonShowPass1
            // 
            this.buttonShowPass1.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPass1.Image")));
            this.buttonShowPass1.Location = new System.Drawing.Point(401, 59);
            this.buttonShowPass1.Name = "buttonShowPass1";
            this.buttonShowPass1.Size = new System.Drawing.Size(35, 23);
            this.buttonShowPass1.TabIndex = 3;
            this.buttonShowPass1.UseVisualStyleBackColor = true;
            this.buttonShowPass1.Click += new System.EventHandler(this.buttonShowPass1_Click);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword2.Location = new System.Drawing.Point(235, 103);
            this.textBoxPassword2.MaxLength = 50;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(160, 21);
            this.textBoxPassword2.TabIndex = 4;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            this.textBoxPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword2_KeyPress);
            // 
            // textBoxRegistrarNombre
            // 
            this.textBoxRegistrarNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistrarNombre.Location = new System.Drawing.Point(235, 19);
            this.textBoxRegistrarNombre.MaxLength = 50;
            this.textBoxRegistrarNombre.Name = "textBoxRegistrarNombre";
            this.textBoxRegistrarNombre.Size = new System.Drawing.Size(160, 21);
            this.textBoxRegistrarNombre.TabIndex = 1;
            this.textBoxRegistrarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegistrarNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "*Ingresar Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "*Seleccionar Rol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "*Repetir Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "*Nombre de Usuario:";
            // 
            // Form_Usuarios_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.linkLabel2;
            this.ClientSize = new System.Drawing.Size(624, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Usuarios_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Usuarios_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVetSystemDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxModificarRol;
        private System.Windows.Forms.Button buttonActualizarUsuario;
        private System.Windows.Forms.TextBox textBoxNewPassword1;
        private System.Windows.Forms.TextBox textBoxNewPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModificarUsuario;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Label label5;
        private dbVetSystemDataSet dbVetSystemDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private dbVetSystemDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Button buttonShow1;
        private System.Windows.Forms.TextBox textBoxModificarNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShow3;
        private System.Windows.Forms.Button buttonShow2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox comboBoxRegistrarRol;
        private System.Windows.Forms.Button buttonRegistrarUsuario;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxRegistrarNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonShowPass2;
        private System.Windows.Forms.Button buttonShowPass1;
    }
}