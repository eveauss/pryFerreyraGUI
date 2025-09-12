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
        string[] Nombres = new string[4];
        int i = 0;

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            Nombres[0] = "Hoseok";
            Nombres[1] = "Jimin";
            Nombres[2] = "Jin";
            Nombres[3] = "Jungkook";

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
                MessageBox.Show("Ya no hay mas nombres");
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
    }
}
