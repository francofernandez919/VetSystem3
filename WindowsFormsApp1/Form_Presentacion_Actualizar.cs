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
    public partial class Form_Presentacion_Actualizar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;


        public Form_Presentacion_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Presentacion_Actualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTablePresentacion.tipoPresentacion' table. You can move, or remove it, as needed.
            this.tipoPresentacionTableAdapter.Fill(this.dbVSDataSetTablePresentacion.tipoPresentacion);
            comboBoxModificarPresentacion.SelectedIndex = -1;

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarPresentacion = new SqlCommand("INSERT INTO tipoPresentacion(nombre_tipo_presentacion) values (@nombrePresentacion)", conexion);
            adaptador.InsertCommand = registrarPresentacion;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombrePresentacion", SqlDbType.NVarChar));
        }

        private void buttonAgregarPresentacion_Click(object sender, EventArgs e)
        {
            if (textBoxAgregarPresentacion.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@nombrePresentacion"].Value = textBoxAgregarPresentacion.Text;
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("El tipo de presentacion ha sido agregado.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    textBoxAgregarPresentacion.Text = "";

                    this.tipoPresentacionTableAdapter.Fill(this.dbVSDataSetTablePresentacion.tipoPresentacion);
                    comboBoxModificarPresentacion.SelectedIndex = -1;

                    conexion.Close();
                }
            }
        }

        private void buttonModificarPresentacion_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarPresentacion.Text.Equals("") || textBoxModificarPresentacion.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(comboBoxModificarPresentacion.SelectedValue.ToString());
                string nombre = textBoxModificarPresentacion.Text;

                string query = "UPDATE tipoPresentacion SET nombre_tipo_presentacion = '" + nombre + "' WHERE id_tipo_presentacion = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("El tipo de presentacion ha sido modificado.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                textBoxAgregarPresentacion.Text = "";

                this.tipoPresentacionTableAdapter.Fill(this.dbVSDataSetTablePresentacion.tipoPresentacion);
                comboBoxModificarPresentacion.SelectedIndex = -1;
                textBoxModificarPresentacion.Text = "";

                conexion.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxAgregarPresentacion.Text = "";

            this.tipoPresentacionTableAdapter.Fill(this.dbVSDataSetTablePresentacion.tipoPresentacion);
            comboBoxModificarPresentacion.SelectedIndex = -1;
            textBoxModificarPresentacion.Text = "";

            textBoxAgregarPresentacion.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarPresentacion.Text.Equals("") || textBoxModificarPresentacion.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun tipo de presentacion.");
            }
            else
            {
                Form_Presentacion_Eliminar eliminarPresentacion = new Form_Presentacion_Eliminar();
                eliminarPresentacion.labelidPresentacionEliminar.Text = comboBoxModificarPresentacion.SelectedValue.ToString();
                eliminarPresentacion.Show();
            }
        }

        private void textBoxAgregarPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void comboBoxModificarPresentacion_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxModificarPresentacion.Text = comboBoxModificarPresentacion.Text;
            textBoxModificarPresentacion.Focus();
        }
    }
}
