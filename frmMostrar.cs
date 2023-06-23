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
        public string[,] matrizMostrar = new string[3, 5];
        int c =0;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.ShowDialog();
            this.Close();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtvMatriz.Rows.Clear();
            for (int i = 0; i < matrizMostrar.GetLength(0); i++)
            {
                if (matrizMostrar[i,1] == cboFiltrarActividad.Text)
                {
                    dtvMatriz.Rows.Add(matrizMostrar[i, 0], matrizMostrar[i, 1], matrizMostrar[i, 2], matrizMostrar[i, 3], matrizMostrar[i, 4]);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizMostrar.GetLength(0); i++)
            {
                if (matrizMostrar[i,c] != null)
                {
                    dtvMatriz.Rows.Add(matrizMostrar[i,0], matrizMostrar[i,1], matrizMostrar[i,2], matrizMostrar[i,3], matrizMostrar[i,4]);
                    c++;
                }
            }
        }
    }
}
