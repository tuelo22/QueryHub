using QueryHub.Domain.Interfaces;
using QueryHub.Domain.ValueObjects;
using System;

namespace QueryHub.Domain.Entities
{
    public class Consulta : IValidation 
    {
        public Guid Identificador { get; private set; } 
        public Fornecedor Fornecedor { get; private set; }
        public Credencial Credencial { get; private set; }
        public Contrato Contrato { get; set; }
        public PlanoDeTarifacao PlanoDeTarifacao { get; set; }

        public Consulta(Fornecedor fornecedor, Credencial credencial, Contrato contrato, PlanoDeTarifacao planoDeTarifacao)
        {
            Identificador = Guid.NewGuid();
            Fornecedor = fornecedor;
            Credencial = credencial;
            Contrato = contrato;
            PlanoDeTarifacao = planoDeTarifacao;

            Validation();
        }

        public void Validation()
        {
            if (Fornecedor == null)
            {
                throw new ArgumentNullException("Fornecedor");
            }

            if (Credencial == null)
            {
                throw new ArgumentNullException("Credencial");
            }

            if (Contrato == null)
            {
                throw new ArgumentNullException("Contrato");
            }

            if (PlanoDeTarifacao == null)
            {
                throw new ArgumentNullException("PlanoDeTarifacao");
            }
        }
    }
}
