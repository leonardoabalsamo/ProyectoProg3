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
        private Sistema sistema;
        private string EmpleadoSeleccionado;

        public FormDescarga(Sistema sis , Form menu )
        {
            frmMenu = (Menu)menu;
            sistema = sis;
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
            StockSuper.Text = sistema.stockActual("Super").ToString();
            StockDiesel.Text = sistema.stockActual("Diesel").ToString();
            StockPremium.Text = sistema.stockActual("Premium").ToString();
            StockUltra.Text = sistema.stockActual("Ultra Diesel").ToString();

            /*Inicializo Precio consultando al método precioActual*/
            PrecioSuper.Text = sistema.precioActual("Super").ToString();
            PrecioDiesel.Text = sistema.precioActual("Diesel").ToString();
            PrecioPremium.Text = sistema.precioActual("Premium").ToString();
            PrecioUltra.Text = sistema.precioActual("Ultra Diesel").ToString();

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
            
            if (VentaLitrosSuper.Text != 0.ToString())
            {

                if (Decimal.Parse(VentaLitrosSuper.Text) <= sistema.stockActual("Super"))
                {
                    VentaPesosSuper.Text = (Decimal.Parse(VentaLitrosSuper.Text) * Decimal.Parse(PrecioSuper.Text)).ToString();
                    sistema.descontarStock("Super", VentaLitrosSuper.Text);
                    Venta Super = new Venta(EmpleadoSeleccionado, "Super", Decimal.Parse(VentaPesosSuper.Text), Decimal.Parse(VentaLitrosSuper.Text));
                    sistema.CargarVenta(Super);
                    VentaLitrosSuper.Text = 0.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede despachar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (VentaLitrosDiesel.Text != 0.ToString())
            {

                if (Decimal.Parse(VentaLitrosDiesel.Text) <= sistema.stockActual("Diesel"))
                {
                    VentaPesosDiesel.Text = (Decimal.Parse(VentaLitrosDiesel.Text) * Decimal.Parse(PrecioDiesel.Text)).ToString();
                    sistema.descontarStock("Diesel", VentaLitrosDiesel.Text);
                    Venta Diesel = new Venta(EmpleadoSeleccionado, "Diesel", Decimal.Parse(VentaPesosDiesel.Text), Decimal.Parse(VentaLitrosDiesel.Text));
                    sistema.CargarVenta(Diesel);
                    VentaLitrosDiesel.Text = 0.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede despachar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (VentaLitrosPremium.Text != 0.ToString())
            {

                if (Decimal.Parse(VentaLitrosPremium.Text) <= sistema.stockActual("Premium"))
                {
                    VentaPesosPremium.Text = (Decimal.Parse(VentaLitrosPremium.Text) * Decimal.Parse(PrecioPremium.Text)).ToString();
                    sistema.descontarStock("Premium", VentaLitrosPremium.Text);
                    Venta Premium = new Venta(EmpleadoSeleccionado, "Premium", Decimal.Parse(VentaPesosPremium.Text), Decimal.Parse(VentaLitrosPremium.Text));
                    sistema.CargarVenta(Premium);
                    VentaLitrosPremium.Text = 0.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede despachar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (VentaLitrosUltra.Text != 0.ToString())
            {

                if (Decimal.Parse(VentaLitrosUltra.Text) <= sistema.stockActual("Ultra Diesel"))
                {
                    VentaPesosUltra.Text = (Decimal.Parse(VentaLitrosUltra.Text) * Decimal.Parse(PrecioUltra.Text)).ToString();
                    sistema.descontarStock("Ultra Diesel", VentaLitrosDiesel.Text);
                    Venta Ultra = new Venta(EmpleadoSeleccionado, "Ultra Diesel", Decimal.Parse(VentaPesosUltra.Text), Decimal.Parse(VentaLitrosUltra.Text));
                    sistema.CargarVenta(Ultra);
                    VentaLitrosUltra.Text = 0.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede despachar combustible por sobre el valor maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            /*Actualizo el stock en función de lo descargado*/

            StockSuper.Text = sistema.stockActual("Super").ToString();
            StockDiesel.Text = sistema.stockActual("Diesel").ToString();
            StockPremium.Text = sistema.stockActual("Premium").ToString();
            StockUltra.Text = sistema.stockActual("Ultra Diesel").ToString();

       
        }

        /*Habilito los campos en función del boton seleccionado*/
        private void btnSuper_Click(object sender, EventArgs e)
        {
            VentaLitrosSuper.Enabled = true;
            VentaLitrosDiesel.Enabled = false;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
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
            VentaLitrosDiesel.Enabled = true;
            VentaLitrosPremium.Enabled = false;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosSuper.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
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
            VentaLitrosPremium.Enabled = true;
            VentaLitrosUltra.Enabled = false;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosSuper.Text = 0.ToString();
            VentaLitrosUltra.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = false;
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
            VentaLitrosUltra.Enabled = true;

            VentaLitrosDiesel.Text = 0.ToString();
            VentaLitrosPremium.Text = 0.ToString();
            VentaLitrosSuper.Text = 0.ToString();

            VentaPesosSuper.Enabled = false;
            VentaPesosDiesel.Enabled = false;
            VentaPesosPremium.Enabled = false;
            VentaPesosUltra.Enabled = false;

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
            PrecioSuper.Text = sistema.precioActual("Super").ToString();
            PrecioDiesel.Text = sistema.precioActual("Diesel").ToString();
            PrecioPremium.Text = sistema.precioActual("Premium").ToString();
            PrecioUltra.Text = sistema.precioActual("Ultra Diesel").ToString();

            /*Inicializo Stock consultando al método stockActual*/
            StockSuper.Text = sistema.stockActual("Super").ToString();
            StockDiesel.Text = sistema.stockActual("Diesel").ToString();
            StockPremium.Text = sistema.stockActual("Premium").ToString();
            StockUltra.Text = sistema.stockActual("Ultra Diesel").ToString();
        }
    }
}
