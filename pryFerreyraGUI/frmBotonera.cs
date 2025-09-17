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
        public string[] Nombres = new string[8];
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

            int iCombo = 0;
            while (i < Nombres.Length)
            {
                cmbNombres.Items.Add(Nombres[iCombo]);
                iCombo++;
            }

        }

        private void ActualizarBotones()
        {
            btnAdeltante.Enabled = (i < Nombres.Length - 1);
            btnAtras.Enabled = (i > 0);

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            lblDatos.Text = Nombres[0];
            ActualizarBotones();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = Nombres.Length - 1;
            lblDatos.Text = Nombres[Nombres.Length - 1];
            ActualizarBotones();
        }

        private void btnAdeltante_Click_1(object sender, EventArgs e)
        {
            if (i < Nombres.Length - 1)
            {
                i++;
                lblDatos.Text = Nombres[i];
                ActualizarBotones();
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                lblDatos.Text = Nombres[i];
                ActualizarBotones();
            }
        }

        private void gbNombres_Enter(object sender, EventArgs e)
        {

        }
    }
}
