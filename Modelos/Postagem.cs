using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Postagem
    {
        private int id;
        private Usuario user;
        private Imagem img;
        private Notificacao not;
        private Localizacao locate;
        private Deslike deslike;
        //Não coloquei usuário, pq não vi necessidade dele na classe, se for necessário acrescento depois.
        //Ver se precisa criar lista de objetos da classe comentário nessa classe

        //Construtores da Classe
        public Postagem(int id, Deslike deslike, Imagem img, Notificacao not, Localizacao locate)
        {
            this.id = id;
            this.deslike = deslike;
            this.img = img;
            this.not = not;
            this.locate = locate;
        }

        //Métodos de Acesso
        public int Id { get; }
        public int Deslike { get; }
        public Imagem Img { get; }
        public Usuario User { get; }
        public Notificacao Not { get; }
        public Localizacao Locate { get; }
        public Deslike Deslike { get; }
    }
}
