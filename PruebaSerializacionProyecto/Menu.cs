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
        public string label;
        private Sistema empleados;
        private FormCarga frmCarga;
        private FormDescarga frmDescarga;
        private FormInicio frmInicio;
        private FormReporte frmReporte;
        private FormStock frmStock;

        public Menu(ref Sistema emp , Form inicio)
        {
            empleados = emp;
            frmInicio = (FormInicio)inicio;
            frmCarga = new FormCarga(ref empleados , this);
            frmDescarga = new FormDescarga(ref empleados, this);
            frmReporte = new FormReporte(this);
            frmStock = new FormStock(ref empleados,this);
            InitializeComponent();
        }

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
