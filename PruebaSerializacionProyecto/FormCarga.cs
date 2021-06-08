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
            /*Inicializo Stock y coloco inputs en 0*/
            stockSuper.Text = empleados.stockActual("Super").ToString();
            StockDiesel.Text = empleados.stockActual("Diesel").ToString();
            StockPremium.Text = empleados.stockActual("Premium").ToString();
            StockUltra.Text = empleados.stockActual("Ultra Diesel").ToString();
            IngresoSuper.Text = "0";
            IngresoDiesel.Text = "0";
            IngresoPremium.Text = "0";
            IngresoUltra.Text = "0";

            /*Inicializo Precio y coloco inputs en 0*/
            PrecioSuper.Text = empleados.precioActual("Super").ToString();
            PrecioDiesel.Text = empleados.precioActual("Diesel").ToString();
            PrecioPremium.Text = empleados.precioActual("Premium").ToString();
            PrecioUltra.Text = empleados.precioActual("Ultra Diesel").ToString();
            nuevoPrecioSuper.Text = "0";
            nuevoPrecioDiesel.Text = "0";
            nuevoPrecioPremium.Text = "0";
            nuevoPrecioUltra.Text = "0";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Actualizo Stock y coloco inputs en 0*/
            stockSuper.Text = empleados.actualizarStock("Super", IngresoSuper.Text).ToString();
            StockDiesel.Text = empleados.actualizarStock("Diesel", IngresoDiesel.Text).ToString();
            StockPremium.Text = empleados.actualizarStock("Premium", IngresoPremium.Text).ToString();
            StockUltra.Text = empleados.actualizarStock("Ultra Diesel", IngresoUltra.Text).ToString();
            IngresoSuper.Text = "0";
            IngresoDiesel.Text = "0";
            IngresoPremium.Text = "0";
            IngresoUltra.Text = "0";

            /*Actualizo Precio y coloco inputs en 0*/
            PrecioSuper.Text = empleados.actualizarPrecio("Super", nuevoPrecioSuper.Text).ToString();
            PrecioDiesel.Text = empleados.actualizarPrecio("Diesel", nuevoPrecioDiesel.Text).ToString();
            PrecioPremium.Text = empleados.actualizarPrecio("Premium", nuevoPrecioPremium.Text).ToString();
            PrecioUltra.Text = empleados.actualizarPrecio("Ultra Diesel", nuevoPrecioUltra.Text).ToString();
            nuevoPrecioSuper.Text = "0";
            nuevoPrecioDiesel.Text = "0";
            nuevoPrecioPremium.Text = "0";
            nuevoPrecioUltra.Text = "0";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

       
    }
}
