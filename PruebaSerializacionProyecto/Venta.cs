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
        public string nombreEmpleado;
        public string tipoCombustible;
        public int cantLitros;
        public decimal valorPesos;

        public Venta(string Empleado, string Tipo, int Litros, decimal Valor)
        {
            nombreEmpleado = Empleado;
            tipoCombustible = Tipo;
            cantLitros = Litros;
            valorPesos = Valor;
        }

        public string NombreEmpleado { get { return nombreEmpleado; } set { nombreEmpleado = value; } }
        public string TipoCombustible { get { return TipoCombustible; } set { tipoCombustible = value; } }
        public int CantLitros { get { return cantLitros; } set { cantLitros = value; } }
        public decimal ValorPesos { get { return valorPesos; } set { valorPesos = value; } }
    }
}
