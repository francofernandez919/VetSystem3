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
    public partial class Form_Clientes_Registrar : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Clientes_Registrar()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            SqlCommand registrarCliente = new SqlCommand("INSERT INTO cliente(dni_cliente, nombre_cliente, apellido_cliente, telefono_cliente, mail_cliente, direccion_cliente) values (@dni, @nombre, @apellido, @telefono, @mail, @direccion)", conexion);
            adaptador.InsertCommand = registrarCliente;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dni", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@telefono", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["@dni"].Value = textBoxDNI.Text;
            adaptador.InsertCommand.Parameters["@nombre"].Value = textBoxNombreCliente.Text;
            adaptador.InsertCommand.Parameters["@apellido"].Value = textBoxApellidoCliente.Text;
            adaptador.InsertCommand.Parameters["@telefono"].Value = textBoxTelefonoCliente.Text;
            adaptador.InsertCommand.Parameters["@mail"].Value = textBoxMailCliente.Text;
            adaptador.InsertCommand.Parameters["@direccion"].Value = textBoxDireccionCliente.Text;

            if(textBoxDNI.Text.Equals("") || textBoxNombreCliente.Text.Equals("") || textBoxApellidoCliente.Text.Equals("") || textBoxTelefonoCliente.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                string dni = textBoxDNI.Text;

                conexion.Open();
                SqlCommand consulta = new SqlCommand("SELECT * FROM cliente WHERE dni_cliente = '" + dni + "'", conexion);
                SqlDataReader registro = consulta.ExecuteReader();
                if (registro.Read())
                {
                    MessageBox.Show("El DNI ingresado ya existe.");
                    textBoxDNI.Text = "";
                    conexion.Close();
                }
                else
                {
                    try
                    {
                        conexion.Close();

                        conexion.Open();

                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("El cliente ha sido registrado con exito.");
                    }
                    catch (SqlException excepcion)
                    {
                        MessageBox.Show("Error al cargar los datos."); //excepcion.ToString()
                    }
                    finally
                    {
                        conexion.Close();
                        textBoxDNI.Text = "";
                        textBoxNombreCliente.Text = "";
                        textBoxApellidoCliente.Text = "";
                        textBoxTelefonoCliente.Text = "";
                        textBoxMailCliente.Text = "";
                        textBoxDireccionCliente.Text = "";
                    }
                }
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /* 
                * only allow one decimal point
                * 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            */
        }

        private void textBoxNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxMailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '@') && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}