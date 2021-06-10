using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSerializacionProyecto
{
    [Serializable]
    public class Empleado
    {
        private string nombre;
        public Empleado(string nom)
        {
            nombre = nom;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
    }
}
