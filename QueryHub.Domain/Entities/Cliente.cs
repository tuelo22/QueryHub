using QueryHub.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public String Nome { get; private set; }
        public String CNPJ { get; private set; }
        public List<ContatoDoCliente> Contatos { get; private set; }

        public Cliente(String Nome, String CNPJ)
        {
            Contatos = new List<ContatoDoCliente>();

            this.Nome = Nome;
            this.CNPJ = CNPJ;

            Validation();
        }

        protected override void Validation()
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
