using QueryHub.Domain.Interfaces;
using QueryHub.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Entities
{
    public class PlanoDeTarifacao : IValidation
    {
        public Guid Identificador { get; private set; } 
        public Double Valor { get; private set; }
        public Vigencia Vigencia { get; private set; }
        public IList<Consulta> Consultas { get; private set; }

        public PlanoDeTarifacao(double valor, Vigencia vigencia)
        {
            Identificador = Guid.NewGuid();
            Consultas = new List<Consulta>();
            Valor = valor;
            Vigencia = vigencia;

            Validation();
        }

        public void Validation()
        {
            if (Valor <= 0)
            {
                throw new ArgumentNullException("Valor");
            }

            if (Vigencia == null)
            {
                throw new ArgumentNullException("Vigencia");
            }
        }
    }
}
