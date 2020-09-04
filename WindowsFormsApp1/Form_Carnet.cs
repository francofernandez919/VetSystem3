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

namespace WindowsFormsApp1
{
    public partial class Form_Carnet : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        DataSet datosVacunacion = new DataSet();
        DataSet datosDesparasitacion = new DataSet();

        public Form_Carnet()
        {
            InitializeComponent();
        }

        private void Form_Carnet_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            conexion.Open();

            int cod = int.Parse(labelID.Text);
            
            SqlCommand consulta1 = new SqlCommand("SELECT fecha_vacunacion, nombre_tipo_vacuna FROM view_vacunaciones WHERE id_mascota = " + cod + " ORDER BY fecha_vacunacion ASC", conexion);
            adaptador.SelectCommand = consulta1;

            listBox1.Items.Clear();
            adaptador.Fill(datosVacunacion, "view_vacunaciones");
            for (int fila = 0; fila < datosVacunacion.Tables["view_vacunaciones"].Rows.Count; fila++)
            {
                string fecha = datosVacunacion.Tables["view_vacunaciones"].Rows[fila]["fecha_vacunacion"].ToString();

                DateTime fecha2 = DateTime.Parse(fecha);

                listBox1.Items.Add("Fecha: " + fecha2.ToShortDateString());
                listBox1.Items.Add("Tipo de Vacuna: " + datosVacunacion.Tables["view_vacunaciones"].Rows[fila]["nombre_tipo_vacuna"]);
                listBox1.Items.Add("........................................................................................");
            }
            datosVacunacion.Clear();

            SqlCommand consulta2 = new SqlCommand("SELECT fecha_desparasitacion, observacion_desparasitacion FROM desparasitacion d, mascota m  WHERE d.FK_desparasitacion_mascota = m.id_mascota AND id_mascota = " + cod + " ORDER BY fecha_desparasitacion ASC", conexion);
            adaptador.SelectCommand = consulta2;

            listBox2.Items.Clear();
            adaptador.Fill(datosDesparasitacion, "desparasitacion");

            for (int fila = 0; fila < datosDesparasitacion.Tables["desparasitacion"].Rows.Count; fila++)
            {
                string fecha = datosDesparasitacion.Tables["desparasitacion"].Rows[fila]["fecha_desparasitacion"].ToString();

                DateTime fecha2 = DateTime.Parse(fecha);

                listBox2.Items.Add("Fecha: " + fecha2.ToShortDateString());
                listBox2.Items.Add("Observación Parasitológica: " + datosDesparasitacion.Tables["desparasitacion"].Rows[fila]["observacion_desparasitacion"]);
                listBox2.Items.Add("........................................................................................");
            }
            datosDesparasitacion.Clear();

            conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            /*
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            */
        }
    }
}
