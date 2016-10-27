using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class OrgaoResponsavel
    {
        private int id;
        private string nome;
        private string contato;
        private string email;
        private Cidade city;
        private Notificacao not;

        //Construtor da Classe
        public OrgaoResponsavel(int id, string nome, string email, Cidade city, Notificacao not)
        {
            this.id = id;
            this.nome = nome;
            contato = null;
            this.email = email;
            this.city = city;
            this.not = not;
        }

        public OrgaoResponsavel(int id, string nome, string contato, string email, Cidade city, Notificacao not)
        {
            this.id = id;
            this.nome = nome;
            this.contato = contato;
            this.email = email;
            this.city = city;
            this.not = not;
        }

        //Métodos de Acesso
        public int Id { get; }
        public string Nome { get; }
        public string Contato { get; }
        public string Email { get; }
        public Cidade City { get; }
        public Notificacao Not { get; }
    }
}
