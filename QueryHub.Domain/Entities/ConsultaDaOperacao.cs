using QueryHub.Domain.Interfaces;
using System;

namespace QueryHub.Domain.Entities
{
    public class ConsultaDaOperacao : IValidation
    {
        public Guid Identificador { get; private set; }
        public Operacao Operacao { get; private set; }
        public Consulta Consulta { get; private set; }

        public ConsultaDaOperacao(Operacao operacao, Consulta consulta)
        {
            Identificador = Guid.NewGuid();
            Operacao = operacao;
            Consulta = consulta;
        }

        public void Validation()
        {
            if (Operacao == null)
            {
                throw new ArgumentNullException("Operacao");
            }

            if (Consulta == null)
            {
                throw new ArgumentNullException("Consulta");
            }
        }
    }
}
