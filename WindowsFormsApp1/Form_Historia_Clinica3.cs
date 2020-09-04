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
    public partial class Form_Historia_Clinica3 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Historia_Clinica3()
        {
            InitializeComponent();
        }

        private void Form_Historia_Clinica3_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            if(textBoxHCFoto.Text.Equals(""))
            {

            }
            else
            {
                pictureBox1.ImageLocation = textBoxHCFoto.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if(labelHCSexo.Text.Equals("Hembra"))
            {
                radioButtonH.Checked = true;
            }
            else
            {
                if(labelHCSexo.Text.Equals("Macho"))
                {
                    radioButtonM.Checked = true;
                }
            }
        }

        private void buttonImgAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = textBoxHCFoto.Text;

            if(BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                textBoxHCFoto.Text = BuscarImagen.FileName;
                string direccion = BuscarImagen.FileName;
                pictureBox1.ImageLocation = direccion;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonImgDelete_Click(object sender, EventArgs e)
        {
            textBoxHCFoto.Text = "";
            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxHCPeso.Text.Equals("") || labelHCSexo.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
            else
            {
                conexion.Open();

                int id = int.Parse(labelHCidMascota.Text);
                string peso = textBoxHCPeso.Text;
                string sexo = labelHCSexo.Text;
                string fecha = dateTimeHCFechaNac.Value.ToShortDateString();
                string foto = textBoxHCFoto.Text;

                string query = "UPDATE mascota SET peso_mascota = '" + peso + "', sexo_mascota = '" + sexo + "', fechanac_mascota = '" + fecha + "', foto_mascota = '" + foto + "' WHERE id_mascota = " + id;
                SqlCommand comando = new SqlCommand(query, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("La historia clinica ha sido guardada.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }

                conexion.Close();
                this.Dispose();
            }
        }

        private void radioButtonH_CheckedChanged(object sender, EventArgs e)
        {
            labelHCSexo.Text = "Hembra";
        }

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            labelHCSexo.Text = "Macho";
        }

        private void textBoxHCPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void dateTimeHCFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(dateTimeHCFechaNac.Value.ToString()) > DateTime.Today)
            {
                MessageBox.Show("La fecha ingresada no es valida.");
                dateTimeHCFechaNac.Value = DateTime.Today;
            }
        }
    }
}
