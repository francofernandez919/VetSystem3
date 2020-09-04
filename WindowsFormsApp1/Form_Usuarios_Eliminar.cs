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
    public partial class Form_Usuarios_Eliminar : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Usuarios_Eliminar()
        {
            InitializeComponent();
        }
        
        private void Form_Usuarios_Eliminar_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int id = int.Parse(labelidEliminarUsuario.Text);

            string cadena = "DELETE FROM usuario WHERE id_usuario = " + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                conexion.Close();

                MessageBox.Show("El usuario ha sido eliminado.");

                labelidEliminarUsuario.Text = "";

                this.Dispose();
            }
            else
            {
                conexion.Close();
                MessageBox.Show("No se ha podido realizar la operacion.");
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
