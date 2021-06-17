using System;
using System.Collections;
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
        public void descontarStock(string nombre, string ingreso)
        {
            foreach (var item in Combustibles)
            {
                if (String.Equals(item.Nombre, nombre))
                {
                    item.Stock = item.Stock - Decimal.Parse(ingreso);
                }
            }
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

        /*Genero una venta desde el metodo publico*/
        public void CargarVenta(Venta venta)
        {
            Ventas.Add(venta);
        }

        public string MuestraVenta(string EmpleadoSeleccionado)
        {
            string aux = null; string cadena = null;

            foreach (var item in Ventas)
            {
                if (item.NombreEmpleado.Contains(EmpleadoSeleccionado))
                {
                    aux = (item.CantidadLitros.ToString() + "   " + item.TipoCombustible + "   " + item.ValorPesos.ToString()) + "\n";
                }
                cadena = string.Concat(cadena, aux);
            }
            return cadena;
        }

        public List<string> ListaVentas() 
        {
            List<string> lVentas = new List<string>();
            string frase = null;

            foreach (var item in Ventas)
            {
                frase = item.ToString();
                lVentas.Add(frase);
                frase = null;
            }

            return lVentas;
        }
        
        /*Metodo recibe el nombre del empleado y devuelve la suma de ventas (pesos) */
        public decimal ReportePesosEmpleado(string nombreEmpleado)
        {
            decimal suma=0;
            foreach (var item in Ventas)
            {
                if (item.NombreEmpleado.Contains(nombreEmpleado))
                {
                    suma = suma + item.ValorPesos;
                }
            }
            return suma;        // si suma vale cero el empleado no realizo ventas!
        }


    }
}
