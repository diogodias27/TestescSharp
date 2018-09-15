using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Nome_Enter(object sender, EventArgs e)
        {
            if (txt_nascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("è preciso informar o ano de nascimento com 4 digítos", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nascimento.Focus();
            }
        }

        private void txt_Ultimo_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Ultimo.Text != String.Empty && Convert.ToInt32(txt_Ultimo.Text) <= Convert.ToInt32(txt_nascimento.Text))
            {
                MessageBox.Show("O ano do ultimo aniversário é " +
                    " Deve ser Superior ao ano do nascimento", "ATENÇÃO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == String.Empty ||
                txt_nascimento.Text == String.Empty ||
                txt_Ultimo.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados " +
                    "Solicitados devem ser informados", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                int idade =
                    Convert.ToInt32(txt_Ultimo.Text) -
                    Convert.ToInt32(txt_nascimento.Text);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto !";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoria.Text = " Infantil B";
                }
                else if (idade >= 5)
                {
                    lblCategoria.Text = " Infantil A";
                }
                else
                {
                    lblCategoria.Text = "Não Existe categoria";
                }
            }


        }
    }
}