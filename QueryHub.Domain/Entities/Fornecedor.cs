using QueryHub.Domain.Interfaces;
using System;

namespace QueryHub.Domain.Entities
{
    public class Fornecedor : IValidation
    {
        public Guid Identificador { get; private set; }
        public String Nome { get; private set; }
        public String Descricao { get; private set; }

        public Fornecedor(string nome, string descricao)
        {
            Identificador = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;

            Validation();
        }

        public void Validation()
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new ArgumentNullException("Nome");
            }

            if (String.IsNullOrEmpty(Descricao))
            {
                throw new ArgumentNullException("Descricao");
            }
        }
    }
}
