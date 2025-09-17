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
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        private void btnBonotera_Click(object sender, EventArgs e)
        {
            frmBotonera botonera = new frmBotonera();
            botonera.Nombres[0] = "Feli cumpleanios taiyun";
            botonera.Show();

            int iNombres = 0;
            while (iNombres < botonera.Nombres.Length)
            {
                lstDatos.Items.Add (botonera.Nombres[iNombres]);
                iNombres++;
            }


        }

        private void frmGUI_Load(object sender, EventArgs e)
        {

        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
