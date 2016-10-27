using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Usuario
    {
        private int id;
        private string login;
        private string senha;
        private string nome;
        private string sobrenome;
        private string email;

        //Contrutor(es) da Classe.
        public Usuario(int id, string login, string senha, string nome, string sobrenome, string email)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
        }

        //Métodos de Acesso
        //Utilizei apenas Get, pois as alterações serão limitadas a alguns métodos.
        public int Id { get; }
        public string Login { get; }
        public string Senha { get; }
        public string Nome { get; }
        public string Sobrenome { get; }
        public string Email { get; }
    }
}
