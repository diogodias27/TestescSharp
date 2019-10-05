using Administration;
using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace Crud3Camadas
{
    public partial class Form1 : Form
    {
        UsuarioBLL acc = new UsuarioBLL();
        int codigo = 0;
        string senhaAtual = "";
        string NomeAtual = "";

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lvUsuario.View = View.Details; ;
                lvUsuario.FullRowSelect = true;
                lvUsuario.GridLines = true;
                PreencheListView(ref lvUsuario);
                AlternarCoresDeFundo(lvUsuario, Color.AliceBlue, Color.LightGreen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void AlternarCoresDeFundo(ListView lvUsuario, Color aliceBlue, Color lightGreen)
        {
            foreach (ListView item in lvUsuario.Items)
            {
                if ((item.TabIndex % 2) == 0)
                    item.BackColor = aliceBlue;
                else
                    item.BackColor = lightGreen;
            }
        }


        private void PreencheListView(ref ListView lvUsuario)
        {
            ColumnHeader columnHeader;
            ListViewItem listViewItem;

            DbDataReader dados = acc.Selecionar();
            short shtcntr;
            int incremento = 0;

            lvUsuario.Clear();
            for (shtcntr = 0; shtcntr <= dados.FieldCount - 1; shtcntr++)
            {
                columnHeader = new ColumnHeader();
                columnHeader.Text = dados.GetName(shtcntr);
                lvUsuario.Columns.Add(columnHeader.Text, 65 + incremento, HorizontalAlignment.Left);
                incremento = incremento + 40;
            }
            while (dados.Read())
            {
                listViewItem = new ListViewItem();
                listViewItem.Text = dados[0].ToString();

                for (shtcntr = 1; shtcntr <= dados.FieldCount - 1; shtcntr++)
                {
                    if (dados.IsDBNull(shtcntr))
                    {
                        listViewItem.SubItems.Add("");
                    }
                    else
                    {
                        listViewItem.SubItems.Add(dados.GetString(shtcntr));
                    }
                    lvUsuario.Items.Add(listViewItem);
                }
                dados.Close();
            }
        }

        private void lvUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                if (lvUsuario.SelectedItems.Count > 0)
                {
                    codigo = Convert.ToInt32(lvUsuario.Items[lvUsuario.SelectedIndices[0]].Text);

                    NomeAtual = lvUsuario.SelectedItems[0].SubItems[1].Text;
                    senhaAtual = lvUsuario.SelectedItems[0].SubItems[2].Text;

                    PreencheControles(acc.Procurar(codigo));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PreencheControles(DbDataReader dbDataReader)
        {
            DbDataReader dados = acc.Selecionar();
            try
            {
                while (dados.Read())
                {


                    txtId.Text = dados["usuarioId"].ToString();
                    txtNome.Text = dados["nome"].ToString();
                    txtSenha.Text = dados["senha"].ToString();
                    txtEmail.Text = dados["email"].ToString();
                    senhaAtual = dados["senha"].ToString();
                }
                dados.Close();
            }

            catch (Exception)
            {

                throw;
            }
        }

        private bool ValidaDados()
        {
            if (txtNome.Text == string.Empty | txtSenha.Text == string.Empty | txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Dados incompletos/ invalidos...");
                txtNome.Focus();
                return false;
            }
            else if (txtSenha.TextLength < 6)
            {
                MessageBox.Show("A senha deve ter no minimo 6 caracteres...");
                txtSenha.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaDados())
                {
                    if (acc.ProcurarPorNome(txtNome.Text))
                    {
                        MessageBox.Show("Já existe usuariuo cadastrado com este Login", "Login já Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                        return;
                    }
                    acc.CadastraUsuario(txtNome.Text, txtEmail.Text, acc.GerarHashSenha(txtSenha.Text));
                    MessageBox.Show("Usuario incluido com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PreencheListView(ref lvUsuario);
                    AlternarCoresDeFundo(lvUsuario, Color.Aqua, Color.LightGreen);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidaDados())
                {
                    int codigo = Convert.ToInt32(txtId.Text);
                    if(!NomeAtual.Equals(txtNome.Text))
                    {
                        if(acc.ProcurarPorNome(txtNome.Text))
                        {
                            MessageBox.Show("Já existe usuario com este login. Tente outro nome para Login", "Login já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Focus();
                            return;
                        }
                    }
                    if (senhaAtual.Equals(txtSenha.Text))
                        acc.AlterarUsuario(txtNome.Text, txtEmail.Text, acc.GerarHashSenha(txtSenha.Text), codigo);
                    MessageBox.Show("Usuario atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    PreencheListView(ref lvUsuario);
                    AlternarCoresDeFundo(lvUsuario, Color.Aqua, Color.LightGreen);
                }
            }
            catch (Exception ex)
            {

             MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Comfirma exclusão deste usuario?", "Comfirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtId.Text);
                    acc.ExcluirUsuario(codigo);
                    MessageBox.Show("Usuario excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PreencheListView(ref lvUsuario);
                    AlternarCoresDeFundo(lvUsuario, Color.Aqua, Color.LightGreen);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao excluir o usuario" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls )
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtNome.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja encerrar o programa", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
