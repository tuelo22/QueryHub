using QueryHub.Domain.Interfaces;
using QueryHub.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Entities
{
    public class Usuario : IValidation
    {
        public Guid Identificador { get; private set; }
        public Cliente Cliente { get; private set; }
        public Boolean Administrador { get; private set; }
        public Credencial Credencial { get; private set; }
        public IList<Operacao> Operacoes { get; private set; }

        public Usuario(Cliente cliente, bool administrador, Credencial credencial)
        {
            Operacoes = new List<Operacao>();
            Identificador = Guid.NewGuid();
            Cliente = cliente;
            Administrador = administrador;
            Credencial = credencial;

            Validation();
        }

        public void Validation()
        {
            if (Cliente == null)
            {
                throw new ArgumentNullException("Cliente");
            }

            if (Credencial == null)
            {
                throw new ArgumentNullException("Credencial");
            }
        }
    }
}
