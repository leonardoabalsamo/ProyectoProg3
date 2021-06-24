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
        Sistema sistema;

        public FormReporte(Sistema sis, Menu menu)
        {
            frmMenu = menu;
            sistema = sis;
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

            gridReporte.Rows.Clear();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            ComboBoxEmpleados.Items.AddRange(sistema.cargaEmpleado().ToArray());
            ComboBoxEmpleados.SelectedIndex = 0;
        }



        private void Seleccionar_Click(object sender, EventArgs e)
        {
            string Nombre = ComboBoxEmpleados.SelectedItem.ToString();
            gridReporte.Rows.Clear();

            foreach ( var item in sistema.CargaVentaEmpleado(Nombre))
            {
                gridReporte.Rows.Add(item.NombreEmpleado,item.TipoCombustible,item.ValorPesos,item.CantidadLitros);
            }
           
        }
    }
}
