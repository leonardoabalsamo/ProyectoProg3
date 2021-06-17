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
        private string EmpleadoSeleccionado;

        public FormDescarga(Sistema emp , Form menu )
        {
            frmMenu = (Menu)menu;
            empleados = emp;
            InitializeComponent();
        }

        public void setEmpleadoSeleccionado(string emp) { EmpleadoSeleccionado = emp; }

        private void FormDescarga_Load(object sender, EventArgs e)
        {

            /*Deshabilito todos los campos*/
            VentaLitrosSuper.Enabled = false;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = false;
            VentaPesosUltra.Enabled = false;

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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (VentaPesosSuper.Text != 0.ToString())
            {
                VentaLitrosSuper.Text = (Decimal.Parse(VentaPesosSuper.Text) / Decimal.Parse(PrecioSuper.Text)).ToString();
                empleados.descontarStock("Super", VentaLitrosSuper.Text);
                Venta Super = new Venta(EmpleadoSeleccionado, "Super", Decimal.Parse(VentaPesosSuper.Text), Decimal.Parse(VentaLitrosSuper.Text));
                empleados.CargarVenta(Super);
                VentaPesosSuper.Text = 0.ToString();

            }


            if (VentaPesosDiesel.Text != 0.ToString())
            {
                VentaLitrosDiesel.Text = (Decimal.Parse(VentaPesosDiesel.Text) / Decimal.Parse(PrecioDiesel.Text)).ToString();
                empleados.descontarStock("Diesel", VentaLitrosDiesel.Text);
                Venta Diesel = new Venta(EmpleadoSeleccionado, "Diesel", Decimal.Parse(VentaPesosDiesel.Text), Decimal.Parse(VentaLitrosDiesel.Text));
                empleados.CargarVenta(Diesel);
                VentaPesosDiesel.Text = 0.ToString();

            }

            if (VentaPesosPremium.Text != 0.ToString())
            {
                VentaLitrosPremium.Text = (Decimal.Parse(VentaPesosPremium.Text) / Decimal.Parse(PrecioPremium.Text)).ToString();
                empleados.descontarStock("Premium", VentaLitrosPremium.Text);
                Venta Premium = new Venta(EmpleadoSeleccionado, "Premium", Decimal.Parse(VentaPesosPremium.Text), Decimal.Parse(VentaLitrosPremium.Text));
                empleados.CargarVenta(Premium);
                VentaPesosPremium.Text = 0.ToString();

            }

            if (VentaPesosUltra.Text != 0.ToString())
            {
                VentaLitrosUltra.Text = (Decimal.Parse(VentaPesosUltra.Text) / Decimal.Parse(PrecioUltra.Text)).ToString();
                empleados.descontarStock("Ultra Diesel", VentaLitrosUltra.Text);
                Venta Ultra = new Venta(EmpleadoSeleccionado, "Ultra Diesel", Decimal.Parse(VentaPesosUltra.Text), Decimal.Parse(VentaLitrosUltra.Text));
                empleados.CargarVenta(Ultra);
                VentaPesosUltra.Text = 0.ToString();
            }


            /*Actualizo el stock en función de lo descargado*/

            StockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();

       
        }

        /*Habilito los campos en función del boton seleccionado*/
        private void btnSuper_Click(object sender, EventArgs e)
        {
            VentaLitrosSuper.Enabled = false;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = true;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = false;
            VentaPesosUltra.Enabled = false;

            VentaPesosDiesel.Text = 0.ToString();
            VentaPesosPremium.Text = 0.ToString();
            VentaPesosUltra.Text = 0.ToString();
        }

        private void btnDiesel_Click(object sender, EventArgs e)
        {
            VentaLitrosSuper.Enabled = false;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosSuper.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = true;
            VentaPesosPremium.Enabled = false;
            VentaPesosUltra.Enabled = false;

            VentaPesosSuper.Text = 0.ToString();
            VentaPesosPremium.Text = 0.ToString();
            VentaPesosUltra.Text = 0.ToString();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            VentaLitrosSuper.Enabled = false;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosSuper.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = true;
            VentaPesosUltra.Enabled = false;

            VentaPesosDiesel.Text = 0.ToString();
            VentaPesosSuper.Text = 0.ToString();
            VentaPesosUltra.Text = 0.ToString();
        }

        private void btnUltra_Click(object sender, EventArgs e)
        {
            VentaLitrosSuper.Enabled = false;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosSuper.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = false;
            VentaPesosUltra.Enabled = true;

            VentaPesosDiesel.Text = 0.ToString();
            VentaPesosPremium.Text = 0.ToString();
            VentaPesosSuper.Text = 0.ToString();
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

        private void FormDescarga_Activated(object sender, EventArgs e)
        {
            /*Inicializo Precio consultando al método precioActual*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();

            /*Inicializo Stock consultando al método stockActual*/
            StockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();
        }
    }
}
