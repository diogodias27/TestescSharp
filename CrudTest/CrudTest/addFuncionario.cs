using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTest
{
    public partial class addFuncionario : Form
    {
        public addFuncionario()
        {
            InitializeComponent();

            txtName.Enabled = false;
            txtTelefone.Enabled = false;
            txtCpf.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            txtCelular.Enabled = false;
            txtConsultar.Enabled = false;
        }

        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDTestCrud;Data Source=PC-PC\\SQLEXPRESS";
        private string strSql = string.Empty;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "Insert into Tabela1Crud(Nome,Telefone,Celular,Email,Endereco,Numero,RG,CPF,Bairro) values(@Nome,@Telefone,@Celular,@Email,@Endereco,@numero,@RG,@CPF,@Bairro)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql , sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.NVarChar).Value = txtName.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.NVarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCpf.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtConsultar.Enabled = true;

            txtName.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtCelular.Clear();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtTelefone.Enabled = true;
            txtCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtRg.Enabled = true;
            txtCpf.Enabled = true;
            txtCelular.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Tabela1Crud where Nome= @consulta";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@consulta", SqlDbType.NVarChar).Value = txtConsultar.Text;

            try
            {
                if (txtConsultar.Text == string.Empty)
                {
                    MessageBox.Show("DIGITE UM NOME");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("USUARIO NÃO CADASTRADO");
                }
                dr.Read();

                txtName.Text = Convert.ToString(dr["Nome"]);
                txtTelefone.Text = Convert.ToString(dr["Telefone"]);
                txtCelular.Text = Convert.ToString(dr["Celular"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
                txtNumero.Text = Convert.ToString(dr["Numero"]);
                txtRg.Text = Convert.ToString(dr["RG"]);
                txtCpf.Text = Convert.ToString(dr["CPF"]);
                txtBairro.Text = Convert.ToString(dr["Bairro"]);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtConsultar.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update Tabela1Crud set  Nome= @nome, Telefone=@Telefone,Celular=@Celular, Email=@Email,Endereco=@endereco,Numero=@Numero , RG=@RG , CPF=@CPF, Bairro=@Bairro";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.NVarChar).Value = txtName.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.NVarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCpf.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtName.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtRg.Clear();
            txtBairro.Clear();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            strSql = "delete from Tabela1Crud where  Nome= @nome";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtName.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtName.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtRg.Clear();
            txtBairro.Clear();

        }
    }
}
