using Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration
{
    public class UsuarioBLL
    {
        public AcessoHelper db = new AcessoHelper();

        public void CadastraUsuario(string nome, string email, string senha)
        {
            try
            {
                string sql = "Insert into Usuarios(Nome, Email, Senha) values (@nome,@email,@senha)";
                db.AddParameter("@nome", nome);
                db.AddParameter("@email", email);
                db.AddParameter("@nome", senha);
                db.ExecuteNonQuery(sql);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void AlterarUsuario(string nome, string email, string senha, int usuarioId)
        {
            try
            {
                string sql = "update Usuarios set Nome = @nome, Email = @email , senha = @senha where UsuarioId = @usuarioID";
                db.AddParameter("@nome", nome);
                db.AddParameter("@email", email);
                db.AddParameter("@senha", senha);
                db.AddParameter("@usuarioId", usuarioId);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ExcluirUsuario(int usuarioId)
        {
            try
            {
                string sql = "Delete from Usuarios where UsuarioId = @usuarioId";
                db.AddParameter("@usuarioid ", usuarioId);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DbDataReader Procurar(int usuarioId)
        {
            try
            {
                string sql = "Select * from Usuarios Where UsuarioID =@usuarioId";
                db.AddParameter("@usuarioId", usuarioId);
                return db.ExecuteReader(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool ProcurarPorNome(string nome)
        {
            DbDataReader dr = null;
            try
            {
                string sql = "Select * from Usuarios Where Nome = @nome";
                db.AddParameter("@nome", nome);
                dr = db.ExecuteReader(sql);
                if (dr.HasRows)

                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DbDataReader Selecionar ()
        {
            try
            {
                string sql = "Select * from Usuarios";
                return db.ExecuteReader(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string GerarHashSenha(object texto)
        {
            return db.GerarHash(texto.ToString());
        }
    }
}
