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
        frmMostrar frmMostrar1 = new frmMostrar();
        public frmRegistrar()
        {
            InitializeComponent();
        }

        string[] vectorActividad = new string[10];
        string reunion = " ";
        string tareas = " ";
        string fecha = "";
        string actividad;
        string detalle;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                fecha = dtpFecha.Value.ToString();

                if (lstTipoDeActividad.SelectedIndex != 1)
                {
                    actividad = lstTipoDeActividad.Text;

                    if (txtDetalleActividad.Text != "")
                    {
                        detalle = txtDetalleActividad.Text;
                        if (optSi.Checked == true)
                        {
                            reunion = "SI";
                        }
                        else
                        {
                            reunion = "NO";
                        }

                        if (chkDebate.Checked)
                        {
                            tareas = "Debate";
                        }
                        if (chkInvestigacion.Checked) ;
                        {
                            tareas = tareas + "Investigacion";
                        }
                        if (chkNotasReunion.Checked) ;
                        {
                            tareas = tareas + "Notas";
                        }
                        if (chkRepositorio.Checked)
                        {
                            tareas = tareas + "Repositorio";
                        }
                        MessageBox.Show("Vamos a grabar");

                        frmMostrar1.matrizMostrar[i, 0] = fecha;
                        frmMostrar1.matrizMostrar[i, 1] = actividad; 
                        frmMostrar1.matrizMostrar[i, 2] = detalle;
                        frmMostrar1.matrizMostrar[i, 3] = reunion;
                        frmMostrar1.matrizMostrar[i, 4] = tareas;
                        i++;


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
            frmMostrar1.ShowDialog();
            this.Hide();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
