using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPersist
    {
        bool Insert(string dados);
        bool Insert(string colunas, string dados);
        bool Update(string dados);
        bool Update(string dados, string condicao);
        bool Delete(string condicao);
    }
}
