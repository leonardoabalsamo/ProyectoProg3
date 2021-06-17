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
    public partial class FormStock : Form
    {
        Menu frmMenu;
        Sistema empleado;
        public FormStock(Sistema emp,Menu menu)
        {
            frmMenu = menu;
            empleado = emp;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            frmMenu.Show();
            this.Hide();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            stockSuperActual.Text = empleado.stockActual("Super").ToString();
            barraProgresoSuper.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockSuperActual.Text)).ToString());

            stockDieselActual.Text = empleado.stockActual("Diesel").ToString();
            barraProgresoDiesel.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockDieselActual.Text)).ToString());

            stockPremiumActual.Text = empleado.stockActual("Premium").ToString();
            barraProgresoPremium.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockPremiumActual.Text)).ToString());

            stockUltraActual.Text = empleado.stockActual("Ultra Diesel").ToString();
            barraProgresoUltra.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockUltraActual.Text)).ToString());

        }

        private void FormStock_Activated(object sender, EventArgs e)
        {
            stockSuperActual.Text = empleado.stockActual("Super").ToString();
            barraProgresoSuper.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockSuperActual.Text)).ToString());

            stockDieselActual.Text = empleado.stockActual("Diesel").ToString();
            barraProgresoDiesel.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockDieselActual.Text)).ToString());

            stockPremiumActual.Text = empleado.stockActual("Premium").ToString();
            barraProgresoPremium.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockPremiumActual.Text)).ToString());

            stockUltraActual.Text = empleado.stockActual("Ultra Diesel").ToString();
            barraProgresoUltra.Value = Int32.Parse(Decimal.Round(Decimal.Parse(stockUltraActual.Text)).ToString());
        }
    }
}
