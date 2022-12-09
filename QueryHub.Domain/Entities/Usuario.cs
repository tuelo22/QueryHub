using QueryHub.Domain.Entities.Base;
using QueryHub.Domain.ValueObjects;
using System;

namespace QueryHub.Domain.Entities
{
    public class Usuario: EntityBase
    {
        public Cliente Cliente { get; private set; }
        public Boolean Administrador { get; private set; }
        public Credencial Credencial { get; private set; }

        public Usuario(Cliente cliente, bool administrador, Credencial credencial)
        {
            Cliente = cliente;
            Administrador = administrador;
            Credencial = credencial;

            Validation();
        }

        protected override void Validation()
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
