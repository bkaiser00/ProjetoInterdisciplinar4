using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Localizacao
    {
        private int id;
        private string bairro;
        private string rua;
        private Cidade city;
        private Coordenada coord;

        //Construtores da Classe;
        public Localizacao(int id, Cidade city, Coordenada coord)
        {
            this.id = id;
            bairro = rua = null;
            this.city = city;
            this.coord = coord;
        }

        public Localizacao(int id, string bairro, Cidade city, Coordenada coord )
        {
            this.id = id;
            this.bairro = bairro;
            rua = null;
            this.city = city;
            this.coord = coord;
        }

        public Localizacao(int id, string bairro, string rua, Cidade city, Coordenada coord)
        {
            this.id = id;
            this.bairro = bairro;
            this.rua = rua;
            this.city = city;
            this.coord = coord;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Bairro { get; }
        public string Rua { get; }
        public Cidade City { get; }
        public Coordenada Coord { get; }
    }
}
