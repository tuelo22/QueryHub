using QueryHub.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Entities
{
    public class Cliente : IValidation
    {
        public Guid Identificador { get; private set; }
        public String Nome { get; private set; }
        public String CNPJ { get; private set; }
        public IList<ContatoDoCliente> Contatos { get; private set; }
        public IList<Usuario> Usuarios { get; private set; }

        public Cliente(String nome, String cNPJ)
        {
            Identificador = Guid.NewGuid();
            Contatos = new List<ContatoDoCliente>();
            Usuarios = new List<Usuario>();

            this.Nome = nome;
            this.CNPJ = cNPJ;

            Validation();
        }

        public void Validation()
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new ArgumentNullException("Nome");
            }

            if (String.IsNullOrEmpty(CNPJ))
            {
                throw new ArgumentNullException("CNPJ");
            }
        }
    }
}
