using Corte1.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        public Registro() { }

        //Arreglo para guardar 30 personas
        Persona[] personas = new Persona[30];

        //Función para agregar una persona nueva al arreglo en el espació vacío
        public void agregarPersona(Persona persona)
        {
            for (int i = 0; i < personas.Length; i++)
            {
                if (personas[i] == null)
                {
                    personas[i] = persona;
                    break;
                }
            }
        }
    }
}
