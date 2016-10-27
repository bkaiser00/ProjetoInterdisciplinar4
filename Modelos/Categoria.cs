using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Categoria
    {
        private int id;
        private string tipo;

        //Construtor da Classe
        public Categoria(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Tipo { get; }
    }
}
