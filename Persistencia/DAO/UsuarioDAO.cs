using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace Persistencia
{
    public class UsuarioDAO : IManipulavel
    {
        DB banco = new DB();

        /* Os selects são criados com ExecuteReader, semelhante o metodo ProjectCol da classe conexao.
         * Esse metodo retorna apenas uma coluna, para retornar mais de uma coluna é necessario criar
         * um método com select personalizado e inserir as colunas manualmente. 
         * 
         * Os métodos criados a baixo são os da assinatura da interface. São métodos basicos para toda
         * classe DAO. Ao criar uma classe DAO basta copiar, colar e alterar o nome da tabela.
         */

        public string SelectUsuario(string atribute, string value)
        {
            string dados = string.Empty;
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "select * from usuario where " + atribute + " = " + value;

            banco.Conn();

            try
            {
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dados = ("{0};{1};{2};{3};{4};{5}",reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetString(5);
                }
                else
                {
                    dados = "Nenhum dado encontrado!");
                }

                reader.Close();
                reader.Dispose();
                command.Dispose();

                banco.Disconnect();

                return dados;
            }
            catch
            {
                banco.Disconnect();
                return dados = "Erro ao tentar exucutar a query: \"" + command.CommandText.ToString() + "\".";
            }
        }

        public bool Delete(string condicao)
        {
            return banco.Delete("usuario" , condicao);
        }

        public bool Insert(string dados)
        {
            return banco.Insert("usuario", dados);
        }

        public bool Insert(string colunas, string dados)
        {
            return banco.Insert("usuario", colunas, dados);
        }

        public bool Update(string dados)
        {
            return banco.Update("usuario", dados);
        }

        public bool Update(string dados, string condicao)
        {
            return banco.Update("usuario", dados, condicao);
        }
    }
}
