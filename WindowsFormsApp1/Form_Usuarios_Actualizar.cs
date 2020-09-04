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
    public partial class Form_Usuarios_Actualizar : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Form_Usuarios_Actualizar()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Actualizar_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            // TODO: This line of code loads data into the 'dbVetSystemDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dbVetSystemDataSet.usuario);

            comboBoxModificarUsuario.SelectedIndex = -1;
            textBoxModificarNombre.Text = "";
            textBoxOldPass.Text = "";
            textBoxNewPassword1.Text = "";
            textBoxNewPassword2.Text = "";
            comboBoxModificarRol.SelectedIndex = -1;

            SqlCommand registrarUsuario = new SqlCommand("INSERT INTO usuario(nombre_usuario, password_usuario, rol_usuario) values (@nombreUsuario, @passwordUsuario, @rolUsuario)", conexion);
            adaptador.InsertCommand = registrarUsuario;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@passwordUsuario", SqlDbType.NVarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@rolUsuario", SqlDbType.NVarChar));
        }

        public int verUsuario()
        {
            string nombre = textBoxRegistrarNombre.Text;

            int count = 0;
            string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = '" + nombre + "'";

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

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxRegistrarNombre.Text.Equals("") || textBoxPassword1.Text.Equals("") || textBoxPassword2.Text.Equals("") || comboBoxRegistrarRol.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                if (textBoxPassword1.Text.Equals(textBoxPassword2.Text))
                {
                    if (verUsuario() == 1)
                    {
                        MessageBox.Show("El usuario ingresado ya existe.");
                        textBoxRegistrarNombre.Text = "";
                    }
                    else
                    {
                        adaptador.InsertCommand.Parameters["@nombreUsuario"].Value = textBoxRegistrarNombre.Text;
                        adaptador.InsertCommand.Parameters["@passwordUsuario"].Value = textBoxPassword1.Text;
                        adaptador.InsertCommand.Parameters["@rolUsuario"].Value = comboBoxRegistrarRol.Text;

                        try
                        {
                            conexion.Open();
                            adaptador.InsertCommand.ExecuteNonQuery();
                            MessageBox.Show("El usuario ha sido registrado.");
                        }
                        catch (SqlException excepcion)
                        {
                            MessageBox.Show(excepcion.ToString());
                        }
                        finally
                        {
                            conexion.Close();

                            textBoxRegistrarNombre.Text = "";
                            textBoxPassword1.Text = "";
                            textBoxPassword2.Text = "";
                            comboBoxRegistrarRol.SelectedIndex = -1;

                            this.usuarioTableAdapter.Fill(this.dbVetSystemDataSet.usuario);
                            comboBoxModificarUsuario.SelectedIndex = -1;

                            textBoxModificarNombre.Focus();

                            textBoxModificarNombre.Text = "";
                            textBoxOldPass.Text = "";
                            textBoxNewPassword1.Text = "";
                            textBoxNewPassword2.Text = "";
                            comboBoxModificarRol.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden.");
                    textBoxPassword1.Text = "";
                    textBoxPassword2.Text = "";
                }
            }
        }

        private void comboBoxUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxModificarUsuario.SelectedIndex.Equals(-1))
            {

            }
            else
            {
                conexion.Open();

                int idUsuario = int.Parse(comboBoxModificarUsuario.SelectedValue.ToString());

                string query = "SELECT password_usuario FROM usuario WHERE id_usuario = " + idUsuario;
                SqlCommand comando = new SqlCommand(query, conexion);

                textBoxOldPass.Text = Convert.ToString(comando.ExecuteScalar());

                string query2 = "SELECT rol_usuario FROM usuario WHERE id_usuario = " + idUsuario;
                SqlCommand comando2 = new SqlCommand(query2, conexion);

                comboBoxModificarRol.Text = Convert.ToString(comando2.ExecuteScalar());

                textBoxModificarNombre.Text = comboBoxModificarUsuario.Text;
                textBoxModificarNombre.Focus();
                textBoxOldPass.UseSystemPasswordChar = true;
                textBoxNewPassword1.Text = "";
                textBoxNewPassword1.UseSystemPasswordChar = true;
                textBoxNewPassword2.Text = "";
                textBoxNewPassword2.UseSystemPasswordChar = true;

                conexion.Close();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarUsuario.Text.Equals("") || textBoxModificarNombre.Text.Equals("") || comboBoxModificarRol.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                if (verUsuario() == 1)
                {
                    MessageBox.Show("El usuario ingresado ya existe.");
                    textBoxModificarNombre.Text = "";
                }
                else
                {
                    if (textBoxNewPassword1.Text.Equals("") && textBoxNewPassword2.Text.Equals(""))
                    {
                        conexion.Open();

                        int id = int.Parse(comboBoxModificarUsuario.SelectedValue.ToString());
                        string nombre = textBoxModificarNombre.Text;
                        string pass = textBoxOldPass.Text;
                        string rol = comboBoxModificarRol.Text;

                        string query = "UPDATE usuario SET nombre_usuario = '" + nombre + "', password_usuario = '" + pass + "', rol_usuario = '" + rol + "' WHERE id_usuario = " + id;
                        SqlCommand comando = new SqlCommand(query, conexion);
                        int cant;
                        cant = comando.ExecuteNonQuery();

                        if (cant == 1)
                        {
                            MessageBox.Show("El usuario ha sido modificado.");
                        }
                        else
                        {
                            MessageBox.Show("Error.");
                        }

                        conexion.Close();

                        this.usuarioTableAdapter.Fill(this.dbVetSystemDataSet.usuario);
                        comboBoxModificarUsuario.SelectedIndex = -1;

                        textBoxModificarNombre.Text = "";
                        textBoxOldPass.Text = "";
                        textBoxNewPassword1.Text = "";
                        textBoxNewPassword2.Text = "";
                        comboBoxModificarRol.SelectedIndex = -1;

                        textBoxRegistrarNombre.Focus();
                    }
                    else
                    {
                        if (textBoxNewPassword1.Text.Equals(textBoxNewPassword2.Text))
                        {
                            conexion.Open();

                            int id = int.Parse(comboBoxModificarUsuario.SelectedValue.ToString());
                            string nombre = textBoxModificarNombre.Text;
                            string pass = textBoxNewPassword1.Text;
                            string rol = comboBoxModificarRol.Text;

                            string query = "UPDATE usuario SET nombre_usuario = '" + nombre + "', password_usuario = '" + pass + "', rol_usuario = '" + rol + "' WHERE id_usuario = " + id;
                            SqlCommand comando = new SqlCommand(query, conexion);
                            int cant;
                            cant = comando.ExecuteNonQuery();

                            if (cant == 1)
                            {
                                MessageBox.Show("El usuario ha sido modificado.");
                            }
                            else
                            {
                                MessageBox.Show("Error.");
                            }

                            conexion.Close();

                            this.usuarioTableAdapter.Fill(this.dbVetSystemDataSet.usuario);
                            comboBoxModificarUsuario.SelectedIndex = -1;

                            textBoxModificarNombre.Text = "";
                            textBoxOldPass.Text = "";
                            textBoxNewPassword1.Text = "";
                            textBoxNewPassword2.Text = "";
                            comboBoxModificarRol.SelectedIndex = -1;

                            textBoxRegistrarNombre.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas ingresadas no coinciden.");
                            textBoxNewPassword1.Text = "";
                            textBoxNewPassword2.Text = "";
                        }
                    }
                }
            }
        }

        private void buttonShowPass1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword1.UseSystemPasswordChar == true)
            {
                textBoxPassword1.UseSystemPasswordChar = false;
                buttonShowPass1.Image = global::WindowsFormsApp1.Properties.Resources.hide_small;
            }
            else
            {
                textBoxPassword1.UseSystemPasswordChar = true;
                buttonShowPass1.Image = global::WindowsFormsApp1.Properties.Resources.show_small;
            }
        }

        private void buttonShowPass2_Click(object sender, EventArgs e)
        {
            if (textBoxPassword2.UseSystemPasswordChar == true)
            {
                textBoxPassword2.UseSystemPasswordChar = false;
                buttonShowPass2.Image = global::WindowsFormsApp1.Properties.Resources.hide_small;
            }
            else
            {
                textBoxPassword2.UseSystemPasswordChar = true;
                buttonShowPass2.Image = global::WindowsFormsApp1.Properties.Resources.show_small;
            }
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            if (textBoxOldPass.UseSystemPasswordChar == true)
            {
                textBoxOldPass.UseSystemPasswordChar = false;
                buttonShow1.Image = global::WindowsFormsApp1.Properties.Resources.hide_small;
            }
            else
            {
                textBoxOldPass.UseSystemPasswordChar = true;
                buttonShow1.Image = global::WindowsFormsApp1.Properties.Resources.show_small;
            }
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword1.UseSystemPasswordChar == true)
            {
                textBoxNewPassword1.UseSystemPasswordChar = false;
                buttonShow2.Image = global::WindowsFormsApp1.Properties.Resources.hide_small;
            }
            else
            {
                textBoxNewPassword1.UseSystemPasswordChar = true;
                buttonShow2.Image = global::WindowsFormsApp1.Properties.Resources.show_small;
            }
        }

        private void buttonShow3_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword2.UseSystemPasswordChar == true)
            {
                textBoxNewPassword2.UseSystemPasswordChar = false;
                buttonShow3.Image = global::WindowsFormsApp1.Properties.Resources.hide_small;
            }
            else
            {
                textBoxNewPassword2.UseSystemPasswordChar = true;
                buttonShow3.Image = global::WindowsFormsApp1.Properties.Resources.show_small;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxRegistrarNombre.Text = "";
            textBoxPassword1.Text = "";
            textBoxPassword2.Text = "";
            comboBoxRegistrarRol.SelectedIndex = -1;

            this.usuarioTableAdapter.Fill(this.dbVetSystemDataSet.usuario);
            comboBoxModificarUsuario.SelectedIndex = -1;
            textBoxModificarNombre.Text = "";
            textBoxOldPass.Text = "";
            textBoxNewPassword1.Text = "";
            textBoxNewPassword2.Text = "";
            comboBoxModificarRol.SelectedIndex = -1;

            textBoxRegistrarNombre.Focus();
        }

        private void textBoxRegistrarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxModificarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarUsuario.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun usuario.");
            }
            else
            {
                Form_Usuarios_Eliminar eliminarUsuario = new Form_Usuarios_Eliminar();
                eliminarUsuario.labelidEliminarUsuario.Text = comboBoxModificarUsuario.SelectedValue.ToString();
                eliminarUsuario.Show();
            }
        }
    }
}
