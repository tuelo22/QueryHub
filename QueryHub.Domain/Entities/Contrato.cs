using QueryHub.Domain.Entities.Base;
using QueryHub.Domain.ValueObjects;
using System;

namespace QueryHub.Domain.Entities
{
    public class Contrato : EntityBase
    {
        public Consulta Consulta { get; private set; }
        public Double Valor { get; private set; }
        public Vigencia Vigencia { get; private set; }

        public Contrato(Consulta consulta, double valor, Vigencia vigencia)
        {
            Consulta = consulta;
            Valor = valor;
            Vigencia = vigencia;

            Validation();
        }

        protected override void Validation()
        {
            if (Consulta == null)
            {
                throw new ArgumentNullException("Consulta");
            }

            if (Valor <=0)
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
