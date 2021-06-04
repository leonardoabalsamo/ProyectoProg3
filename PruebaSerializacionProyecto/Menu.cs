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
        public Menu(ref Sistema emp)
        {
            InitializeComponent();
            empleados = emp;
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
            FormCarga frmCarga = new FormCarga(ref empleados);
            frmCarga.Show();
            this.Hide();
        }
    }
}
