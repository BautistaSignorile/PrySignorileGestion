using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnIngresarActividad_Click(object sender, EventArgs e)
        {
            Form MostrarActividad = new frmRegistrar();
            MostrarActividad.Show();
            this.Hide();
        }
    }
}
