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
    public partial class Menu : Form
    {
        private string label;
        private string EmpleadoSeleccionado;
        private Sistema sistema;
        private FormCarga frmCarga;
        private FormDescarga frmDescarga;
        private FormInicio frmInicio;
        private FormReporte frmReporte;
        private FormStock frmStock;

        public Menu(Sistema sis , Form inicio)
        {
            sistema = sis;
            frmInicio = (FormInicio)inicio;
            frmCarga = new FormCarga(sistema , this);
            frmDescarga = new FormDescarga(sistema, this );
            frmReporte = new FormReporte(sistema, this);
            frmStock = new FormStock(sistema,this);
            InitializeComponent();
        }

        public void setEmpleadoSeleccionado(string emp) { EmpleadoSeleccionado = emp; }
        public void setLabel(string lbl) { label = lbl; }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = label;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCarga.Show();
            this.Hide();
        }

        private void regresaInicio_Click(object sender, EventArgs e)
        {
            frmInicio.Show();
            this.Hide();

        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            frmDescarga.setEmpleadoSeleccionado(EmpleadoSeleccionado);
            frmDescarga.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte.Show();
            this.Hide();
        }
    }
}
