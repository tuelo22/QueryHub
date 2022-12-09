using QueryHub.Domain.ValueObjects.Base;
using System;

namespace QueryHub.Domain.ValueObjects
{
    public class Credencial : ValueObjectsBase
    {
        public String Login { get; private set; }
        public String Senha { get; private set; }

        public Credencial(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        protected override void Validation()
        {
            if (String.IsNullOrEmpty(Login))
            {
                throw new ArgumentNullException("Login");
            }

            if (String.IsNullOrEmpty(Senha))
            {
                throw new ArgumentNullException("Senha");
            }
        }
    }
}
