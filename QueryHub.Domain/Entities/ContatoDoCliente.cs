using QueryHub.Domain.Entities.Base;
using System;

namespace QueryHub.Domain.Entities
{
    public class ContatoDoCliente : EntityBase
    {
        public Cliente Cliente { get; private set; }
        public String Telefone { get; private set; }
        public String NomeDoContato { get; private set; }

        public ContatoDoCliente(Cliente Cliente, String Telefone, String NomeDoContato)
        {
            this.Cliente = Cliente;
            this.Telefone = Telefone;
            this.NomeDoContato = NomeDoContato;

            Validation();
        }

        protected override void Validation()
        {
            if (Cliente == null)
            {
                throw new ArgumentNullException("Cliente");
            }

            if (String.IsNullOrEmpty(Telefone))
            {
                throw new ArgumentNullException("Telefone");
            }

            if (String.IsNullOrEmpty(NomeDoContato))
            {
                throw new ArgumentNullException("NomeDoContato");
            }
        }
    }
}
