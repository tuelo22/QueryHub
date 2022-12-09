using QueryHub.Domain.Entities.Base;
using QueryHub.Domain.ValueObjects;
using System;

namespace QueryHub.Domain.Entities
{
    public class PlanoDeTarifacao : EntityBase
    {
        public Cliente Cliente { get; set; }
        public Consulta Consulta { get; set; }
        public Double Valor { get; set; }
        public Vigencia Vigencia { get; set; }
        public Contrato Contrato { get; set; }

        public PlanoDeTarifacao(Cliente cliente, Consulta consulta, double valor, Vigencia vigencia, Contrato contrato)
        {
            Cliente = cliente;
            Consulta = consulta;
            Valor = valor;
            Vigencia = vigencia;
            Contrato = contrato;

            Validation();
        }

        protected override void Validation()
        {
            if (Cliente == null)
            {
                throw new ArgumentNullException("Cliente");
            }

            if (Consulta == null)
            {
                throw new ArgumentNullException("Consulta");
            }

            if (Valor <= 0)
            {
                throw new ArgumentNullException("Valor");
            }

            if (Vigencia == null)
            {
                throw new ArgumentNullException("Vigencia");
            }

            if (Contrato == null)
            {
                throw new ArgumentNullException("Contrato");
            }
        }
    }
}
