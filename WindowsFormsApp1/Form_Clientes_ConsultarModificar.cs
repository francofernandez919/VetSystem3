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
    public partial class Form_Clientes_ConsultarModificar : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Clientes_ConsultarModificar()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableCliente.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dbVSDataSetTableCliente.cliente);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "DNI";
            item1.Value = "dni_cliente";
            comboBoxBuscar.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Nombre";
            item2.Value = "nombre_cliente";
            comboBoxBuscar.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Apellido";
            item3.Value = "apellido_cliente";
            comboBoxBuscar.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxDNI.Text.Equals("") || textBoxNombreCliente.Text.Equals("") || textBoxApellidoCliente.Text.Equals("") || textBoxTelefonoCliente.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                string dni = textBoxDNI.Text;
                string nombre = textBoxNombreCliente.Text;
                string apellido = textBoxApellidoCliente.Text;
                string telefono = textBoxTelefonoCliente.Text;
                string mail = textBoxMailCliente.Text;
                string direccion = textBoxDireccionCliente.Text;

                string query = "UPDATE cliente SET nombre_cliente = '" + nombre + "', apellido_cliente = '" + apellido + "', telefono_cliente = '" + telefono + "', mail_cliente = '" + mail + "', direccion_cliente = '" + direccion + "' WHERE dni_cliente = '" + dni + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Los datos del cliente han sido modificados.");
                }
                else
                {
                    MessageBox.Show("No existe ningun cliente con ese DNI.");
                }

                conexion.Close();

                comboBoxBuscar.SelectedIndex = -1;
                textBoxBuscar.Text = "";

                textBoxDNI.Text = "";
                textBoxNombreCliente.Text = "";
                textBoxApellidoCliente.Text = "";
                textBoxTelefonoCliente.Text = "";
                textBoxMailCliente.Text = "";
                textBoxDireccionCliente.Text = "";

                refresh();
            }
        }
        
        private void refresh()
        {
            conexion.Open();

            string query = "SELECT * FROM cliente";
            SqlCommand buscar = new SqlCommand(query, conexion);
            adaptador.SelectCommand = buscar;

            DataSet data = new DataSet();
            adaptador.Fill(data, "cliente");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "cliente";

            conexion.Close();
        }        

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un parámetro de busqueda.");
            }
            else
            {
                conexion.Open();

                string busqueda = (comboBoxBuscar.SelectedItem as ComboboxItem).Value.ToString();

                string query = "SELECT * FROM cliente WHERE " + busqueda + " like '%" + textBoxBuscar.Text + "%'";
                SqlCommand buscar = new SqlCommand(query, conexion);
                adaptador.SelectCommand = buscar;

                DataSet data = new DataSet();
                adaptador.Fill(data, "cliente");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "cliente";

                conexion.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxDNI.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxNombreCliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxApellidoCliente.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxTelefonoCliente.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxMailCliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxDireccionCliente.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBoxBuscar.Text = "";

            textBoxDNI.Text = "";
            textBoxNombreCliente.Text = "";
            textBoxApellidoCliente.Text = "";
            textBoxTelefonoCliente.Text = "";
            textBoxMailCliente.Text = "";
            textBoxDireccionCliente.Text = "";

            refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
