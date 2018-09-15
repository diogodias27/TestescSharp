using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDeDivisao
{
    public partial class FrmRestoDaDivisão : Form
    {
        public FrmRestoDaDivisão()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtRestoDaDivisao.Text = resto.ToString();
        }
    }
}
