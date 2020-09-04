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
    public partial class Form_Historia_Clinica2 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Historia_Clinica2()
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

        private void Form_Historia_Clinica2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVetSystemDataSet1.view_mascotas' table. You can move, or remove it, as needed.
            this.view_mascotasTableAdapter.Fill(this.dbVetSystemDataSet1.view_mascotas);

            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "DNI Dueño";
            item1.Value = "FK_mascota_cliente";
            comboBoxBuscar.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Nombre Dueño";
            item2.Value = "nombre_cliente";
            comboBoxBuscar.Items.Add(item2);

            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Apellido Dueño";
            item3.Value = "apellido_cliente";
            comboBoxBuscar.Items.Add(item3);

            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Nombre Mascota";
            item4.Value = "nombre_mascota";
            comboBoxBuscar.Items.Add(item4);

            comboBoxBuscar.SelectedIndex = -1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar parametro de busqueda.");
            }
            else
            {
                conexion.Open();

                string busqueda = (comboBoxBuscar.SelectedItem as ComboboxItem).Value.ToString();

                string query = "SELECT * FROM view_mascotas WHERE " + busqueda + " like '%" + textBoxBuscar.Text + "%'";
                SqlCommand buscar = new SqlCommand(query, conexion);
                adaptador.SelectCommand = buscar;

                DataSet data = new DataSet();
                adaptador.Fill(data, "view_mascotas");

                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "view_mascotas";

                conexion.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelidMascota.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDNI.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxNombreCliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxApellidoCliente.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxNombreMascota.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxTipoMascota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxRazaMascota.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            labelPeso.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            labelSexo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            labelFechaNac.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            labelFoto.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelidMascota.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna mascota.");
            }
            else
            {
                Form_Historia_Clinica4 abrirDetalleHistoria = new Form_Historia_Clinica4();
                abrirDetalleHistoria.labelHCidMascota.Text = labelidMascota.Text;
                abrirDetalleHistoria.textBoxHCNombre.Text = textBoxNombreMascota.Text;
                abrirDetalleHistoria.textBoxHCTipo.Text = textBoxTipoMascota.Text;
                abrirDetalleHistoria.textBoxHCRaza.Text = textBoxRazaMascota.Text;
                abrirDetalleHistoria.textBoxHCPeso.Text = labelPeso.Text;
                abrirDetalleHistoria.labelHCSexo.Text = labelSexo.Text;
                abrirDetalleHistoria.dateTimeHCFechaNac.Text = labelFechaNac.Text;
                abrirDetalleHistoria.textBoxHCFoto.Text = labelFoto.Text;
                textBoxDNI.Text = "";
                textBoxNombreCliente.Text = "";
                textBoxApellidoCliente.Text = "";
                labelidMascota.Text = "";
                textBoxNombreMascota.Text = "";
                textBoxTipoMascota.Text = "";
                textBoxRazaMascota.Text = "";
                labelPeso.Text = "";
                labelSexo.Text = "";
                labelFechaNac.Text = "";
                labelFoto.Text = "";
                abrirDetalleHistoria.Show();
            }
        }

        private void Form_Historia_Clinica2_Activated(object sender, EventArgs e)
        {
            {
                this.view_mascotasTableAdapter.Fill(this.dbVetSystemDataSet1.view_mascotas);
            }
        }
    }
}
