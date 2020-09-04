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
    public partial class Menu_Secretaria : Form
    {
        public Menu_Secretaria()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void registrarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarTurnos = new Form_Turnos_Registrar1();
            registrarTurnos.Show();
        }

        private void consultarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarTurnos = new Form_Turnos_ConsultarModificar();
            consultarTurnos.Show();
        }

        private void emitirListadoDeTurnosPorDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form emitirTurnos = new Form_Turnos_Listado();
            emitirTurnos.Show();
        }

        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarClientes = new Form_Clientes_Registrar();
            registrarClientes.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarModificarClientes = new Form_Clientes_ConsultarModificar();
            consultarModificarClientes.Show();
        }

        private void registrarMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarMascotas1 = new Form_Mascotas_Registrar1();
            registrarMascotas1.Show();
        }

        private void consultarMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarmodificarMascotas = new Form_Mascotas_ConsultarModificar();
            consultarmodificarMascotas.Show();
        }

        private void consultarHabitaculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarHabitaculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void calcularCostoInternacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarQuirófanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarQuirófanoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarGastosIntervenciónQuirúrgicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void carnetDeVacunaciónYDesparasitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarCarnet = new Form_Carnet_Consultar();
            consultarCarnet.Show();
        }

        private void consultarVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarVeterinario = new Form_Veterinarios_Consultar();
            consultarVeterinario.Show();
        }

        private void historiaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarHistoriaClinica = new Form_Historia_Clinica1();
            consultarHistoriaClinica.Show();
        }
    }
}

