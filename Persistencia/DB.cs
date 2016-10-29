using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Persistencia 
{
    public class DB : IConectavel
    {
        private string connectionString;
        private OracleConnection conn;
        
        //Construtores da classe
        public DB()
        {
            connectionString = "Data Source=localhost:1521:xe;Persist Security Info=True;User ID=user_owner;Password=123456";
            conn = new OracleConnection();
        }

        public DB(string connectionString)
        {
            this.connectionString = connectionString;
            conn = new OracleConnection();
        }

        public DB(string dataSource, string user, string password) 
        {
            this.connectionString = "Data Source=" + dataSource + ";Persist Security Info=True;User ID="+user+";Password="+password;
            conn = new OracleConnection();
        }

        /// <summary>
        /// Criar uma coneção com o banco criado.
        /// </summary>
        /// <returns> Uma string informando se a conexão foi se a conexão foi bem sucedida.</returns>
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

        /// <summary>
        /// Desfaz a conexão com o banco de dados.
        /// </summary>
        /// <returns>Uma string de confirmação.</returns>
        public string Disconnect()
        {
            conn.Close();
            conn.Dispose();
            return "Desconectado!";
        }

        /// <summary>
        /// Executa um comando de persistencia no banco de dados.
        /// </summary>
        /// <param name="query"> Comando a ser executado. </param>
        /// <returns> Retorna uma string com o dado da primeira celular da query executada.</returns>
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

        /// <summary>
        /// Projeta a primeira coluna de uma entidade.
        /// </summary>
        /// <param name="query">Query utilizada para persistir os dados no banco.</param>
        /// <returns>Uma lista com os dados persistidos.</returns>
        public List<string> Select(string query)
        {
            try{
                List<string> lista = new List<string>();
                OracleCommand command = conn.CreateCommand();
                command.CommandText = query;

                Conn();

                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0));
                    }
                }
                else
                {
                    lista.Add("Nenhum dado encontrado!");
                }

                reader.Close();
                reader.Dispose();
                command.Dispose();

                Disconnect();

                return lista;
            }
            catch
            {
                Disconnect();
                return new List<string> { "Erro ao tentar exucutar a query: \"" + query + "\"." };
            }
        }

        public bool Insert(string tabela, string dados)
        {
            try
            {
                Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "insert into " + tabela + " values (" + dados + ")";
                command.ExecuteNonQuery();
                command.Dispose();

                Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(string tabela, string colunas, string dados)
        {
            try
            {
                Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "insert into " + tabela + " (" + colunas + ") values (" + dados + ")";
                command.ExecuteNonQuery();
                command.Dispose();

                Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string tabela, string dados)
        {
            try
            {
                Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "update " + tabela + " set (" + dados + ")";
                command.ExecuteNonQuery();
                command.Dispose();

                Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string tabela, string dados, string condicao)
        {
            try
            {
                Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "update " + tabela + " set (" + dados + ") where " + condicao;
                command.ExecuteNonQuery();
                command.Dispose();

                Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string tabela, string condicao)
        {
            try
            {
                Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "delete " + tabela + " where " + condicao;
                command.ExecuteNonQuery();
                command.Dispose();

                Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
