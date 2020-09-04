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
    public partial class Form_Tipos_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Tipos_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Tipos_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoMascota.tipoMascota' table. You can move, or remove it, as needed.
            this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);

            comboBoxModificarTipo.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarTipo = new SqlCommand("INSERT INTO tipoMascota(nombre_tipo_mascota) values (@nombreTipo)", conexion);
            adaptador.InsertCommand = registrarTipo;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreTipo", SqlDbType.NVarChar));
        }

        private void buttonAgregarTipo_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarTipo.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombreTipo"].Value = textBoxAgregarTipo.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("El tipo de animal ha sido agregado.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarTipo.Text = "";

                    this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);
                    comboBoxModificarTipo.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }

        private void buttonModificarTipo_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarTipo.Text.Equals("") || textBoxModificarTipo.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarTipo.SelectedValue.ToString());
                string nombre = textBoxModificarTipo.Text;

                string query = "UPDATE tipoMascota SET nombre_tipo_mascota = '" + nombre + "' WHERE id_tipo_mascota = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("El tipo de animal ha sido modificado.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarTipo.Text = "";

                this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);
                comboBoxModificarTipo.SelectedIndex = -1;
                textBoxModificarTipo.Text = "";

                conexion.Close();
            }
        }

        private void textBoxAgregarTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxAgregarTipo.Text = "";

            this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);
            comboBoxModificarTipo.SelectedIndex = -1;
            textBoxModificarTipo.Text = "";

            textBoxAgregarTipo.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarTipo.Text.Equals("") || textBoxModificarTipo.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun tipo de animal.");
            }
            else
            {
                Form_Tipos_Eliminar eliminarTipo = new Form_Tipos_Eliminar();
                eliminarTipo.labelidTipoEliminar.Text = comboBoxModificarTipo.SelectedValue.ToString();
                eliminarTipo.Show();
            }
        }

        private void comboBoxModificarTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarTipo.Text = comboBoxModificarTipo.Text;
            textBoxModificarTipo.Focus();
        }
    }
}
