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
    public partial class Form_Vacunas_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Vacunas_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Vacunas_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoVacuna.tipoVacuna' table. You can move, or remove it, as needed.
            this.tipoVacunaTableAdapter.Fill(this.dbVSDataSetTableTipoVacuna.tipoVacuna);

            comboBoxModificarVacuna.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarVacuna = new SqlCommand("INSERT INTO tipoVacuna(nombre_tipo_vacuna) values (@nombreVacuna)", conexion);
            adaptador.InsertCommand = registrarVacuna;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreVacuna", SqlDbType.NVarChar));
        }

        private void buttonAgregarVacuna_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarVacuna.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombreVacuna"].Value = textBoxAgregarVacuna.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("La vacuna ha sido agregada.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarVacuna.Text = "";

                    this.tipoVacunaTableAdapter.Fill(this.dbVSDataSetTableTipoVacuna.tipoVacuna);
                    comboBoxModificarVacuna.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }

        private void buttonModificarVacuna_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarVacuna.Text.Equals("") || textBoxModificarVacuna.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarVacuna.SelectedValue.ToString());
                string nombre = textBoxModificarVacuna.Text;

                string query = "UPDATE tipoVacuna SET nombre_tipo_vacuna = '" + nombre + "' WHERE id_tipo_vacuna = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("La vacuna ha sido modificada.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarVacuna.Text = "";

                this.tipoVacunaTableAdapter.Fill(this.dbVSDataSetTableTipoVacuna.tipoVacuna);
                comboBoxModificarVacuna.SelectedIndex = -1;
                textBoxModificarVacuna.Text = "";

                conexion.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void textBoxAgregarVacuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarVacuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxModificarVacuna_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarVacuna.Text = comboBoxModificarVacuna.Text;
            textBoxModificarVacuna.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarVacuna.Text.Equals("") || textBoxModificarVacuna.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna vacuna.");
            }
            else
            {
                Form_Vacunas_Eliminar eliminarVacuna = new Form_Vacunas_Eliminar();
                eliminarVacuna.labelidVacunaEliminar.Text = comboBoxModificarVacuna.SelectedValue.ToString();
                eliminarVacuna.Show();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxAgregarVacuna.Text = "";

            this.tipoVacunaTableAdapter.Fill(this.dbVSDataSetTableTipoVacuna.tipoVacuna);
            comboBoxModificarVacuna.SelectedIndex = -1;
            textBoxModificarVacuna.Text = "";

            textBoxAgregarVacuna.Focus();
        }
    }
}
