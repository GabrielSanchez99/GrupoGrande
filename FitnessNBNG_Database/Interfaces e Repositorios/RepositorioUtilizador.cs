using FitnessNBNG_Database.Dominios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace FitnessNBNG_Database.Interfaces_e_Repositorios
{
    public class RepositorioUtilizador : IRepositorioUtilizador
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        private object sqlCommand;
        static private readonly String connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectDirectory}\FitnessDatabase.mdf;Integrated Security=True";

        #region SQL
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

        Utilizador AdicionarUtilizador(Utilizador utilizador)
        {
            bool novoUsuarioAdicionado = false;

            string query = @"INSERT INTO utilizador (Nome, Login, Senha, Email, DataCriacao)
            VALUES (@nome, @login, @senha, @email ,@dataCriacao )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("@nome", utilizador.Nome));
                sqlCommand.Parameters.Add(new SqlParameter("@login", utilizador.Login));
                sqlCommand.Parameters.Add(new SqlParameter("@email", utilizador.Email));
                sqlCommand.Parameters.Add(new SqlParameter("@senha", utilizador.Password));
                sqlCommand.Parameters.Add(new SqlParameter("@dataCriacao", DateTime.Now));

                if (sqlCommand.ExecuteNonQuery() != 1)
                {
                    throw new InvalidProgramException("Repositorio utilizador erro ao inserir.");
                }
            }

            return utilizador;
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
