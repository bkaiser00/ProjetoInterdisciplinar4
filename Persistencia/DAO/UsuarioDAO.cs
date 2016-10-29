using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace Persistencia
{
    public class UsuarioDAO : IPersist
    {
        Conexao banco = new Conexao();

        /* Os selects são criados com ExecuteReader, semelhante o metodo ProjectCol da classe conexao.
         * Esse metodo retorna apenas uma coluna, para retornar mais de uma coluna é necessario criar
         * um método com select personalizado e inserir as colunas manualmente. 
         * 
         * Os métodos criados a baixo são os da assinatura da interface. São métodos basicos para toda
         * classe DAO. Ao criar uma classe DAO basta copiar, colar e alterar o nome da tabela.
         */

        public bool Insert(string dados)
        {
            banco.Conn();

            OracleCommand command = new OracleCommand();
            command.CommandText = "insert into usuario values (" + dados + ")";
            command.ExecuteNonQuery();

            command.Dispose();
            banco.Disconnect();

            return true;
        }
        public bool Insert(string colunas, string dados)
        {
            try
            {
                banco.Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "insert into usuario (" + colunas + ") values (" + dados + ")";
                command.ExecuteNonQuery();

                command.Dispose();
                banco.Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(string dados)
        {
            try
            {
                banco.Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "update usuario set (" + dados + ")";
                command.ExecuteNonQuery();

                command.Dispose();
                banco.Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(string dados, string condicao)
        {
            try
            {
                banco.Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "update usuario set (" + dados + ") where " + condicao;
                command.ExecuteNonQuery();

                command.Dispose();
                banco.Disconnect();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string condicao)
        {
            try
            {
                banco.Conn();

                OracleCommand command = new OracleCommand();
                command.CommandText = "delete usuario where " + condicao;
                command.ExecuteNonQuery();

                command.Dispose();
                banco.Disconnect();

                return true;
            }
        }
    }
}
