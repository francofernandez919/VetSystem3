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
    public partial class Form_Mascotas_Registrar2 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;
        DataSet DatosPerros = new DataSet();
        DataSet DatosGatos = new DataSet();

        public Form_Mascotas_Registrar2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Form_Mascotas_Registrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoMascota.tipoMascota' table. You can move, or remove it, as needed.
            this.tipoMascotaTableAdapter.Fill(this.dbVSDataSetTableTipoMascota.tipoMascota);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            comboBoxTipoMascota.SelectedIndex = -1;
            comboBoxRazaMascota.SelectedIndex = -1;

            SqlCommand registrarMascota = new SqlCommand("INSERT INTO mascota(nombre_mascota, FK_mascota_tipo, FK_mascota_raza, FK_mascota_cliente) values (@nombre, @tipoMascota, @raza, @dni)", conexion);
            adaptador.InsertCommand = registrarMascota;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoMascota", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@raza", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.NVarChar));
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

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@dni"].Value = textBoxDNI.Text;
            adaptador.InsertCommand.Parameters["@nombre"].Value = textBoxNombreMascota.Text;
            adaptador.InsertCommand.Parameters["@tipoMascota"].Value = comboBoxTipoMascota.SelectedValue;
            adaptador.InsertCommand.Parameters["@raza"].Value = comboBoxRazaMascota.SelectedValue;

            string dni = textBoxDNI.Text;

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
                    try
                    {
                        conexion.Close();

                        conexion.Open();

                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("La mascota ha sido registrada.");
                    }
                    catch (SqlException excepcion)
                    {
                        MessageBox.Show(excepcion.ToString());
                    }
                    finally
                    {
                        conexion.Close();

                        textBoxNombreMascota.Text = "";
                        comboBoxTipoMascota.SelectedIndex = -1;
                        comboBoxRazaMascota.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                conexion.Close();

                MessageBox.Show("No existe un cliente con el DNI ingresado.");

                textBoxNombreMascota.Text = "";
                comboBoxTipoMascota.SelectedIndex = -1;
                comboBoxRazaMascota.SelectedIndex = -1;
            }
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
            if(comboBoxTipoMascota.Text.Equals(""))
            {
                MessageBox.Show("Seleccione primero el tipo de animal.");
            }
        }
    }
}
