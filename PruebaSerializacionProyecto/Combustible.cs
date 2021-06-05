using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSerializacionProyecto
{
    [Serializable]
    public class Combustible
    {
        public string nombre;
        public decimal stock;
        public decimal precio;
        public string prueba;

        public Combustible(string n ,decimal s,decimal p, string pr)
        {
            nombre = n;
            stock = s;
            precio = p;
            prueba = pr;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal Stock { get { return stock; } set { stock = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }


    }
}
