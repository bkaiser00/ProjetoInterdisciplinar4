using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Cidade
    {
        private int id;
        private string nome;
        private Estado state;

        //Construtores da Classe
        public Cidade(int id, string nome, Estado state)
        {
            this.id = id;
            this.nome = nome;
            this.state = state;
        }

        public Cidade(int id, string nome, int id_state, string nome_state)
        {
            this.id = id;
            this.nome = nome;
            state = new Estado(id_state, nome_state);
        }

        //Métodos de Acesso 
        public int Id { get; }
        public string Nome{ get; }
        public Estado State { get; }
    }
}
