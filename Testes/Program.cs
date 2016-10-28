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
            Console.WriteLine(new Conexao().Conn());
            Console.ReadKey();
        }
    }
}
