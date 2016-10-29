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
        DB banco = new DB();

        /* Os selects são criados com ExecuteReader, semelhante o metodo ProjectCol da classe conexao.
         * Esse metodo retorna apenas uma coluna, para retornar mais de uma coluna é necessario criar
         * um método com select personalizado e inserir as colunas manualmente. 
         * 
         * Os métodos criados a baixo são os da assinatura da interface. São métodos basicos para toda
         * classe DAO. Ao criar uma classe DAO basta copiar, colar e alterar o nome da tabela.
         */

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
