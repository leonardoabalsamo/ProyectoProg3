using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSerializacionProyecto
{
    [Serializable]
    public class Sistema
    {
        public List<string> Empleados;
        public List<Combustible> Combustibles;
        public List<Venta> Ventas;

        public Sistema()
        {
            Empleados = new List<string>();
            Empleados.Add("Matias");
            Empleados.Add("Jose");
            Empleados.Add("Leonardo");
            Empleados.Add("Carla");
            Empleados.Add("Marta");

            Ventas = new List<Venta>();


            Combustibles = new List<Combustible>();
            Combustibles.Add(new Combustible("Super", 0, 0));
            Combustibles.Add(new Combustible("Diesel", 0, 0));
            Combustibles.Add(new Combustible("Premium", 0, 0));
            Combustibles.Add(new Combustible("Ultra Diesel", 0, 0));
        }

        public List<string> empleados
        {
            get { return Empleados; }
        }

        public List<Combustible> getCombustibles()
        {
            return Combustibles;
        }

        public List<string> cargaEmpleado()
        {
            List<string> arrayEmpleados = new List<string>(); 

            foreach (var item in Empleados)
            {
                arrayEmpleados.Add(item);
            }

            return arrayEmpleados;
        }

        public decimal stockActual(string pal)
        {
            decimal valor = 0;
            foreach (var item in Combustibles)
            {
                if (String.Equals(item.nombre,pal))
                {
                    valor = item.Stock;
                }
            }

            if (valor != 0)
            {
                return valor;
            }
            else return 0;
        }

        public decimal actualizarStock(string nombre, string ingreso)
        {
            decimal stockActualizado = 0;

            foreach (var item in Combustibles)
            {
                if (String.Equals(item.nombre,nombre))
                {
                    item.Stock = item.Stock + Decimal.Parse(ingreso);
                    stockActualizado = item.Stock;
                }
            }
                
            return stockActualizado;
        }

    }
}
