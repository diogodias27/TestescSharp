using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleValidades
{
    public partial class TELAiNICIAL : Form
    {
        public TELAiNICIAL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void éTICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 etico = new Form2();
            etico.ShowDialog();
        }

      
    }
}
