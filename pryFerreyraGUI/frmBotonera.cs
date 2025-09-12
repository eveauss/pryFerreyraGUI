using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFerreyraGUI
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }

        //Variables globales
        string[] Nombres = new string[8];
        int i = 0;

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            Nombres[0] = "Namjoon";
            Nombres[1] = "SeokJin";
            Nombres[2] = "Yoongi";
            Nombres[3] = "Hoseok";
            Nombres[4] = "Jimin";
            Nombres[5] = "Taehyung";
            Nombres[6] = "Jungkook";
            Nombres[7] = "BTS!!";

            lblDatos.Text = Nombres[0];

        }

        private void btnAdeltante_Click(object sender, EventArgs e)
        {
            if (i < Nombres.Length - 1)
            {
                i++;
                lblDatos.Text = Nombres[i];
            }
            else
            {
                MessageBox.Show("Ya llegaste al límite de nombres");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {


            if (i > 0)
            {
                i--;
                lblDatos.Text = Nombres[i];
            }
            else
            {
                MessageBox.Show("Ya llegaste al primer nombre");
            }
        }

        private void comboBoxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
