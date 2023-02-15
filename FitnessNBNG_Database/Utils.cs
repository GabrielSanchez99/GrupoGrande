using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessNBNG_Database
{
    public static class Utils
    {
        //Valida O Nome - N Pode Ser Vazio E Precisa De 3 Caracteres
        public static bool ValidarNome(string nome)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(nome) || nome.Trim().Length < 3)
            {
                isValid = false;
            }

            return isValid;
        }

        //Valida O Login - N Pode Ser Vazio E Precisa De 3 Caracteres
        public static bool ValidarLogin(string login)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(login) || login.Trim().Length < 3)
            {
                isValid = false;
            }

            return isValid;
        }

        //Valida O Email
        public static bool ValidarEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email); ;
        }

        //Valida A Password - N Pode Ser Vazia e Precisa de 8 Caracteres
        public static bool ValidarPassword(string password)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(password) || password.Trim().Length < 8)
            {
                isValid = false;
            }

            return isValid;
        }

        //Valida Se A Password E A Confirmação Da Password São Iguais
        public static bool ValidarConfirmacaoPassword(string password, string confirmacao)
        {
            var isValid = true;

            if (!password.Equals(confirmacao))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
