using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Deslike
    {
        private int id;
        private Usuario user;
        private Postagem post;

        //Construtores
        public Deslike(int id, Usuario user, Postagem post)
        {
            this.id = id;
            this.user = user;
            this.post = post;
        }

        //Métodos de Acesso
        public int Id { get; }
        public Usuario User { get; }
        public Postagem Post { get; }
    }
}
