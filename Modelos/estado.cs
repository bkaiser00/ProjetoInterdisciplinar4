using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Estado
    {
        private int id;
        private string nome;

        //Construtor da Classe
        public Estado(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        //Metódos de Acesso (Get)
        public int Id { get; }
        public string Nome { get; }
    }
}
