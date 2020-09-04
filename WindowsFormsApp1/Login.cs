using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginVet();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Consulte al Administrador de Sistemas.");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("VetSystem \n\nVersion Actual: \t 0.01 \n\nCreado por: \n\t\tVictoria Carrizo\n\t\tFranco Fernandez\n\t\tCarolina Trucco");
        }
        public void LoginVet()
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
           
            try 
            {
                conexion.Open();
                
                string usuario = textUsuario.Text;
                string password = textPassword.Text;

                using (SqlCommand cmd = new SqlCommand("SELECT nombre_usuario, password_usuario, rol_usuario FROM usuario WHERE nombre_usuario='" + usuario + "' AND password_usuario='" + password + "'", conexion))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        string rol = dataReader["rol_usuario"].ToString();

                        if (String.Equals(rol, "Administrador"))
                        {
                            dataReader.Close();
                            string now = DateTime.Now.ToString("s");

                            string last = "UPDATE usuario SET lastlogin_usuario = '" + now + "' WHERE id_usuario = 1";
                            SqlCommand comando = new SqlCommand(last, conexion);
                            comando.ExecuteNonQuery();

                            Form menuAdmin = new Menu_Administrador();
                            menuAdmin.Show();

                        }
                        if (String.Equals(rol, "Secretario"))
                        {
                            dataReader.Close();

                            string now = DateTime.Now.ToString("s");

                            string last = "UPDATE usuario SET lastlogin_usuario = '" + now + "' WHERE id_usuario = 2";
                            SqlCommand comando = new SqlCommand(last, conexion);
                            comando.ExecuteNonQuery();

                            Form menuSecre = new Menu_Secretaria();
                            menuSecre.Show();
                        }
                        if (String.Equals(rol, "Veterinario"))
                        {
                            dataReader.Close();
                            string now = DateTime.Now.ToString("s");

                            string last = "UPDATE usuario SET lastlogin_usuario = '" + now + "' WHERE id_usuario = 1004";
                            SqlCommand comando = new SqlCommand(last, conexion);
                            comando.ExecuteNonQuery();

                            Form menuVete = new Menu_Veterinario();
                            menuVete.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
