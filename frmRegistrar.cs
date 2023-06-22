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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipoDeActividad.SelectedIndex != 1)
                {
                    if (txtDetalleActividad.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar");
                    }
                    else
                    {
                        MessageBox.Show("Te falta completar el detalle");
                        txtDetalleActividad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad");
                    lstTipoDeActividad.Focus(); 
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();   
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.ShowDialog();
            this.Hide();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
