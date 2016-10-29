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
            DB conexao = new DB("localhost:1521:xe", "system", "123456");
            Console.WriteLine(conexao.Conn());
            Console.WriteLine(conexao.Query("select sysdate from dual"));

            Console.ReadKey();
        }
    }
}

