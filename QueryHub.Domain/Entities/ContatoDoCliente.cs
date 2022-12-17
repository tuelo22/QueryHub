using QueryHub.Domain.Interfaces;
using System;

namespace QueryHub.Domain.Entities
{
    public class ContatoDoCliente : IValidation
    {
        public Guid Identificador { get; private set; } 
        public Cliente Cliente { get; private set; }
        public String Telefone { get; private set; }
        public String NomeDoContato { get; private set; }

        public ContatoDoCliente(Cliente cliente, String telefone, String nomeDoContato)
        {
            Identificador = Guid.NewGuid();
            Cliente = Cliente;
            Telefone = Telefone;
            NomeDoContato = NomeDoContato;

            Validation();
        }

        public void Validation()
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
