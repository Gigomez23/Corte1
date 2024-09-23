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

        Persona[] personas = new Persona[30];

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
