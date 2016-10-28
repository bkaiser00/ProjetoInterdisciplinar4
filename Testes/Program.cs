using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexao conexao = new Conexao("Data Source=localhost:1521:xe;Persist Security Info=True;User ID=system;Password=12345");
            Console.WriteLine(conexao.Conn());
            Console.WriteLine(conexao.Query("select sysdate from dual"));

            Console.ReadKey();
        }
    }
}
