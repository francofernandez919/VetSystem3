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
    public partial class Form_Turnos_ConsultarModificar : Form
    {

        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Turnos_ConsultarModificar()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoTurno.tipoTurno' table. You can move, or remove it, as needed.
            this.tipoTurnoTableAdapter.Fill(this.dbVSDataSetTableTipoTurno.tipoTurno);
            // TODO: This line of code loads data into the 'dbVSDataSetTableVeterinario.veterinario' table. You can move, or remove it, as needed.
            this.veterinarioTableAdapter.Fill(this.dbVSDataSetTableVeterinario.veterinario);
            // TODO: This line of code loads data into the 'dbVSDataSetViewTurnos.view_turnos' table. You can move, or remove it, as needed.
            this.view_turnosTableAdapter.Fill(this.dbVSDataSetViewTurnos.view_turnos);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            comboBoxHora.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;
            comboBoxTipoTurno.SelectedIndex = -1;

            labelTime.Text = DateTime.Today.ToString();
            dateTimePicker1.Value = DateTime.Parse(labelTime.Text);
        }

        public int maxVet()
        {
            string fecha = dateTimePicker1.Value.ToShortDateString();
            string hora = comboBoxHora.Text;
            int vet = int.Parse(comboBoxVeterinario.SelectedValue.ToString());

            string query = "SELECT COUNT(*) FROM turno WHERE fecha_turno = '" + fecha + "' AND hora_turno = '" + hora + "' AND FK_turno_veterinario = " + vet;
            int count = 0;

            using (SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;"))
            {
                using (SqlCommand cmdCount = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
                conexion.Close();
            }
            return count;
        }

        public int maxTurnos()
        {
            string fecha = dateTimePicker1.Value.ToShortDateString();
            string hora = comboBoxHora.Text;

            string query = "SELECT COUNT(*) FROM view_turnos WHERE fecha_turno = '" + fecha + "' AND hora_turno = '" + hora + "'";
            int count = 0;

            using (SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;"))
            {
                using (SqlCommand cmdCount = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
                conexion.Close();
            }
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelidTurno.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun Turno");
            }
            else
            {
                if (comboBoxHora.Text.Equals("") || comboBoxVeterinario.Text.Equals("") || comboBoxTipoTurno.Text.Equals(""))
                {
                    MessageBox.Show("Complete los campos obligatorios.");
                }
                else
                {
                    if (dateTimePickerFecha.Value == DateTime.Today && DateTime.Parse(comboBoxHora.Text) < DateTime.Now)
                    {
                        MessageBox.Show("El horario elegido no es valido.");
                        comboBoxHora.SelectedIndex = -1;
                    }
                    else
                    {
                        if (maxTurnos() >= 2 || maxVet() >= 1)
                        {
                            MessageBox.Show("El horario elegido no es valido.");
                            comboBoxHora.SelectedIndex = -1;
                        }
                        else
                        {
                            int id = int.Parse(labelidTurno.Text);
                            string fecha = dateTimePickerFecha.Value.ToShortDateString();
                            string hora = comboBoxHora.Text;
                            int veterinario = int.Parse(comboBoxVeterinario.SelectedValue.ToString());
                            int tipo = int.Parse(comboBoxTipoTurno.SelectedValue.ToString());
                            string observacion = textBoxObservaciones.Text;

                            conexion.Open();

                            SqlCommand consulta = new SqlCommand("SELECT * FROM turno WHERE id_turno = " + id, conexion);
                            SqlDataReader registro = consulta.ExecuteReader();
                            if (registro.Read())
                            {
                                conexion.Close();

                                conexion.Open();

                                string cadena = "UPDATE turno SET fecha_turno = '" + fecha + "', hora_turno = '" + hora + "', observacion_turno = '" + observacion + "', FK_turno_veterinario = " + veterinario + ", FK_turno_tipoTurno = " + tipo + " WHERE id_turno = " + id;
                                SqlCommand comando = new SqlCommand(cadena, conexion);
                                int cant;
                                cant = comando.ExecuteNonQuery();
                                if (cant == 1)
                                {
                                    conexion.Close();

                                    MessageBox.Show("Los datos del turno han sido modificados.");

                                    dateTimePicker1.Value = DateTime.Now;

                                    dateTimePickerFecha.Value = DateTime.Today;
                                    comboBoxHora.SelectedIndex = -1;
                                    comboBoxVeterinario.SelectedIndex = -1;
                                    comboBoxTipoTurno.SelectedIndex = -1;
                                    textBoxObservaciones.Text = "";
                                    labelidTurno.Text = "";
                                }
                                else
                                {
                                    conexion.Close();
                                    MessageBox.Show("No se ha podido realizar la operacion.");

                                }
                            }
                            else
                            {
                                conexion.Close();

                                MessageBox.Show("No se ha podido realizar la operacion.");

                                dateTimePicker1.Value = DateTime.Now;

                                dateTimePickerFecha.Value = DateTime.Today;
                                comboBoxHora.SelectedIndex = -1;
                                comboBoxVeterinario.SelectedIndex = -1;
                                comboBoxTipoTurno.SelectedIndex = -1;
                                textBoxObservaciones.Text = "";
                                labelidTurno.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conexion.Open();

            string dia = dateTimePicker1.Value.ToShortDateString();

            string query = "SELECT * FROM view_turnos WHERE fecha_turno = '" + dia + "'";
            SqlCommand buscar = new SqlCommand(query, conexion);
            adaptador.SelectCommand = buscar;

            DataSet data = new DataSet();
            adaptador.Fill(data, "view_turnos");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "view_turnos";

            conexion.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            dateTimePickerFecha.Value = DateTime.Today;
            comboBoxHora.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;
            comboBoxTipoTurno.SelectedIndex = -1;
            textBoxObservaciones.Text = "";
            labelidTurno.Text = "";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePickerFecha.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxHora.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxVeterinario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxTipoTurno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxObservaciones.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            labelDNI.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            labelidTurno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimePickerFecha.Value.ToString()) < DateTime.Today)
            {
                MessageBox.Show("La fecha ingresada no es valida.");
                dateTimePickerFecha.Value = DateTime.Now;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(labelidTurno.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun Turno");
            }
            else
            {
                Form_Turnos_Eliminar eliminarTurno = new Form_Turnos_Eliminar();
                eliminarTurno.labelidTurnoEliminar.Text = labelidTurno.Text;
                eliminarTurno.Show();
            }
        }
    }
}