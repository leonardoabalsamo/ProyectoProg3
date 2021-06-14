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
    public partial class FormReporte : Form
    {
        Menu frmMenu;
        Sistema empleados;
        public FormReporte(Sistema E, Menu menu)
        {
            frmMenu = menu;
            empleados = E;
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

        private void FormReporte_Load(object sender, EventArgs e)
        {
            ComboBoxEmpleados.Items.AddRange(empleados.cargaEmpleado().ToArray());
            ComboBoxEmpleados.SelectedIndex = 0;
        }

        // Genera un reporte de ventas del empleado, VER MAÑANA
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            listReporte.DataSource = empleados.ListaVentas();
                
                /*empleados.MuestraVenta(ComboBoxEmpleados.SelectedItem.ToString());*/
        }
    }
}
