using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSerializacionProyecto
{
    [Serializable]
    public class Sistema
    {
        public List<string> Empleados;
        public Dictionary<string,Combustible> Combustibles;
        public List<Venta> Ventas;

        public Sistema()
        {
            Empleados = new List<string>() { "Matias", "Jose", "Marcos", "Carla" };

            Ventas = new List<Venta>();


            Combustibles = new Dictionary<string, Combustible>()
            {
                {"super", new Combustible("Super",0,0) },
                {"diesel", new Combustible("Diesel",0,0) },
                {"premium", new Combustible("Premium",0,0) },
                {"ultra", new Combustible("Ultra Diesel",0,0) }
            };
        }

        public List<string> empleados
        {
            get { return Empleados; }
        }

        public Dictionary<string,Combustible> getCombustibles()
        {
            return Combustibles;
        }

    }
}
