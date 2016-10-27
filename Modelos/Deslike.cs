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
        public Deslike(int id, Usuario user)
        {
            this.id = id;
            this.user = user;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Path_img { get; }
    }
}
