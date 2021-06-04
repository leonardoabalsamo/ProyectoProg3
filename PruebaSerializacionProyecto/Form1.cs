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
    public partial class Form1 : Form
    {
        Sistema empleados;
        public Form1(ref Sistema s)
        {
            InitializeComponent();
            empleados = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in empleados.empleados)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(ref empleados);
            string bienvenida = "Bienvenido" + " " + comboBox1.SelectedItem.ToString();
            menu.label = bienvenida;
            menu.Show();
            this.Hide();
        }

    }
}
