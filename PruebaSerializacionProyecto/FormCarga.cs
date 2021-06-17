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

            IngresoSuper.Text = null;
            IngresoDiesel.Text = null;
            IngresoPremium.Text = null;
            IngresoUltra.Text = null;

            /*Inicializo Precio y coloco inputs en null*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();

            nuevoPrecioSuper.Text = null;
            nuevoPrecioDiesel.Text = null;
            nuevoPrecioPremium.Text = null;
            nuevoPrecioUltra.Text = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int maxValue = 10000;
            /*Actualizo Stock y coloco inputs en null*/
            //Super
            if (IngresoSuper.Text == null) { stockSuper.Text = empleados.actualizarStock("Super", "0").ToString(); }
            else if ( (Decimal.Parse(stockSuper.Text) + Decimal.Parse(IngresoSuper.Text)) <= maxValue ){ 
                stockSuper.Text = empleados.actualizarStock("Super", IngresoSuper.Text).ToString();
            }
            else { MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }              
            //Diesel
            if (IngresoDiesel.Text == null) { StockDiesel.Text = empleados.actualizarStock("Diesel", "0").ToString(); }
            else if ((Decimal.Parse(StockDiesel.Text) + Decimal.Parse(IngresoDiesel.Text)) <= maxValue)
            {
                StockDiesel.Text = empleados.actualizarStock("Diesel", IngresoDiesel.Text).ToString();
            }
            else { MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //Premium
            if (IngresoPremium == null) { StockPremium.Text = empleados.actualizarStock("Premium", "0").ToString(); }
            else if ((Decimal.Parse(StockPremium.Text) + Decimal.Parse(IngresoPremium.Text)) <= maxValue)
            {
                StockPremium.Text = empleados.actualizarStock("Premium", IngresoPremium.Text).ToString();
            }
            else { MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //Ultra Diesel
            if (IngresoUltra == null) { StockUltra.Text = empleados.actualizarStock("Ultra Diesel", "0").ToString(); }
            else if ((Decimal.Parse(StockUltra.Text) + Decimal.Parse(IngresoUltra.Text)) <= maxValue)
            {
                StockUltra.Text = empleados.actualizarStock("Ultra Diesel", IngresoUltra.Text).ToString();
            }
            else { MessageBox.Show("No se puede cargar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            IngresoSuper.Text = null;
            IngresoDiesel.Text = null;
            IngresoPremium.Text = null;
            IngresoUltra.Text = null;

            /*Actualizo Precio y coloco inputs en null*/
            if (nuevoPrecioSuper.Text == null) { PrecioSuper.Text = empleados.actualizarPrecio("Super", "0").ToString(); }
            else { PrecioSuper.Text = empleados.actualizarPrecio("Super", nuevoPrecioSuper.Text).ToString(); }

            if (nuevoPrecioDiesel.Text == null) { PrecioDiesel.Text = empleados.actualizarPrecio("Diesel", "0").ToString(); }
            else { PrecioDiesel.Text = empleados.actualizarPrecio("Diesel", nuevoPrecioDiesel.Text).ToString(); }

            if (nuevoPrecioPremium == null) { PrecioPremium.Text = empleados.actualizarPrecio("Premium", "0").ToString(); }
            else { PrecioPremium.Text = empleados.actualizarPrecio("Premium", nuevoPrecioPremium.Text).ToString(); }

            if (nuevoPrecioUltra == null) { PrecioUltra.Text = empleados.actualizarPrecio("Ultra Diesel", "0").ToString(); }
            else { PrecioUltra.Text = empleados.actualizarPrecio("Ultra Diesel", nuevoPrecioUltra.Text).ToString(); }

            nuevoPrecioSuper.Text = null;
            nuevoPrecioDiesel.Text = null;
            nuevoPrecioPremium.Text = null;
            nuevoPrecioUltra.Text = null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

       
    }
}
