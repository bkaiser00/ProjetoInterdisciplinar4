using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Coordenada
    {
        private int id;
        private string latitude;
        private string longitude;

        //Contrutor das Casses
        public Coordenada(int id, string latitude, string longitude)
        {
            this.id = id;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Latitude { get; }
        public string Longitude { get; }
    }
}
