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
    public partial class Form_Especialidad_Eliminar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Especialidad_Eliminar()
        {
            InitializeComponent();
        }

        private void Form_Especialidad_Eliminar_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int id = int.Parse(labelidEspecialidadEliminar.Text);

            string cadena = "DELETE FROM especialidadVeterinario WHERE id_especialidad = " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                conexion.Close();

                MessageBox.Show("La especialidad ha sido eliminada.");

                labelidEspecialidadEliminar.Text = "";

                this.Dispose();
            }
            else
            {
                conexion.Close();
                MessageBox.Show("No se ha podido realizar la operación.");
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
