using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CriarBD
{
    public partial class frmCriarBanco : Form
    {
        public frmCriarBanco()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este código que sincroniza os objetos
            //Ao selecionar um drive, a lista de diretórios
            //Será atualizada automaticamente de acordo com os BD´s
            Dir.Path = Drive.SelectedItem.ToString();
        }
    }
}
