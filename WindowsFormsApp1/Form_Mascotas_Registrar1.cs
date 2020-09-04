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
    public partial class Form_Mascotas_Registrar1 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        public Form_Mascotas_Registrar1()
        {
            InitializeComponent();
        }

        private void Form_Mascotas_Registrar1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVSDataSetTableCliente.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dbVSDataSetTableCliente.cliente);
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "DNI Cliente";
            item1.Value = "dni_cliente";
            comboBoxBuscar.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Nombre Cliente";
            item2.Value = "nombre_cliente";
            comboBoxBuscar.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Apellido Cliente";
            item3.Value = "apellido_cliente";
            comboBoxBuscar.Items.Add(item3);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBoxBuscar.Text = "";

            textBoxDNI.Text = "";
            textBoxNombreCliente.Text = "";
            textBoxApellidoCliente.Text = "";

            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun cliente.");
            }
            else
            {
                Form_Mascotas_Registrar2 registrarMascotas2 = new Form_Mascotas_Registrar2();
                registrarMascotas2.textBoxDNI.Text = textBoxDNI.Text;
                registrarMascotas2.textBoxNombreCliente.Text = textBoxNombreCliente.Text;
                registrarMascotas2.textBoxApellidoCliente.Text = textBoxApellidoCliente.Text;
                registrarMascotas2.Show();
            }
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
        }

        private void linkLabelRegistrarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Clientes_Registrar registrarClientes = new Form_Clientes_Registrar();
            registrarClientes.Show();
        }
    }
}
