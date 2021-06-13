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

        public Venta(string Empleado, string Tipo, decimal Valor)
        {
            nombreEmpleado = Empleado;
            tipoCombustible = Tipo;
            valorPesos = Valor;
        }


        public string NombreEmpleado { get { return nombreEmpleado; } set { nombreEmpleado = value; } }
        public string TipoCombustible { get { return TipoCombustible; } set { tipoCombustible = value; } }
        public decimal ValorPesos { get { return valorPesos; } set { valorPesos = value; } }


        }
}
