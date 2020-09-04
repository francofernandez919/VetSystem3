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
    public partial class Form_Desparasitacion_Registrar : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Desparasitacion_Registrar()
        {
            InitializeComponent();
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

        private void Form_Desparasitacion_Registrar_Load(object sender, EventArgs e)
        {
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

            SqlCommand registrarDesparasitacion = new SqlCommand("INSERT INTO desparasitacion(fecha_desparasitacion, observacion_desparasitacion, FK_desparasitacion_mascota) values (@fecha, @observacion, @idMascota)", conexion);
            adaptador.InsertCommand = registrarDesparasitacion;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@idMascota", SqlDbType.Int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelidMascota.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna mascota.");
            }
            else
            {
                adaptador.InsertCommand.Parameters["@fecha"].Value = dateTimePickerFecha.Value.Date.ToString();
                adaptador.InsertCommand.Parameters["@observacion"].Value = textBoxObservacion.Text;
                adaptador.InsertCommand.Parameters["@idMascota"].Value = int.Parse(labelidMascota.Text);
                try
                {
                    conexion.Open();
                    adaptador.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("La desparasitación se ha registrado con exito.");
                }
                catch (SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    conexion.Close();

                    comboBoxBuscar.SelectedIndex = -1;
                    textBoxBuscar.Text = "";

                    labelidMascota.Text = "";
                    textBoxNombreMascota.Text = "";
                    textBoxTipoMascota.Text = "";
                    textBoxRazaMascota.Text = "";
                    dateTimePickerFecha.Value = DateTime.Today;
                    textBoxObservacion.Text = "";

                    refresh();
                }
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelidMascota.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNombreMascota.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTipoMascota.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxRazaMascota.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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

            labelidMascota.Text = "";
            textBoxNombreMascota.Text = "";
            textBoxTipoMascota.Text = "";
            textBoxRazaMascota.Text = "";
            dateTimePickerFecha.Value = DateTime.Today;
            textBoxObservacion.Text = "";

            refresh();
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimePickerFecha.Value.ToString()) > DateTime.Today)
            {
                MessageBox.Show("La fecha ingresada no es valida.");
                dateTimePickerFecha.Value = DateTime.Today;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
