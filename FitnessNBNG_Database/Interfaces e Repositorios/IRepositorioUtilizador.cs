using FitnessNBNG_Database.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessNBNG_Database.Interfaces_e_Repositorios
{
    public interface IRepositorioUtilizador
    {
        int ObterTotalDeUtilizadores();

        Utilizador AdicionarUtilizador(Utilizador utilizador);

        void AtualizarUtilizador(Utilizador utilizador);

        void EliminarUtilizador(int utilizadorId);

        Utilizador[] ObterTodosUtilizadores();

        Utilizador ObterPorLogin(int login);

        bool AutenticarUtilizador(string login, string password);
    }
}
