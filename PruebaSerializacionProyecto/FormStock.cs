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
        public FormStock(ref Sistema emp,Menu menu)
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
            foreach (var item in empleado.getCombustibles())
            {
                if (String.Equals(item.Key,"super"))
                {
                    stockSuperActual.Text = item.Value.Stock.ToString();
                    barraProgresoSuper.Value = Int32.Parse(item.Value.stock.ToString());
                }
                if (String.Equals(item.Key, "diesel"))
                {
                    stockDieselActual.Text = item.Value.Stock.ToString();
                    barraProgresoDiesel.Value = Int32.Parse(item.Value.stock.ToString());
                }
                if (String.Equals(item.Key, "premium"))
                {
                    stockPremiumActual.Text = item.Value.Stock.ToString();
                    barraProgresoPremium.Value = Int32.Parse(item.Value.stock.ToString());
                }
                if (String.Equals(item.Key, "ultra"))
                {
                    stockUltraActual.Text = item.Value.Stock.ToString();
                    barraProgresoUltra.Value = Int32.Parse(item.Value.stock.ToString());
                }
            }
        }
    }
}
