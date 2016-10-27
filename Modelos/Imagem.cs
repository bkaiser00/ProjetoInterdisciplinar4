using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Imagem
    {
        private int id;
        private string path_img;

        //Construtores
        public Imagem(int id, string path_img)
        {
            this.id = id;
            this.path_img = path_img;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Path_img { get; }
    }
}
