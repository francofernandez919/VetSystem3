using System;
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
    public partial class Form_Practicas_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Practicas_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Practicas_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTablePracticas.practicasVeterinarias' table. You can move, or remove it, as needed.
            this.practicasVeterinariasTableAdapter.Fill(this.dbVSDataSetTablePracticas.practicasVeterinarias);

            comboBoxModificarPractica.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarPractica = new SqlCommand("INSERT INTO practicasVeterinarias(nombre_practica) values (@nombrePractica)", conexion);
            adaptador.InsertCommand = registrarPractica;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombrePractica", SqlDbType.NVarChar));
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxAgregarPractica.Text = "";

            this.practicasVeterinariasTableAdapter.Fill(this.dbVSDataSetTablePracticas.practicasVeterinarias);
            comboBoxModificarPractica.SelectedIndex = -1;
            textBoxModificarPractica.Text = "";

            textBoxAgregarPractica.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarPractica.Text.Equals("") || textBoxModificarPractica.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna practica veterinaria.");
            }
            else
            {
                Form_Practicas_Eliminar eliminarPracticas = new Form_Practicas_Eliminar();
                eliminarPracticas.labelidPracticaEliminar.Text = comboBoxModificarPractica.SelectedValue.ToString();
                eliminarPracticas.Show();
            }
        }

        private void linkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void textBoxAgregarPractica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void comboBoxModificarPractica_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarPractica.Text = comboBoxModificarPractica.Text;
            textBoxModificarPractica.Focus();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarPractica.Text.Equals("") || textBoxModificarPractica.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarPractica.SelectedValue.ToString());
                string nombre = textBoxModificarPractica.Text;

                string query = "UPDATE practicasVeterinarias SET nombre_practica = '" + nombre + "' WHERE id_practica = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("La practica veterinaria ha sido modificada.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarPractica.Text = "";

                this.practicasVeterinariasTableAdapter.Fill(this.dbVSDataSetTablePracticas.practicasVeterinarias);
                comboBoxModificarPractica.SelectedIndex = -1;
                textBoxModificarPractica.Text = "";

                conexion.Close();
            }
        }

        private void textBoxModificarPractica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarPractica.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombrePractica"].Value = textBoxAgregarPractica.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("La practica veterinaria ha sido agregada.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarPractica.Text = "";

                    this.practicasVeterinariasTableAdapter.Fill(this.dbVSDataSetTablePracticas.practicasVeterinarias);
                    comboBoxModificarPractica.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }
    }
}
