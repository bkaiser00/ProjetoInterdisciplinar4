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
        private int deslike;
        private Imagem img;
        private Categoria cat;
        private Localizacao locate;
        //Não coloquei usuário, pq não vi necessidade dele na classe, se for necessário acrescento depois.
        //Ver se precisa criar lista de objetos da classe comentário nessa classe

        //Construtores da Classe
        public Postagem(int id, int deslike, Imagem img, Categoria cat, Localizacao locate)
        {
            this.id = id;
            this.deslike = deslike;
            this.img = img;
            this.cat = cat;
            this.locate = locate;
        }

        //Métodos de Acesso
        public int Id { get; }
        public int Deslike { get; }
        public Imagem Img { get; }
        public Usuario User { get; }
        public Categoria Cat { get; }
        public Localizacao Locate { get; }
    }
}
