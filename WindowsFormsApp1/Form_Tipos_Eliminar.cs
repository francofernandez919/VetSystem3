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
    public partial class Form_Tipos_Eliminar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Tipos_Eliminar()
        {
            InitializeComponent();
        }

        private void Form_Tipos_Eliminar_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int id = int.Parse(labelidTipoEliminar.Text);

            string cadena = "DELETE FROM tipoMascota WHERE id_tipo_mascota = " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                conexion.Close();

                MessageBox.Show("El tipo de animal ha sido eliminado.");

                labelidTipoEliminar.Text = "";

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
