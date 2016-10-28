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
        public string Conn()
        {
            OracleCommand oComando = new OracleCommand();
            oComando.Connection = new OracleConnection("Data Source=localhost:1521:xe;Persist Security Info=True;User ID=system;Password=123456");
            oComando.CommandText = "select sysdate from dual";
            oComando.CommandType = System.Data.CommandType.Text;
            oComando.Connection.Open();
            return oComando.ExecuteScalar().ToString();
        }
    }
}
