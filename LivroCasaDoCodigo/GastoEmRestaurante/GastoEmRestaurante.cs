using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class GastoEmRestaurante : Form
    {
        public GastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double gastos = Convert.ToDouble(txtDespesas.Text);  
            double total = gastos * 1.10;
            txtTotal.Text = total.ToString();
        }
    }
}
