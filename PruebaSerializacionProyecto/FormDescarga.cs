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



        public FormDescarga(ref Sistema emp , Menu menu)
        {
            frmMenu = (Menu)menu;
            empleados = emp;
            InitializeComponent();
        }

        private void FormDescarga_Load(object sender, EventArgs e)
        {
            //Recorro la lista de los combustibles, muestro litros y precios.

            foreach (KeyValuePair<string, Combustible> item in empleados.getCombustibles())
            {
                if (String.Equals(item.Key, "super")) // SUPER
                {
                    var auxiliarSuper = item.Value.Stock;
                    stockSuper.Text = auxiliarSuper.ToString();
                }
                if (String.Equals(item.Key, "diesel")) // DIESEL
                {
                    var auxiliarDiesel = item.Value.Stock;
                    StockDiesel.Text = auxiliarDiesel.ToString();
                }
                if (String.Equals(item.Key, "premium")) // PREMIUM
                {
                    var auxiliarPremium = item.Value.Stock;
                    StockPremium.Text = auxiliarPremium.ToString();
                }
                if (String.Equals(item.Key, "ultra")) // ULTRA
                {
                    var auxiliarUltra = item.Value.Stock;
                    StockUltra.Text = auxiliarUltra.ToString();
                }
            }
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
