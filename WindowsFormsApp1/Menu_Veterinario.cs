using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_Veterinario : Form
    {
        public Menu_Veterinario()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void registrarVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarVacunacion = new Form_Vacunacion_Registrar();
            registrarVacunacion.Show();
        }

        private void registrarDesparasitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarDesparasitacion = new Form_Desparasitacion_Registrar();
            registrarDesparasitacion.Show();
        }

        private void carnetDeVacunaciónYDesparasitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarCarnet = new Form_Carnet_Consultar();
            consultarCarnet.Show();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarHistoria = new Form_Historia_Clinica2();
            consultarHistoria.Show();
        }
    }
}
