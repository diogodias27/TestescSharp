using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeVlores
{
    public partial class frmTrocadeValores : Form
    {
        public frmTrocadeValores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtPrimeiroValor.Text;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = auxiliar;

            MessageBox.Show("Troca de Valores concluida!","Informação", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
