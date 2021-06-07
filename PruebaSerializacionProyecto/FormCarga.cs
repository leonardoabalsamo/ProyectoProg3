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
        private Menu frmMenu;

        public FormCarga(ref Sistema emp , Form Menu)
        {
            empleados = emp;
            frmMenu = (Menu)Menu;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            //Recorro la lista de los combustibles y los muestro en los Inputs

            foreach (KeyValuePair<string,Combustible> item in empleados.getCombustibles())
            {
                if (String.Equals(item.Key,"super")) // SUPER
                {
                    var auxiliarSuper = item.Value.Stock;
                    var auxiliarPrecioSuper = item.Value.precio;

                    stockSuper.Text = auxiliarSuper.ToString();
                    PrecioSuper.Text = auxiliarPrecioSuper.ToString();
                }
                if (String.Equals(item.Key, "diesel")) // DIESEL
                {
                    var auxiliarDiesel = item.Value.Stock;
                    var auxiliarPrecioDiesel = item.Value.precio;

                    StockDiesel.Text = auxiliarDiesel.ToString();
                    PrecioDiesel.Text = auxiliarPrecioDiesel.ToString();

                }
                if (String.Equals(item.Key, "premium")) // PREMIUM
                {
                    var auxiliarPremium = item.Value.Stock;
                    var auxiliarPrecioPremium = item.Value.precio;

                    StockPremium.Text = auxiliarPremium.ToString();
                    PrecioPremium.Text = auxiliarPrecioPremium.ToString();

                }
                if (String.Equals(item.Key, "ultra")) // ULTRA
                {
                    var auxiliarUltra = item.Value.Stock;
                    var auxiliarPrecioUltra = item.Value.precio;

                    StockUltra.Text = auxiliarUltra.ToString();
                    PrecioUltra.Text = auxiliarPrecioUltra.ToString();

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Recorro nuevamente la lista pero sumo lo ingresado en los inputs de carga

            foreach (KeyValuePair<string, Combustible> item in empleados.getCombustibles())
            {
                if (String.Equals(item.Key, "super"))
                {
                    decimal auxiliarSuper = Convert.ToDecimal(IngresoSuper.Text);
                    PrecioSuper.Text = nuevoPrecioSuper.Text;

                    var sumasuper = item.Value.Stock + auxiliarSuper;
                    stockSuper.Text = sumasuper.ToString();
                    item.Value.Stock = sumasuper;
                }
                if (String.Equals(item.Key, "diesel"))
                {
                    decimal auxiliarDiesel = Convert.ToDecimal(IngresoDiesel.Text);
                    PrecioDiesel.Text = nuevoPrecioDiesel.Text;

                    var sumadiesel = item.Value.Stock + auxiliarDiesel;
                    StockDiesel.Text = sumadiesel.ToString();
                    item.Value.Stock = sumadiesel;
                }
                if (String.Equals(item.Key, "premium"))
                {
                    decimal auxiliarPremium = Convert.ToDecimal(IngresoPremium.Text);
                    PrecioPremium.Text = nuevoPrecioPremium.Text;

                    var sumapremium = item.Value.Stock + auxiliarPremium;
                    StockPremium.Text = sumapremium.ToString();
                    item.Value.Stock = sumapremium;
                }
                if (String.Equals(item.Key, "ultra"))
                {
                    decimal auxiliarUltra = Convert.ToDecimal(IngresoUltra.Text);
                    PrecioUltra.Text = nuevoPrecioUltra.Text;

                    var sumaultra = item.Value.Stock + auxiliarUltra;
                    StockUltra.Text = sumaultra.ToString();
                    item.Value.Stock = sumaultra;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

       
    }
}
