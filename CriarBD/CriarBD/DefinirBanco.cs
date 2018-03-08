using System;
using System.Text;
using System.Windows.Forms;
using db = System.Data.OleDb;

namespace CriarBD
{
    //definição de um campo
    public struct DefCampo 
    { 
        public string Nome;
        public string Tipo;
        public bool Null;

        public DefCampo(string Nome, string Tipo, bool Null)
        {
            this.Nome = Nome;
            this.Tipo = Tipo;
            this.Null = Null;
        }
    }
    class DefinirBanco
        {
        //armazena a string coxeao com o banco
        public string StringConexao;

        public virtual bool CriarDatabase()
        { 
            //aqui ocorre a interação com o codigo legado
            //ou seja código não gerenciado
            ADOX.Catalog Banco = new ADOX.Catalog();

            //neste metodo optamos por deixar o tratamento
            //da exceção por quem disparou a ação 
            Banco.Create(StringConexao);
            return true;
        }
        //Criar fisicamente a tabela 
        public virtual bool CriarTabela(string NomeTabela, DefCampo[] Campos)
        { 
            /*preferimos usar um stringBuilder neste metodo 
             devido as intensas modificações até chegar á string final */
            StringBuilder ComandoSQL = new
            StringBuilder("CREATE TABLE" + NomeTabela + "(", 2048);

            /*loop para reunir as tebelas  definiçoes de campos para compor 
             * uma tabela e create table adequado*/
            foreach (DefCampo Campo in Campos)
            { 
                ComandoSQL.Append(Campo.Nome + "" + Campo.Tipo);
                if (Campo.Null)
                    ComandoSQL.Append(" NULL, ");
                else
                    ComandoSQL.Append(" NOT NULL, ");

            }
            //Remove a última virgula e espaço que sobraram
            ComandoSQL.Remove(ComandoSQL.Length - 2, 2);
            
            //fecha parenteses 
            ComandoSQL.Append(")");

            //executa a tabela 
            ExecutarComando( ComandoSQL.ToString( ) );
            return true;
        }
        // executar uma sentença sql no banco
        public virtual bool ExecutarComando(string ComandoSQL)
        { 
            //aqui estamos usando ado.net
            db.OleDbConnection co = new db.OleDbConnection(StringConexao);
            db.OleDbCommand cmd = new db.OleDbCommand(ComandoSQL, co);

            //neste metodo, optamos por tratamento de excecoes in-loco 
            try
            {
                co.Open();
                cmd.ExecuteNonQuery();
                co.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
