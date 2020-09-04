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
    public partial class Form_Practicas_Eliminar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;


        public Form_Practicas_Eliminar()
        {
            InitializeComponent();
        }

        private void Form_Practicas_Eliminar_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int id = int.Parse(labelidPracticaEliminar.Text);

            string cadena = "DELETE FROM practicasVeterinarias WHERE id_practica = " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                conexion.Close();

                MessageBox.Show("La practica veterinaria ha sido eliminada.");

                labelidPracticaEliminar.Text = "";

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
