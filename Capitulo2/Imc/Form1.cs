using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        RadioButton rbnSelecionado = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void rb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                setPesoIdeal();
            }
        }

        private void setPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txt_Altura.Text);
                double pesoIdeal;

                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                else
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    lbl_Resultado.Text = pesoIdeal.ToString("N");
                }
            }
            catch 
            {
                MessageBox.Show("Selecione o sexo e informe alatura corretamente", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                setPesoIdeal();
            }
        }
    }
}
