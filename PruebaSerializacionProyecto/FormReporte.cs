using System;
using System.Collections;
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
            listReporte.Items.Clear();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            ComboBoxEmpleados.Items.AddRange(empleados.cargaEmpleado().ToArray());
            ComboBoxEmpleados.SelectedIndex = 0;
        }


        
        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string Nombre = ComboBoxEmpleados.SelectedItem.ToString();            
            listReporte.Items.Clear();

            foreach (var item in empleados.CargaVentaEmpleado(Nombre))
            {
                listReporte.Items.Add(item);
            }
           
        }
       
    }
}
