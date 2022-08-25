using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Persona
    {
        private string Nombre;
        private int DNI;
        private DateTime Fecha_De_Nacimiento;

        public Persona()
        {

        }

        public Persona(string nombre, int Dni, DateTime fecha)
        {
            Nombre = nombre;
            DNI = Dni;
            Fecha_De_Nacimiento = fecha;


        }

        public string P_nombre
        {
            set { Nombre = value; }
            get { return Nombre; }

        }
        public int P_Dni
        {
            set { DNI = value; }
            get { return DNI; }

        }

        public DateTime p_fecha_De_nacimiento
        {
            set { Fecha_De_Nacimiento = value; }
            get { return Fecha_De_Nacimiento; }

        }

        public int Edad(int Año_nacimiento)
        {
            DateTime dateTime = DateTime.Today;
            int Edad = dateTime.Year - Año_nacimiento;

            return Edad;
        }



        
        
        
            
            





    }
}
