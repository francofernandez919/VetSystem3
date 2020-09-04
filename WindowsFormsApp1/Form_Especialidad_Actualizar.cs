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
    public partial class Form_Especialidad_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Especialidad_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Especialidad_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableEspecialidad.especialidadVeterinario' table. You can move, or remove it, as needed.
            this.especialidadVeterinarioTableAdapter.Fill(this.dbVSDataSetTableEspecialidad.especialidadVeterinario);

            comboBoxModificarEspecialidad.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarEspecialidad = new SqlCommand("INSERT INTO especialidadVeterinario(nombre_especialidad) values (@nombreEspecialidad)", conexion);
            adaptador.InsertCommand = registrarEspecialidad;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreEspecialidad", SqlDbType.NVarChar));
        }

        private void buttonAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarEspecialidad.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombreEspecialidad"].Value = textBoxAgregarEspecialidad.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("La especialidad ha sido agregada.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarEspecialidad.Text = "";

                    this.especialidadVeterinarioTableAdapter.Fill(this.dbVSDataSetTableEspecialidad.especialidadVeterinario);
                    comboBoxModificarEspecialidad.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }

        private void buttonModificarEspecialidad_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarEspecialidad.Text.Equals("") || textBoxModificarEspecialidad.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarEspecialidad.SelectedValue.ToString());
                string nombre = textBoxModificarEspecialidad.Text;

                string query = "UPDATE especialidadVeterinario SET nombre_especialidad = '" + nombre + "' WHERE id_especialidad = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("La especialidad ha sido modificada.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarEspecialidad.Text = "";

                this.especialidadVeterinarioTableAdapter.Fill(this.dbVSDataSetTableEspecialidad.especialidadVeterinario);
                comboBoxModificarEspecialidad.SelectedIndex = -1;
                textBoxModificarEspecialidad.Text = "";

                conexion.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxAgregarEspecialidad.Text = "";

            this.especialidadVeterinarioTableAdapter.Fill(this.dbVSDataSetTableEspecialidad.especialidadVeterinario);
            comboBoxModificarEspecialidad.SelectedIndex = -1;
            textBoxModificarEspecialidad.Text = "";
            textBoxAgregarEspecialidad.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarEspecialidad.Text.Equals("") || textBoxModificarEspecialidad.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna especialidad.");
            }
            else
            {
                Form_Especialidad_Eliminar eliminarEspecialidad = new Form_Especialidad_Eliminar();
                eliminarEspecialidad.labelidEspecialidadEliminar.Text = comboBoxModificarEspecialidad.SelectedValue.ToString();
                eliminarEspecialidad.Show();
            }
        }

        private void textBoxAgregarEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void comboBoxModificarEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarEspecialidad.Text = comboBoxModificarEspecialidad.Text;
            textBoxModificarEspecialidad.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
