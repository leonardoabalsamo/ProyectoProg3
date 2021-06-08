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
    public partial class FormInicio : Form
    {
        Sistema empleados;
        private Menu frmMenu;
        public FormInicio(ref Sistema s)
        {
            empleados = s;
            frmMenu = new Menu(ref empleados , this); // Pasamos la referencia del inicio a Menu

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in empleados.cargaEmpleado())
            {
                comboBox1.Items.Add(item);
            }

            comboBox1.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bienvenida = "Bienvenido" + " " + comboBox1.SelectedItem.ToString();
            frmMenu.label = bienvenida;
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
