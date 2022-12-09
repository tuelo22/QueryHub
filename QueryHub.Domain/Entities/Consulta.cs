using QueryHub.Domain.Entities.Base;
using QueryHub.Domain.ValueObjects;
using System;

namespace QueryHub.Domain.Entities
{
    public class Consulta : EntityBase
    {
        public String Fornecedor { get; private set; }
        public String Serviço { get; private set; }
        public Credencial Credencial { get; private set; }

        public Consulta(string fornecedor, string serviço, Credencial credencial)
        {
            Fornecedor = fornecedor;
            Serviço = serviço;
            Credencial = credencial;
        }

        protected override void Validation()
        {
            if (String.IsNullOrEmpty(Fornecedor))
            {
                throw new ArgumentNullException("Fornecedor");
            }

            if (String.IsNullOrEmpty(Serviço))
            {
                throw new ArgumentNullException("Serviço");
            }

            if (Credencial == null)
            {
                throw new ArgumentNullException("Credencial");
            }
        }
    }
}
