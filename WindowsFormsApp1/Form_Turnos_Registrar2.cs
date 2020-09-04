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
    public partial class Form_Turnos_Registrar2 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Turnos_Registrar2()
        {
            InitializeComponent();
        }

        private void Form_Turnos_Registrar2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableTipoTurno.tipoTurno' table. You can move, or remove it, as needed.
            this.tipoTurnoTableAdapter.Fill(this.dbVSDataSetTableTipoTurno.tipoTurno);
            // TODO: This line of code loads data into the 'dbVSDataSetTableVeterinario.veterinario' table. You can move, or remove it, as needed.
            this.veterinarioTableAdapter.Fill(this.dbVSDataSetTableVeterinario.veterinario);
            // TODO: This line of code loads data into the 'dbVSDataSetViewTurnos.view_turnos' table. You can move, or remove it, as needed.
            this.view_turnosTableAdapter.Fill(this.dbVSDataSetViewTurnos.view_turnos);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            labelToday.Text = DateTime.Today.ToString();
            dateTimePicker1.Value = DateTime.Parse(labelToday.Text);

            comboBoxHora.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;
            comboBoxTipoTurno.SelectedIndex = -1;

            SqlCommand registrarTurno = new SqlCommand("INSERT INTO turno(fecha_turno, hora_turno, observacion_turno, FK_turno_veterinario, FK_turno_cliente, FK_turno_tipoTurno) values (@fecha, @hora, @observacion, @veterinario, @dnicliente, @tipoturno)", conexion);
            adaptador.InsertCommand = registrarTurno;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@hora", SqlDbType.Time));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@veterinario", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dnicliente", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoturno", SqlDbType.Int));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxHora.Text.Equals("") || comboBoxVeterinario.Text.Equals("") || comboBoxTipoTurno.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                if (dateTimePicker1.Value == DateTime.Today && DateTime.Parse(comboBoxHora.Text) < DateTime.Now)
                {
                    MessageBox.Show("El horario elegido no es valido.");
                    comboBoxHora.SelectedIndex = -1;
                }
                else
                {
                    {
                        if (maxTurnos() >= 2 || maxVet() >= 1)
                        {
                            MessageBox.Show("El horario elegido no es valido.");
                            comboBoxHora.SelectedIndex = -1;
                        }
                        else
                        {
                            adaptador.InsertCommand.Parameters["@fecha"].Value = dateTimePicker1.Value.ToShortDateString();
                            adaptador.InsertCommand.Parameters["@hora"].Value = comboBoxHora.Text;
                            adaptador.InsertCommand.Parameters["@observacion"].Value = textBoxObservaciones.Text;
                            adaptador.InsertCommand.Parameters["@veterinario"].Value = comboBoxVeterinario.SelectedValue;
                            adaptador.InsertCommand.Parameters["@dnicliente"].Value = labelDNI.Text;
                            adaptador.InsertCommand.Parameters["@tipoturno"].Value = comboBoxTipoTurno.SelectedValue;

                            try
                            {
                                conexion.Close();

                                conexion.Open();

                                adaptador.InsertCommand.ExecuteNonQuery();
                                MessageBox.Show("El turno se ha registrado con exito.");
                            }
                            catch (SqlException excepcion)
                            {
                                MessageBox.Show(excepcion.ToString());
                            }
                            finally
                            {
                                conexion.Close();

                                dateTimePicker1.Value = DateTime.Now;

                                comboBoxHora.SelectedIndex = -1;
                                comboBoxVeterinario.SelectedIndex = -1;
                                comboBoxTipoTurno.SelectedIndex = -1;
                                textBoxObservaciones.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            comboBoxHora.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;
            comboBoxTipoTurno.SelectedIndex = -1;
            textBoxObservaciones.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimePicker1.Value.ToString()) < DateTime.Today)
            {
                MessageBox.Show("La fecha ingresada no es valida.");
                dateTimePicker1.Value = DateTime.Now;
            }
            else
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
        }
    }
}
