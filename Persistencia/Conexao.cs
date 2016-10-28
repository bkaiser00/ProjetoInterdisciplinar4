using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Conexao
    {
        string connectionString;
        OracleConnection conn;
        OracleCommand command;

        public Conexao(string connectionString)
        {
            this.connectionString = connectionString;
            conn = new OracleConnection();
            command = new OracleCommand();
        }

        public string Conn()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                return "Conexão Estabelecida com sucesso!";
            }
            catch
            {
                return "Erro ao tentar estaber conexão.";
            }
        }

        public string Query(string query)
        {
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = query;
                return command.ExecuteScalar().ToString();
            }
            catch
            {
                return "Erro ao tentar exucutar a query: \""+ query + "\".";
            }
        }
    }
}
