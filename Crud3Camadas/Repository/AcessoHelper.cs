using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AcessoHelper : IDisposable
    {
        private DbConnection objConnection;
        private DbCommand objCommand;
        private DbProviderFactory objFactory = null;

        public enum ConnectionState
        {
            MantemConexaoAberta,
            FechaConexaoAoSair
        }

        public AcessoHelper()
        {
            objFactory = SqlClientFactory.Instance;
            objConnection = objFactory.CreateConnection();
            objCommand = objFactory.CreateCommand();
            objConnection.ConnectionString = GetStringConnection();
            objCommand.Connection = objConnection;
        }

        public void Dispose()
        {
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();
        }

        public string GetStringConnection()
        {
            string strConexao = @"Data Source = DESKTOP-FB8AL36\SQLEXPRESS; Initial Catalog = TutoriasCruds; Integrated Security = True";

            return strConexao;
        }


        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }
        public int ExecuteNonQuery(string query, CommandType commandType)
        {
            return ExecuteNonQuery(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }
        public int ExecuteNonQuery(string query, ConnectionState connectionState)
        {
            return ExecuteNonQuery(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }


        public int ExecuteNonQuery(string query, CommandType commandType, ConnectionState connectionState)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandType;

            int i = -1;
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                {
                    objConnection.Open();
                    i = objCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objCommand.Parameters.Clear();
                if (connectionState == ConnectionState.FechaConexaoAoSair)
                    objConnection.Close();
            }
            return i;


        }

        public DbDataReader ExecuteReader(string query)
        {
            return ExecuteReader(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }
        public DbDataReader ExecuteReader(string query, CommandType commandType)
        {
            return ExecuteReader(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }
        public DbDataReader ExecuteReader(string query, ConnectionState connectionState)
        {
            return ExecuteReader(query, CommandType.Text, ConnectionState.FechaConexaoAoSair);
        }
        public DbDataReader ExecuteReader(string query, CommandType commandType, ConnectionState connectionState)
        {
            objCommand.CommandText = query;
            objCommand.CommandType = commandType;
            DbDataReader reader = null;
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                    objConnection.Open();
                if (connectionState == ConnectionState.FechaConexaoAoSair)
                    reader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
                else
                    reader = objCommand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objCommand.Parameters.Clear();
            }

            return reader;
        }

        public int AddParameter(string name , object value)
        {
            DbParameter p = objFactory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return objCommand.Parameters.Add(p);
        }
        public int AddParameter(DbParameter dbParameter)
        {
            return objCommand.Parameters.Add(dbParameter);
        }

        public string GerarHash(string valor)
        {
            System.Security.Cryptography.SHA1Managed Sha = new System.Security.Cryptography.SHA1Managed();
            Sha.ComputeHash(System.Text.Encoding.Default.GetBytes(valor));
            return Convert.ToBase64String(Sha.Hash);
        }
    }
}
