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
    public partial class Form_Razas_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Razas_Actualizar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            // TODO: This line of code loads data into the 'dbVSDataSetTableRaza.raza' table. You can move, or remove it, as needed.
            this.razaTableAdapter.Fill(this.dbVSDataSetTableRaza.raza);
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoMascota.tipoMascota' table. You can move, or remove it, as needed.
            this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);

            comboBoxAgregarTipo.SelectedIndex = -1;
            textBoxAgregarRaza.Text = "";

            comboBoxModificarRaza.SelectedIndex = -1;
            comboBoxModificarTipo.SelectedIndex = -1;
            textBoxModificarNombre.Text = "";

            SqlCommand registrarRaza = new SqlCommand("INSERT INTO raza(nombre_raza, FK_raza_tipo) values (@nombreRaza, @tipoAnimal)", conexion);
            adaptador.InsertCommand = registrarRaza;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreRaza", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoAnimal", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxAgregarTipo.Text.Equals("") || textBoxAgregarRaza.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombreRaza"].Value = textBoxAgregarRaza.Text;
                adaptador.InsertCommand.Parameters["@tipoAnimal"].Value = comboBoxAgregarTipo.SelectedValue;

                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("La raza ha sido agregada.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    conexion.Close();

                    comboBoxAgregarTipo.SelectedIndex = -1;
                    textBoxAgregarRaza.Text = "";

                    this.razaTableAdapter.Fill(this.dbVSDataSetTableRaza.raza);
                    comboBoxModificarRaza.SelectedIndex = -1;
                    comboBoxModificarTipo.SelectedIndex = -1;
                    textBoxModificarNombre.Text = "";
                }
            }
        }

        private void comboBoxRazaModificar_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxModificarRaza.SelectedIndex.Equals(-1))
            {

            }
            else
            {
                conexion.Open();

                int idRaza = int.Parse(comboBoxModificarRaza.SelectedValue.ToString());

                string query = "SELECT FK_raza_tipo FROM raza WHERE id_raza = " + idRaza;
                SqlCommand comando = new SqlCommand(query, conexion);
                
                comboBoxModificarTipo.SelectedValue = Convert.ToString(comando.ExecuteScalar());

                textBoxModificarNombre.Text = comboBoxModificarRaza.Text;
                textBoxModificarNombre.Focus();

                conexion.Close();
            }
        }

        private void buttonModificarRaza_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarRaza.Text.Equals("") || comboBoxModificarTipo.Text.Equals("") || textBoxModificarNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarRaza.SelectedValue.ToString());
                int tipo = int.Parse(comboBoxModificarTipo.SelectedValue.ToString());
                string nombre = textBoxModificarNombre.Text;

                string query = "UPDATE raza SET nombre_raza = '" + nombre + "', FK_raza_tipo = " + tipo + " WHERE id_raza = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("La raza ha sido modificada.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }
                conexion.Close();

                comboBoxAgregarTipo.SelectedIndex = -1;
                textBoxAgregarRaza.Text = "";

                this.razaTableAdapter.Fill(this.dbVSDataSetTableRaza.raza);
                comboBoxModificarRaza.SelectedIndex = -1;
                comboBoxModificarTipo.SelectedIndex = -1;
                textBoxModificarNombre.Text = "";
            }

        }

        private void textBoxNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxAgregarRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxAgregarTipo.SelectedIndex = -1;
            textBoxAgregarRaza.Text = "";

            this.razaTableAdapter.Fill(this.dbVSDataSetTableRaza.raza);
            comboBoxModificarRaza.SelectedIndex = -1;
            comboBoxModificarTipo.SelectedIndex = -1;
            textBoxModificarNombre.Text = "";

            textBoxAgregarRaza.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarRaza.Text.Equals("") || comboBoxModificarTipo.Text.Equals("") || textBoxModificarNombre.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna raza.");
            }
            else
            {
                conexion.Open();

                Form_Razas_Eliminar eliminarRaza = new Form_Razas_Eliminar();
                eliminarRaza.labelidRazaEliminar.Text = comboBoxModificarRaza.SelectedValue.ToString();
                eliminarRaza.Show();

                conexion.Close();
            }
        }
    }
}
