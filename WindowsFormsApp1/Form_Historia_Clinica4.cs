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
    public partial class Form_Historia_Clinica4 : Form
    {
        private SqlDataAdapter adaptador;
        private SqlConnection conexion;

        public Form_Historia_Clinica4()
        {
            InitializeComponent();
        }

        private void Form_Historia_Clinica4_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();

            if (textBoxHCFoto.Text.Equals(""))
            {

            }
            else
            {
                pictureBox1.ImageLocation = textBoxHCFoto.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (labelHCSexo.Text.Equals("Hembra"))
            {
                radioButtonH.Checked = true;
            }
            else
            {
                if (labelHCSexo.Text.Equals("Macho"))
                {
                    radioButtonM.Checked = true;
                }
            }
        }

        private void buttonVerCarnet_Click(object sender, EventArgs e)
        {
            if (labelHCidMascota.Text.Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ninguna mascota.");
            }
            else
            {
                Form_Carnet carnet = new Form_Carnet();
                carnet.labelID.Text = labelHCidMascota.Text;
                carnet.labelNombre.Text = textBoxHCNombre.Text;
                carnet.labelTipo.Text = textBoxHCTipo.Text;
                carnet.labelRaza.Text = textBoxHCRaza.Text;
                carnet.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
