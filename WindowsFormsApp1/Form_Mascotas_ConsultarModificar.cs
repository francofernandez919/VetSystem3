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
    public partial class Form_Mascotas_ConsultarModificar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;
        DataSet DatosPerros = new DataSet();
        DataSet DatosGatos = new DataSet();

        public Form_Mascotas_ConsultarModificar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
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

        private void Form_Mascotas_ConsultarModificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoMascota.tipoMascota' table. You can move, or remove it, as needed.
            this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);
            // TODO: This line of code loads data into the 'dbVSDataSetViewMascotas.view_mascotas' table. You can move, or remove it, as needed.
            this.view_mascotasTableAdapter.Fill(this.dbVSDataSetViewMascotas.view_mascotas);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "DNI Dueño";
            item1.Value = "FK_mascota_cliente";
            comboBoxBuscar.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Nombre Dueño";
            item2.Value = "nombre_cliente";
            comboBoxBuscar.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Apellido Dueño";
            item3.Value = "apellido_cliente";
            comboBoxBuscar.Items.Add(item3);

            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Nombre Mascota";
            item4.Value = "nombre_mascota";
            comboBoxBuscar.Items.Add(item4);

            comboBoxBuscar.SelectedIndex = -1;
            comboBoxTipoMascota.SelectedIndex = -1;
            comboBoxRazaMascota.SelectedIndex = -1;

        }

        private void comboBoxTipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoMascota.SelectedIndex == 0)
            {
                conexion.Open();

                SqlCommand consulta = new SqlCommand("SELECT id_raza, nombre_raza FROM raza WHERE FK_raza_tipo = 1", conexion);
                adaptador.SelectCommand = consulta;
                adaptador.Fill(DatosPerros, "raza");

                DataTable dtblDataSource = new DataTable();
                dtblDataSource.Columns.Add("DisplayMember");
                dtblDataSource.Columns.Add("ValueMember");

                for (int fila = 0; fila < DatosPerros.Tables["raza"].Rows.Count; fila++)
                {
                    string cod1 = DatosPerros.Tables["raza"].Rows[fila]["nombre_raza"].ToString();
                    int cod2 = int.Parse(DatosPerros.Tables["raza"].Rows[fila]["id_raza"].ToString());
                    dtblDataSource.Rows.Add(cod1, cod2);
                }

                comboBoxRazaMascota.DataSource = null;
                comboBoxRazaMascota.Items.Clear();
                comboBoxRazaMascota.DataSource = dtblDataSource;
                comboBoxRazaMascota.DisplayMember = "DisplayMember";
                comboBoxRazaMascota.ValueMember = "ValueMember";
                DatosPerros.Clear();

                conexion.Close();
            }

            if (comboBoxTipoMascota.SelectedIndex == 1)
            {
                conexion.Open();

                SqlCommand consulta = new SqlCommand("SELECT id_raza, nombre_raza FROM raza WHERE FK_raza_tipo = 2", conexion);
                adaptador.SelectCommand = consulta;

                adaptador.Fill(DatosGatos, "raza");

                DataTable dtblDataSource2 = new DataTable();
                dtblDataSource2.Columns.Add("DisplayMember");
                dtblDataSource2.Columns.Add("ValueMember");

                for (int fila = 0; fila < DatosGatos.Tables["raza"].Rows.Count; fila++)
                {
                    string cod1 = DatosGatos.Tables["raza"].Rows[fila]["nombre_raza"].ToString();
                    int cod2 = int.Parse(DatosGatos.Tables["raza"].Rows[fila]["id_raza"].ToString());
                    dtblDataSource2.Rows.Add(cod1, cod2);
                }

                comboBoxRazaMascota.DataSource = null;
                comboBoxRazaMascota.Items.Clear();
                comboBoxRazaMascota.DataSource = dtblDataSource2;
                comboBoxRazaMascota.DisplayMember = "DisplayMember";
                comboBoxRazaMascota.ValueMember = "ValueMember";
                DatosGatos.Clear();

                conexion.Close();
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar parametro de busqueda.");
            }
            else
            {
                conexion.Open();

                string busqueda = (comboBoxBuscar.SelectedItem as ComboboxItem).Value.ToString();

                string query = "SELECT * FROM view_mascotas WHERE " + busqueda + " like '%" + textBoxBuscar.Text + "%'";
                SqlCommand buscar = new SqlCommand(query, conexion);
                adaptador.SelectCommand = buscar;

                DataSet data = new DataSet();
                adaptador.Fill(data, "view_mascotas");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "view_mascotas";

                conexion.Close();

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxDNI.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxNombreCliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxApellidoCliente.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            labelidMascota.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNombreMascota.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxTipoMascota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxRazaMascota.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna mascota.");
            }
            else
            {
                string dni = textBoxDNI.Text;
                int id = int.Parse(labelidMascota.Text);
                string nombre = textBoxNombreMascota.Text;
                int tipo = int.Parse(comboBoxTipoMascota.SelectedValue.ToString());
                int raza = int.Parse(comboBoxRazaMascota.SelectedValue.ToString());

                conexion.Open();

                SqlCommand consulta = new SqlCommand("SELECT * FROM cliente WHERE dni_cliente ='" + dni + "'", conexion);
                SqlDataReader registro = consulta.ExecuteReader();
                if (registro.Read())
                {
                    if (textBoxNombreMascota.Text.Equals("") || comboBoxTipoMascota.Text.Equals("") || comboBoxRazaMascota.Text.Equals(""))
                    {
                        conexion.Close();

                        MessageBox.Show("Complete los campos obligatorios.");
                    }
                    else
                    {
                        conexion.Close();

                        conexion.Open();

                        string cadena = "UPDATE mascota SET nombre_mascota = '" + nombre + "', FK_mascota_tipo = " + tipo + ", FK_mascota_raza = " + raza + " WHERE id_mascota = " + id;
                        SqlCommand comando = new SqlCommand(cadena, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();
                        if (cant == 1)
                        {
                            conexion.Close();

                            MessageBox.Show("Los datos de la mascota han sido modificados.");

                            comboBoxBuscar.SelectedIndex = -1;
                            textBoxBuscar.Text = "";

                            textBoxDNI.Text = "";
                            textBoxNombreCliente.Text = "";
                            textBoxApellidoCliente.Text = "";
                            labelidMascota.Text = "";
                            textBoxNombreMascota.Text = "";
                            comboBoxTipoMascota.SelectedIndex = -1;
                            comboBoxRazaMascota.SelectedIndex = -1;

                            refresh();
                        }
                        else
                        {
                            conexion.Close();

                            MessageBox.Show("No se ha podido realizar la operacion.");

                        }
                    }
                }
                else
                {
                    conexion.Close();

                    MessageBox.Show("No existe un cliente con el DNI ingresado.");

                    comboBoxBuscar.SelectedIndex = -1;
                    textBoxBuscar.Text = "";

                    textBoxDNI.Text = "";
                    textBoxNombreCliente.Text = "";
                    textBoxApellidoCliente.Text = "";
                    labelidMascota.Text = "";
                    textBoxNombreMascota.Text = "";
                    comboBoxTipoMascota.SelectedIndex = -1;
                    comboBoxRazaMascota.SelectedIndex = -1;

                    refresh();
                }
            }
        }

        private void refresh()
        {
            conexion.Open();

            string query = "SELECT * FROM view_mascotas";
            SqlCommand buscar = new SqlCommand(query, conexion);
            adaptador.SelectCommand = buscar;

            DataSet data = new DataSet();
            adaptador.Fill(data, "view_mascotas");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "view_mascotas";

            conexion.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBoxBuscar.Text = "";

            textBoxDNI.Text = "";
            textBoxNombreCliente.Text = "";
            textBoxApellidoCliente.Text = "";
            labelidMascota.Text = "";
            textBoxNombreMascota.Text = "";
            comboBoxTipoMascota.SelectedIndex = -1;
            comboBoxRazaMascota.SelectedIndex = -1;

            refresh();
        }

        private void textBoxNombreMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void comboBoxRazaMascota_DropDown(object sender, EventArgs e)
        {
            if (comboBoxTipoMascota.Text.Equals(""))
            {
                MessageBox.Show("Seleccione primero el tipo de animal.");
            }
        }
    }
}