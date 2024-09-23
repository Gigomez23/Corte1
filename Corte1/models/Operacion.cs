using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Operacion
    {
        public Operacion() { }

        //Función para determinar en base a la fecha de nacimiento si es mayor o menor de edad.
        public string calcularMayorMenor(DateTime fechaNacimiento)
        {
            DateTime anio = DateTime.Now;
            if (fechaNacimiento.Year -  anio.Year >= 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de Edad";
            }
        }
    }

}
