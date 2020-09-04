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
    public partial class Form_Veterinarios_Registrar : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Veterinarios_Registrar()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableEspecialidad.especialidadVeterinario' table. You can move, or remove it, as needed.
            this.especialidadVeterinarioTableAdapter.Fill(this.dbVSDataSetTableEspecialidad.especialidadVeterinario);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            comboBoxEspecialidadVeterinario.SelectedIndex = -1;

            SqlCommand altaVeterinario = new SqlCommand("insert into veterinario(matricula_veterinario, nombre_veterinario, apellido_veterinario, FK_veterinario_especialidad) values (@matricula, @nombre, @apellido, @especialidad)", conexion);
            adaptador.InsertCommand = altaVeterinario;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@matricula", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@especialidad", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMatriculaVeterinario.Text.Equals("") || textBoxNombreVeterinario.Text.Equals("") || textBoxApellidoVeterinario.Text.Equals("") || comboBoxEspecialidadVeterinario.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                int matricula = int.Parse(textBoxMatriculaVeterinario.Text);

                conexion.Open();

                SqlCommand consulta = new SqlCommand("SELECT * FROM veterinario WHERE matricula_veterinario = " + matricula, conexion);
                SqlDataReader registro = consulta.ExecuteReader();
                if (registro.Read())
                {
                    conexion.Close();

                    MessageBox.Show("La matricula ingresada ya existe.");
                    textBoxMatriculaVeterinario.Text = "";
                }
                else
                {
                    adaptador.InsertCommand.Parameters["@matricula"].Value = textBoxMatriculaVeterinario.Text;
                    adaptador.InsertCommand.Parameters["@nombre"].Value = textBoxNombreVeterinario.Text;
                    adaptador.InsertCommand.Parameters["@apellido"].Value = textBoxApellidoVeterinario.Text;
                    adaptador.InsertCommand.Parameters["@especialidad"].Value = comboBoxEspecialidadVeterinario.SelectedValue;

                    try
                    {
                        conexion.Close();

                        conexion.Open();

                        adaptador.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Se registro al veterinario correctamente.");
                    }
                    catch (SqlException excepcion)
                    {
                        MessageBox.Show("Error al cargar los datos."); //excepcion.ToString()
                    }
                    finally
                    {
                        conexion.Close();

                        textBoxMatriculaVeterinario.Text = "";
                        textBoxNombreVeterinario.Text = "";
                        textBoxApellidoVeterinario.Text = "";
                        comboBoxEspecialidadVeterinario.SelectedIndex = -1;
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void textBoxMatriculaVeterinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNombreVeterinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxApellidoVeterinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
