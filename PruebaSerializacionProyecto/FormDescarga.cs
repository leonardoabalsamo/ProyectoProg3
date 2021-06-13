using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSerializacionProyecto
{
    public partial class FormDescarga : Form
    {
        private Menu frmMenu;
        private Sistema empleados;



        public FormDescarga(Sistema emp , Form menu)
        {
            frmMenu = (Menu)menu;
            empleados = emp;
            InitializeComponent();
        }

        private void FormDescarga_Load(object sender, EventArgs e)
        {
            /*Inicializo Stock consultando al método stockActual*/
            StockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();

            /*Inicializo Precio consultando al método precioActual*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();

            VentaLitrosSuper.Text = 0.ToString();
            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Text = 0.ToString();
            VentaPesosDiesel.Text = 0.ToString();
            VentaPesosPremium.Text = 0.ToString();
            VentaPesosUltra.Text = 0.ToString();


            barraProgresoSuper.Value = Int32.Parse(empleados.stockActual("Super").ToString());
            barraProgresoDiesel.Value = Int32.Parse(empleados.stockActual("Diesel").ToString());
            barraProgresoPremium.Value = Int32.Parse(empleados.stockActual("Premium").ToString());
            barraProgresoUltra.Value = Int32.Parse(empleados.stockActual("Ultra Diesel").ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*GENERO UNA VENTA*/ // FALTA TRAER EL NOMBRE DEL EMPLEADO!!!
            
            if (VentaPesosSuper.Text != null)
            {

                new Venta("Matias", "Super", Decimal.Parse(VentaPesosSuper.Text));
                VentaLitrosSuper.Text = (Decimal.Parse(VentaPesosSuper.Text) / Decimal.Parse(PrecioSuper.Text)).ToString();
                empleados.descontarStock("Super", VentaLitrosSuper.Text);
                VentaPesosSuper.Text = 0.ToString();

            }

            if (VentaPesosDiesel.Text != null)
            {
                new Venta("Matias", "Diesel", Decimal.Parse(VentaPesosDiesel.Text));
                VentaLitrosDiesel.Text = (Decimal.Parse(VentaPesosDiesel.Text) / Decimal.Parse(PrecioDiesel.Text)).ToString();
                empleados.descontarStock("Diesel", VentaLitrosDiesel.Text);
                VentaPesosDiesel.Text = 0.ToString();
            }

            if(VentaPesosPremium.Text != null)
            {
                new Venta("Matias", "Premium", Decimal.Parse(VentaPesosPremium.Text));
                VentaLitrosPremium.Text = (Decimal.Parse(VentaPesosPremium.Text) / Decimal.Parse(PrecioPremium.Text)).ToString();
                empleados.descontarStock("Premium", VentaLitrosPremium.Text);
                VentaPesosPremium.Text = 0.ToString();
            }

            if(VentaPesosUltra.Text != null)
            {
                new Venta("Matias", "Ultra Diesel", Decimal.Parse(VentaPesosUltra.Text));
                VentaLitrosUltra.Text = (Decimal.Parse(VentaPesosUltra.Text) / Decimal.Parse(PrecioUltra.Text)).ToString();
                empleados.descontarStock("Ultra Diesel", VentaLitrosUltra.Text);
                VentaPesosUltra.Text = 0.ToString();
            }


            /*Actualizo el stock en función de lo descargado*/

            StockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();

            barraProgresoSuper.Value = Int32.Parse(empleados.stockActual("Super").ToString());
            barraProgresoDiesel.Value = Int32.Parse(empleados.stockActual("Diesel").ToString());
            barraProgresoPremium.Value = Int32.Parse(empleados.stockActual("Premium").ToString());
            barraProgresoUltra.Value = Int32.Parse(empleados.stockActual("Ultra Diesel").ToString());


        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegresarMenu_Click(object sender, EventArgs e)
        {
            frmMenu.Show();
            this.Hide();
        }

      
    }
}
