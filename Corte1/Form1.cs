using Corte1.models;
using Corte1.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class RegistroDeEdadesGG : Form
    {
        public RegistroDeEdadesGG()
        {
            InitializeComponent();
        }

        Registro registro = new Registro();
        string esMayor = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            crearPersona();
            lblFirstName.Focus();
            lblLastName.Focus();
            btnLegalAge.Enabled = true;
        }

        //Función para agregar la persona
        public void crearPersona()
        {
            Operacion operacion = new Operacion();
            Persona persona = new Persona();
            persona.name = tbFirstName.Text;
            persona.apellido = tbLastName.Text;
            persona.ciudad = cbCity.Text;
            persona.fechaNacimiento = dtpBirtthDate.Value;

            registro.agregarPersona(persona);
            esMayor = operacion.calcularMayorMenor(persona.fechaNacimiento);
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text != null && tbLastName.Text != null)
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnViewRegistry_Click(object sender, EventArgs e)
        {
            mostrarElRegistro();
        }

        private void btnLegalAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esMayor);
        }

        public void mostrarElRegistro()
        {
            for (int i = 0; i <= 30; i++)
            {
                Persona personaLocal = registro.retornarPersona(i);
                lbRegistro.Items.Add($"Nombre: {personaLocal.name}, {personaLocal.apellido}; Ciudad: {personaLocal.ciudad}");
            }
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
