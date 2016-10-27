using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Comentario
    {
        //não acrescentei objeto postagem
        private int id;
        private string comment;
        private DateTime data;

        //Construtores da classe
        public Comentario(int id, string comment)
        {
            this.id = id;
            this.comment = comment;
        }

        public Comentario(int id, string comment, DateTime data)
        {
            this.id = id;
            this.comment = comment;
            this.data = data;
        }

        //Métodos de acesso
        public int Id { get; }
        public string Comment { get; }
        public DateTime Data { get; }
    }
}
