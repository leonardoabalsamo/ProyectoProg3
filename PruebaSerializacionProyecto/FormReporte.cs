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

            listNombre.Items.Clear();
            listCombustible.Items.Clear();
            listPesos.Items.Clear();
            listLitros.Items.Clear();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            ComboBoxEmpleados.Items.AddRange(empleados.cargaEmpleado().ToArray());
            ComboBoxEmpleados.SelectedIndex = 0;
        }



        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string Nombre = ComboBoxEmpleados.SelectedItem.ToString();
            listNombre.Items.Clear();
            listCombustible.Items.Clear();
            listPesos.Items.Clear();
            listLitros.Items.Clear();

            foreach (var item in empleados.CargaVentaEmpleado(Nombre))
            {
                listNombre.Items.Add(item.NombreEmpleado);
                listCombustible.Items.Add(item.TipoCombustible);
                listPesos.Items.Add(item.ValorPesos);
                listLitros.Items.Add(item.CantidadLitros);
            }
           
        }
       
    }
}
