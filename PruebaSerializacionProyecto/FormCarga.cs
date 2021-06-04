using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSerializacionProyecto
{
    public partial class FormCarga : Form
    {
        private Sistema empleados;

        public FormCarga(ref Sistema emp)
        {
            InitializeComponent();
            empleados = emp;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {

            foreach (KeyValuePair<string,Combustible> item in empleados.getCombustibles())
            {
                if (String.Equals(item.Key,"super"))
                {
                    var numero = item.Value.Stock;
                    txtStockActual1.Text = numero.ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Combustible> item in empleados.getCombustibles())
            {
                if (String.Equals(item.Key, "super"))
                {
                    decimal numero = Convert.ToDecimal(txtStockNuevo.Text);
                    var suma = item.Value.Stock + numero;
                    txtStockActual1.Text = suma.ToString();
                    item.Value.Stock = suma;
                }
            }
        }
    }
}
