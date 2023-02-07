using FitnessNBNG_Database.Dominios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessNBNG_Database.Interfaces_e_Repositorios
{
    public class RepositorioUtilizador : IRepositorioUtilizador
    {
        private const string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gabriel.sanchez\\Downloads\\FitnessNBNG\\FitnessNBNG_Database\\BaseDados\\BaseDeDados.mdf;Integrated Security=True";

        public bool AutenticarUtilizador(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void EliminarUtilizador(int utilizadorId)
        {
            throw new NotImplementedException();
        }

        public Utilizador[] ObterTodosUtilizadores()
        {
            throw new NotImplementedException();
        }

        public int ObterTotalDeUtilizadores()
        {
            throw new NotImplementedException();
        }

        bool IRepositorioUtilizador.AdicionarUtilizador(Utilizador utilizador)
        {
            var novoUsuarioAdicionado = false;

            using (SqlConnection conn = new SqlConnection((conexao))
            {
            

            }
        }

        void IRepositorioUtilizador.AtualizarUtilizador(Utilizador utilizador)
        {
            throw new NotImplementedException();
        }

        Utilizador IRepositorioUtilizador.ObterPorLogin(int login)
        {
            throw new NotImplementedException();
        }


    }

}
