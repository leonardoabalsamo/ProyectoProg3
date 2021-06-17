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

        public object MsgBox { get; private set; }

        public FormCarga(Sistema emp , Form Menu)
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
            /*Inicializo Stock y coloco inputs en null*/
            stockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();

            IngresoSuper.Text = "";
            IngresoDiesel.Text = "";
            IngresoPremium.Text = "";
            IngresoUltra.Text = "";

            /*Inicializo Precio y coloco inputs en null*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();

            nuevoPrecioSuper.Text = "";
            nuevoPrecioDiesel.Text = "";
            nuevoPrecioPremium.Text = "";
            nuevoPrecioUltra.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal maxValue = 10000;
            /*Actualizo Stock y coloco inputs en null*/
            
            //Super
            if (String.Equals(IngresoSuper.Text,"")) 
            { 
                stockSuper.Text = empleados.actualizarStock("Super", "0").ToString(); 
            }
            else if (!String.Equals(IngresoSuper.Text, ""))
            {
                decimal val1 = Decimal.Parse(stockSuper.Text);
                decimal val2 = Decimal.Parse(IngresoSuper.Text);
                decimal sum = val1 + val2;
                if (sum <= maxValue)
                {
                    stockSuper.Text = empleados.actualizarStock("Super", IngresoSuper.Text).ToString();
                }
                else
                {
                    MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
            
            //Diesel
            if (IngresoDiesel.Text == "") { StockDiesel.Text = empleados.actualizarStock("Diesel", "0").ToString(); }
            else if (IngresoDiesel.Text != "")
            {
                decimal val1 = Decimal.Parse(StockDiesel.Text);
                decimal val2 = Decimal.Parse(IngresoDiesel.Text);
                decimal sum = val1 + val2;
                if (sum <= maxValue)
                {
                    StockDiesel.Text = empleados.actualizarStock("Diesel", IngresoDiesel.Text).ToString();
                }
                else
                {
                    MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            //Premium
            if (IngresoPremium.Text == "") { StockPremium.Text = empleados.actualizarStock("Premium", "0").ToString(); }
            else if (IngresoPremium.Text != "")
            {
                decimal val1 = Decimal.Parse(StockPremium.Text);
                decimal val2 = Decimal.Parse(IngresoPremium.Text);
                decimal sum = val1 + val2;
                if (sum <= maxValue)
                {
                    StockPremium.Text = empleados.actualizarStock("Premium", IngresoPremium.Text).ToString();
                }
                else 
                { 
                    MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

            }

            //Ultra Diesel
            if (IngresoUltra.Text == "") { StockUltra.Text = empleados.actualizarStock("Ultra Diesel", "0").ToString(); }
            else if (IngresoUltra.Text != "")
            {
                decimal val1 = Decimal.Parse(StockUltra.Text);
                decimal val2 = Decimal.Parse(IngresoUltra.Text);
                decimal sum = val1 + val2;
                if (sum <= maxValue)
                {
                    StockUltra.Text = empleados.actualizarStock("Ultra Diesel", IngresoUltra.Text).ToString();
                }
                else
                {
                    MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            IngresoSuper.Text = "";
            IngresoDiesel.Text = "";
            IngresoPremium.Text = "";
            IngresoUltra.Text = "";

            /*Actualizo Precio y coloco inputs en null*/
            if (nuevoPrecioSuper.Text == "") { PrecioSuper.Text = empleados.actualizarPrecio("Super", "0").ToString(); }
            else { PrecioSuper.Text = empleados.actualizarPrecio("Super", nuevoPrecioSuper.Text).ToString(); }

            if (nuevoPrecioDiesel.Text == "") { PrecioDiesel.Text = empleados.actualizarPrecio("Diesel", "0").ToString(); }
            else { PrecioDiesel.Text = empleados.actualizarPrecio("Diesel", nuevoPrecioDiesel.Text).ToString(); }

            if (nuevoPrecioPremium.Text == "") { PrecioPremium.Text = empleados.actualizarPrecio("Premium", "0").ToString(); }
            else { PrecioPremium.Text = empleados.actualizarPrecio("Premium", nuevoPrecioPremium.Text).ToString(); }

            if (nuevoPrecioUltra.Text == "") { PrecioUltra.Text = empleados.actualizarPrecio("Ultra Diesel", "0").ToString(); }
            else { PrecioUltra.Text = empleados.actualizarPrecio("Ultra Diesel", nuevoPrecioUltra.Text).ToString(); }

            nuevoPrecioSuper.Text = "";
            nuevoPrecioDiesel.Text = "";
            nuevoPrecioPremium.Text = "";
            nuevoPrecioUltra.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

        private void FormCarga_Activated(object sender, EventArgs e)
        {
            /*Inicializo Stock y coloco inputs en null*/
            stockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();

            IngresoSuper.Text = "";
            IngresoDiesel.Text = "";
            IngresoPremium.Text = "";
            IngresoUltra.Text = "";

            /*Inicializo Precio y coloco inputs en null*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();

            nuevoPrecioSuper.Text = "";
            nuevoPrecioDiesel.Text = "";
            nuevoPrecioPremium.Text = "";
            nuevoPrecioUltra.Text = "";
        }
    }
}
