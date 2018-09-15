using System;
using System.Windows.Forms;

namespace ProjectEuller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tres = 0;
            int cinco = 0;
            int verificacao = 0;

            for (verificacao = 1; verificacao < 1000; verificacao++)
            {
                listBox1.Items.Add(verificacao);

                if (verificacao % 3 == 0)
                {
                    tres += verificacao;
                }
                if (verificacao % 5 == 0)
                {
                    cinco += verificacao;
                }
            }
            int resultado = tres + cinco;

            listBox1.Items.Add(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong primeiroTermo = 0;
            ulong segundoTermo = 1;
            ulong controle = 0;
            ulong somaPares = 0;
            for (ulong i = 0; i < 4000000; i++)
            {

                controle = primeiroTermo + segundoTermo;
                primeiroTermo = segundoTermo;

                listBox1.Items.Add(controle);

                segundoTermo = controle;

                if (controle % 2 == 0)
                {

                    somaPares += controle;
                }

            }

            listBox1.Items.Add(somaPares);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
