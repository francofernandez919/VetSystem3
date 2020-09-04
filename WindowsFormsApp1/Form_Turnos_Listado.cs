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
using System.Drawing.Printing;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form_Turnos_Listado : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Turnos_Listado()
        {
            InitializeComponent();
        }

        private void Form_Turnos_Emitir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetViewTurnos.view_turnos' table. You can move, or remove it, as needed.
            this.view_turnosTableAdapter.Fill(this.dbVSDataSetViewTurnos.view_turnos);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            dateTimePicker1.Value = DateTime.Now;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            //this.Dispose();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString(dataGridView1.Text, font, Brushes.Black, new RectangleF(0, 10, 120, 20));
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
                string cod = dateTimePicker1.Value.Date.ToString();

                conexion.Open();

                SqlCommand consulta = new SqlCommand("SELECT id_turno, fecha_turno, hora_turno, observacion_turno, nombre_veterinario, apellido_veterinario, nombre_tipo_turno, dni_cliente, nombre_cliente, apellido_cliente FROM turno t, veterinario v, tipoTurno tt, cliente c WHERE t.FK_turno_veterinario = v.matricula_veterinario AND t.FK_turno_cliente = c.dni_cliente AND t.FK_turno_tipoTurno = tt.id_tipo_turno AND fecha_turno = '" + cod + "' ORDER BY hora_turno ASC", conexion);
                adaptador.SelectCommand = consulta;

                DataSet data = new DataSet();
                adaptador.Fill(data, "turnos");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "turnos";

                conexion.Close();
            }
        }
    }
}
