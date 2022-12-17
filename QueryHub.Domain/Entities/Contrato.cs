using QueryHub.Domain.Interfaces;
using QueryHub.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Entities
{
    public class Contrato : IValidation
    {
        public Guid Identificador { get; private set; }
        public Double Valor { get; private set; }
        public Vigencia Vigencia { get; private set; }
        public IList<Consulta> Consultas { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Contrato(double valor, Vigencia vigencia, Fornecedor fornecedor)
        {
            Consultas = new List<Consulta>();
            Identificador = Guid.NewGuid();            
            Valor = valor;
            Vigencia = vigencia;
            Fornecedor = fornecedor;

            Validation();
        }

        public void Validation()
        {
            if (Valor <=0)
            {
                throw new ArgumentNullException("Valor");
            }

            if (Vigencia == null)
            {
                throw new ArgumentNullException("Vigencia");
            }

            if (Fornecedor == null)
            {
                throw new ArgumentNullException("Fornecedor");
            }
        }
    }
}
