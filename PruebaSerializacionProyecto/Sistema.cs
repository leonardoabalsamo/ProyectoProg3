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
        private List<Empleado> Empleados;
        private List<Combustible> Combustibles;
        private List<Venta> Ventas;

        public Sistema()
        {
            Empleados = new List<Empleado>();
            Empleados.Add(new Empleado("Matias"));
            Empleados.Add(new Empleado("Maira"));
            Empleados.Add(new Empleado("Leonardo"));
            Empleados.Add(new Empleado("Carla"));
            Empleados.Add(new Empleado("Ezequiel"));

            Ventas = new List<Venta>();


            Combustibles = new List<Combustible>();
            Combustibles.Add(new Combustible("Super", 0, 0));
            Combustibles.Add(new Combustible("Diesel", 0, 0));
            Combustibles.Add(new Combustible("Premium", 0, 0));
            Combustibles.Add(new Combustible("Ultra Diesel", 0, 0));
        }

        public List<string> cargaEmpleado()
        {
            List<string> arrayEmpleados = new List<string>(); 

            foreach (var item in Empleados)
            {
                arrayEmpleados.Add(item.Nombre);
            }

            return arrayEmpleados;
        }

        public decimal stockActual(string pal)
        {
            decimal valor = 0;
            foreach (var item in Combustibles)
            {
                if (String.Equals(item.Nombre,pal))
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
            if (String.Equals(ingreso,""))
            {
                ingreso = "0";
            }

            foreach (var item in Combustibles)
            {
                if (String.Equals(item.Nombre,nombre))
                {
                    item.Stock = item.Stock + Decimal.Parse(ingreso);
                    stockActualizado = item.Stock;
                }
            }
                
            return stockActualizado;
        }

        public decimal precioActual(string pal)
        {
            decimal valor = 0;
            foreach (var item in Combustibles)
            {
                if (String.Equals(item.Nombre, pal))
                {
                    valor = item.Precio;
                }
            }

            if (valor != 0)
            {
                return valor;
            }
            else return 0;
        }

        public decimal actualizarPrecio(string nombre, string precioNuevo)
        {
            decimal precioActualizado = 0;

            if (String.Equals(precioNuevo, ""))
            {
                precioNuevo = "0";
            }

            foreach (var item in Combustibles)
            {
                if (String.Equals(item.Nombre, nombre))
                {
                    if (Int32.Parse(precioNuevo) == 0)
                    {
                        return item.Precio;
                    }
                    else
                    {
                        item.Precio = Decimal.Parse(precioNuevo);
                        precioActualizado = item.Precio;
                    }
                }
            }

            return precioActualizado;
        }
    }
}
