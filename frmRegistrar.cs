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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        string[] vectorActividad = new string[10];

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (cboTipoActividad.SelectedIndex != -1)
                {
                    if (txtDetalleActividad.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");
                        cboTipoActividad.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //vectorActividad[2] = "Programar";
            //lstCargar.Items.Add(vectorActividad[2]);
            int indice = 0;

            while (indice <= 9)
            {
                lstCargar.Items.Add(vectorActividad[indice]);

                indice++; 
            }
        }

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
           int indice = 0;

            while (indice <= 9)
            {
                vectorActividad[indice] = "un dato" + indice;

                indice = indice + 1;
            }
        }
    }
}
