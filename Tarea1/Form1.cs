using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tarea1
{
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Boton_cargar_persona_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text;
            int Dni = int.Parse(Txt_dni.Text);
            DateTime Fecha = DateTime.Parse(Txt_FechaNac.Text);

                persona = new Persona(nombre, Dni, Fecha);
        }

        

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void Txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Boton_Mostrar_Edad_Click(object sender, EventArgs e)
        {
            persona = new Persona();

            DateTime fecha = DateTime.Parse(Txt_FechaNac.Text);


            int añoN = fecha.Year;

            Mostrar_edad.Text = "Edad: " + persona.Edad(añoN).ToString();
        }

        private void Txt_FechaNac_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}