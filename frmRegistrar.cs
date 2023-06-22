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
            int n = dtgvRegistro.Rows.Add();

            dtgvRegistro.Rows[n].Cells[0].Value = dtpFecha.Text;
            dtgvRegistro.Rows[n].Cells[1].Value = cboTipoActividad.Text;
            dtgvRegistro.Rows[n].Cells[2].Value = txtDetalleActividad.Text;
            dtgvRegistro.Rows[n].Cells[3].Value = mrcReunion.Text;
            dtgvRegistro.Rows[n].Cells[4].Value = mrcTareas.Text;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Form Cancelar = new frmMostrar();
            Cancelar.Show();
            this.Hide();
        }

        private void dtgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
