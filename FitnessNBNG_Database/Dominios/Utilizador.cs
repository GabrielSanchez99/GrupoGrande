using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessNBNG_Database.Dominios
{
    public class Utilizador
    {
        private TextBox txtLogin;
        private TextBox txtSenha;

        //Variáveis
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Login { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime DataCriacao { get; private set; }


        public Utilizador()
        {
        }

        public Utilizador(int id, string nome, string login, string email, string password, DateTime? dataCriacao)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Email = email;
            Password = password;
            DataCriacao = dataCriacao ?? DateTime.Now;
        }

        public Utilizador(TextBox txtLogin, TextBox txtSenha)
        {
            this.txtLogin = txtLogin;
            this.txtSenha = txtSenha;
        }
    }
}
