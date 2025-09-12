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
            botonera.ShowDialog();
        }
    }
}
