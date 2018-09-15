using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p8
{
    public partial class Form1 : Form
    {
        class classificacao
        {

            public double minimo;
            public double maximo;
            public string classifica;
        }
        List<classificacao> LISTA_CLASSIFICACOES;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_CLASSIFICACOES = new List<classificacao>(){
            new classificacao() { minimo = 0, maximo = 4.9, classifica = "D"},
            new classificacao() { minimo = 5, maximo = 6.9, classifica = "C"},
            new classificacao() { minimo = 5, maximo = 8.9, classifica = "B"},
            new classificacao() {minimo = 9, maximo = 10 , classifica = "A"},

            
            };

        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            if (text_Exame1.Text == "" || text_Exame2.Text == "" || text_Exame3.Text == "")
                return; 
            double media = (double.Parse(text_Exame1.Text) +
                            double.Parse(text_Exame2.Text) +
                            double.Parse(text_Exame3.Text)) / 3;

            var t = LISTA_CLASSIFICACOES.Where(i => i.minimo <= media && i.maximo >= media).FirstOrDefault();
            if (t == null) return;
            label_Classificacao_final.Text = "Classificação:: " + t.classifica; 


        }
    }
}
