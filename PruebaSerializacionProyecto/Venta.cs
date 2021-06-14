using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSerializacionProyecto
{
    [Serializable]
    public class Venta
    {
        private string nombreEmpleado;
        private string tipoCombustible;
        private decimal valorPesos;
        private decimal cantidadLitros;

        public Venta(string Empleado, string Tipo, decimal Valor , decimal Litros)
        {
            nombreEmpleado = Empleado;
            tipoCombustible = Tipo;
            valorPesos = Valor;
            cantidadLitros = Litros;
        }


        public string NombreEmpleado { get { return nombreEmpleado; } set { nombreEmpleado = value; } }
        public string TipoCombustible { get { return TipoCombustible; } set { tipoCombustible = value; } }
        public decimal ValorPesos { get { return valorPesos; } set { valorPesos = value; } }
        public decimal CantidadLitros { get { return cantidadLitros; } set { cantidadLitros = value; } }


    }
}
