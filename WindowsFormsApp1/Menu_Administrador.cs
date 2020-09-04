using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Menu_Administrador : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;

        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbVetSystem;Integrated Security=True;");
            adaptador = new SqlDataAdapter();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void registrarVeterinarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form registrarVeterinarios = new Form_Veterinarios_Registrar();
            registrarVeterinarios.Show();
        }

        private void modificarVeterinarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form modificarVeterinarios = new Form_Veterinarios_ConsultarModificar();
            modificarVeterinarios.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void actualizarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarRubros = new Form_Rubros_Actualizar();
            registrarRubros.Show();
        }

        private void actualizarRazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarRazas = new Form_Razas_Actualizar();
            registrarRazas.Show();
        }

        private void actualizarTipoDeVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarVacunas = new Form_Vacunas_Actualizar();
            registrarVacunas.Show();
        }

        private void actualizarTipoDeMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarTipos = new Form_Tipos_Actualizar();
            registrarTipos.Show();
        }

        private void actualizarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarEspecialidad = new Form_Especialidad_Actualizar();
            registrarEspecialidad.Show();
        }

        private void actualizarTipoDePrácticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarPracticas = new Form_Practicas_Actualizar();
            registrarPracticas.Show();
        }

        private void actualizarTipoDePresentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarPresentacion = new Form_Presentacion_Actualizar();
            registrarPresentacion.Show();
        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form actualizarUsuario = new Form_Usuarios_Actualizar();
            actualizarUsuario.Show();
        }
    }
}
