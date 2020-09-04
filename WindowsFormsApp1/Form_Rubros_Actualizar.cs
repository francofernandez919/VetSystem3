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
    public partial class Form_Rubros_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Rubros_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Rubros_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableRubro.rubro' table. You can move, or remove it, as needed.
            this.rubroTableAdapter.Fill(this.dbVSDataSetTableRubro.rubro);

            comboBoxModificarRubro.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarRubro = new SqlCommand("INSERT INTO rubro(nombre_rubro) values (@nombreRubro)", conexion);
            adaptador.InsertCommand = registrarRubro;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreRubro", SqlDbType.NVarChar));

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarRubro.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombreRubro"].Value = textBoxAgregarRubro.Text;

                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("El rubro ha sido agregado.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarRubro.Text = "";

                    this.rubroTableAdapter.Fill(this.dbVSDataSetTableRubro.rubro);
                    comboBoxModificarRubro.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }

        private void textBoxAgregarRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarRubro.Text.Equals("") || textBoxModificarRubro.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarRubro.SelectedValue.ToString());
                string nombre = textBoxModificarRubro.Text;

                string query = "UPDATE rubro SET nombre_rubro = '" + nombre + "' WHERE id_rubro = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("El rubro ha sido modificado.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarRubro.Text = "";

                this.rubroTableAdapter.Fill(this.dbVSDataSetTableRubro.rubro);
                comboBoxModificarRubro.SelectedIndex = -1;
                textBoxModificarRubro.Text = "";

                conexion.Close();
            }
        }

        private void comboBoxRubros_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarRubro.Text = comboBoxModificarRubro.Text;
            textBoxModificarRubro.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarRubro.Text.Equals("") || textBoxModificarRubro.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun rubro.");
            }
            else
            {
                Form_Rubros_Eliminar eliminarRubro = new Form_Rubros_Eliminar();
                eliminarRubro.labelidRubroEliminar.Text = comboBoxModificarRubro.SelectedValue.ToString();
                eliminarRubro.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAgregarRubro.Text = "";

            this.rubroTableAdapter.Fill(this.dbVSDataSetTableRubro.rubro);
            comboBoxModificarRubro.SelectedIndex = -1;
            textBoxModificarRubro.Text = "";
            textBoxAgregarRubro.Focus();
        }
    }
}
