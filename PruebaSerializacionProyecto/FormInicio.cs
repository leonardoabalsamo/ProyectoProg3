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
        private Sistema sistema;
        private Menu frmMenu;
        public FormInicio(Sistema s)
        {
            sistema = s;
            frmMenu = new Menu(sistema , this); // Pasamos la referencia del inicio a Menu

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(sistema.cargaEmpleado().ToArray());
            comboBox1.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bienvenida = "Bienvenido" + " " + comboBox1.SelectedItem.ToString();
            frmMenu.setLabel(bienvenida);
            frmMenu.setEmpleadoSeleccionado(comboBox1.SelectedItem.ToString());
            frmMenu.Show(); // Mostramos formulario Menu
            this.Hide(); // Ocultamos formulario1
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
