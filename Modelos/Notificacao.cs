using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Notificacao
    {
        private int id;
        private Imagem imagem;
        private Localizacao locate;
        private OrgaoResponsavel orgao;
        private string cat;

        //Construtores
        public Notificacao(int id, Imagem imagem, Localizacao locate, OrgaoResponsavel orgao, string cat)
        {
            this.id = id;
            this.imagem = imagem;
            this.locate = locate;
            this.orgao = orgao;
            this.cat = cat;
        }

        //Métodos de Acesso
        public int Id { get; }
        public Imagem Imagem { get; }
        public Localizacao Locate { get; }
        public OrgaoResponsavel Orgao { get; }
        public string Cat { get; }
    }
}
