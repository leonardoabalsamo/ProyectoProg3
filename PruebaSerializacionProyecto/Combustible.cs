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
        private string nombre;
        private decimal stock;
        private decimal precio;

        public Combustible(string n ,decimal s,decimal p)
        {
            nombre = n;
            stock = s;
            precio = p;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal Stock { get { return stock; } set { stock = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }


    }
}
