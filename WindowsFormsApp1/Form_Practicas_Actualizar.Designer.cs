namespace WindowsFormsApp1
{
    partial class Form_Practicas_Actualizar
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
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxModificarPractica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModificarPractica = new System.Windows.Forms.ComboBox();
            this.practicasVeterinariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVSDataSetTablePracticas = new WindowsFormsApp1.dbVSDataSetTablePracticas();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkVolver = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxAgregarPractica = new System.Windows.Forms.TextBox();
            this.practicasVeterinariasTableAdapter = new WindowsFormsApp1.dbVSDataSetTablePracticasTableAdapters.practicasVeterinariasTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicasVeterinariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTablePracticas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonModificar);
            this.groupBox2.Controls.Add(this.textBoxModificarPractica);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxModificarPractica);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar | Eliminar Práctica Veterinaria";
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
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(235, 92);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(160, 25);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxModificarPractica
            // 
            this.textBoxModificarPractica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarPractica.Location = new System.Drawing.Point(235, 56);
            this.textBoxModificarPractica.MaxLength = 50;
            this.textBoxModificarPractica.Name = "textBoxModificarPractica";
            this.textBoxModificarPractica.Size = new System.Drawing.Size(160, 21);
            this.textBoxModificarPractica.TabIndex = 4;
            this.textBoxModificarPractica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModificarPractica_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Nombre Práctica Veterinaria:";
            // 
            // comboBoxModificarPractica
            // 
            this.comboBoxModificarPractica.DataSource = this.practicasVeterinariasBindingSource;
            this.comboBoxModificarPractica.DisplayMember = "nombre_practica";
            this.comboBoxModificarPractica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarPractica.FormattingEnabled = true;
            this.comboBoxModificarPractica.Location = new System.Drawing.Point(235, 19);
            this.comboBoxModificarPractica.Name = "comboBoxModificarPractica";
            this.comboBoxModificarPractica.Size = new System.Drawing.Size(160, 21);
            this.comboBoxModificarPractica.TabIndex = 3;
            this.comboBoxModificarPractica.ValueMember = "id_practica";
            this.comboBoxModificarPractica.SelectedValueChanged += new System.EventHandler(this.comboBoxModificarPractica_SelectedValueChanged);
            // 
            // practicasVeterinariasBindingSource
            // 
            this.practicasVeterinariasBindingSource.DataMember = "practicasVeterinarias";
            this.practicasVeterinariasBindingSource.DataSource = this.dbVSDataSetTablePracticas;
            // 
            // dbVSDataSetTablePracticas
            // 
            this.dbVSDataSetTablePracticas.DataSetName = "dbVSDataSetTablePracticas";
            this.dbVSDataSetTablePracticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Seleccionar Práctica Veterinaria:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkVolver);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.textBoxAgregarPractica);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Práctica Veterinaria";
            // 
            // linkVolver
            // 
            this.linkVolver.AutoSize = true;
            this.linkVolver.Location = new System.Drawing.Point(481, 17);
            this.linkVolver.Name = "linkVolver";
            this.linkVolver.Size = new System.Drawing.Size(113, 13);
            this.linkVolver.TabIndex = 7;
            this.linkVolver.TabStop = true;
            this.linkVolver.Text = "<< Volver al Menu";
            this.linkVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVolver_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Práctica Veterinaria:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(235, 57);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(160, 25);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxAgregarPractica
            // 
            this.textBoxAgregarPractica.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgregarPractica.Location = new System.Drawing.Point(235, 19);
            this.textBoxAgregarPractica.MaxLength = 50;
            this.textBoxAgregarPractica.Name = "textBoxAgregarPractica";
            this.textBoxAgregarPractica.Size = new System.Drawing.Size(160, 21);
            this.textBoxAgregarPractica.TabIndex = 1;
            this.textBoxAgregarPractica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAgregarPractica_KeyPress);
            // 
            // practicasVeterinariasTableAdapter
            // 
            this.practicasVeterinariasTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Practicas_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Practicas_Actualizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetSystem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Practicas_Actualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicasVeterinariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVSDataSetTablePracticas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxModificarPractica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModificarPractica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxAgregarPractica;
        private dbVSDataSetTablePracticas dbVSDataSetTablePracticas;
        private System.Windows.Forms.BindingSource practicasVeterinariasBindingSource;
        private dbVSDataSetTablePracticasTableAdapters.practicasVeterinariasTableAdapter practicasVeterinariasTableAdapter;
    }
}