﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_Veterinarios_Consultar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Veterinarios_Consultar()
        {
            InitializeComponent();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void Form_Veterinarios_Consultar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetViewVeterinarios.view_veterinarios' table. You can move, or remove it, as needed.
            this.view_veterinariosTableAdapter.Fill(this.dbVSDataSetViewVeterinarios.view_veterinarios);
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "Matricula";
            item1.Value = "matricula_veterinario";
            comboBoxBuscar.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Nombre";
            item2.Value = "nombre_veterinario";
            comboBoxBuscar.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Apellido";
            item3.Value = "apellido_veterinario";
            comboBoxBuscar.Items.Add(item3);

            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Especialidad";
            item4.Value = "nombre_especialidad";
            comboBoxBuscar.Items.Add(item4);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBoxBuscar.Text = "";

            textBoxMatriculaVeterinario.Text = "";
            textBoxNombreVeterinario.Text = "";
            textBoxApellidoVeterinario.Text = "";
            textBoxEspecialidadVeterinario.Text = "";

            refresh();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un parámetro de busqueda.");
            }
            else
            {
                conexion.Open();

                string busqueda = (comboBoxBuscar.SelectedItem as ComboboxItem).Value.ToString();

                string query = "SELECT * FROM view_veterinarios WHERE " + busqueda + " like '%" + textBoxBuscar.Text + "%'";
                SqlCommand buscar = new SqlCommand(query, conexion);
                adaptador.SelectCommand = buscar;

                DataSet data = new DataSet();
                adaptador.Fill(data, "view_veterinarios");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "view_veterinarios";

                conexion.Close();
            }
        }

        private void refresh()
        {
            conexion.Open();

            string query = "SELECT * FROM view_veterinarios";
            SqlCommand buscar = new SqlCommand(query, conexion);
            adaptador.SelectCommand = buscar;

            DataSet data = new DataSet();
            adaptador.Fill(data, "view_veterinarios");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "view_veterinarios";

            conexion.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxMatriculaVeterinario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxNombreVeterinario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxApellidoVeterinario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxEspecialidadVeterinario.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
