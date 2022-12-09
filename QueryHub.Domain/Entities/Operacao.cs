using QueryHub.Domain.Entities.Base;
using System;

namespace QueryHub.Domain.Entities
{
    public class Operacao : EntityBase
    {
        public Usuario Usuario { get; private set; }
        public String Descricao { get; private set; }
        public DateTime? Date { get; private set; }
        public PlanoDeTarifacao PlanoDeTarifacao { get; private set; }

        public Operacao(Usuario usuario, string descricao, DateTime? date, PlanoDeTarifacao planoDeTarifacao)
        {
            Usuario = usuario;
            Descricao = descricao;
            Date = date;
            PlanoDeTarifacao = planoDeTarifacao;

            Validation();
        }

        protected override void Validation()
        {
            if (Usuario == null)
            {
                throw new ArgumentNullException("Usuario");
            }

            if (String.IsNullOrEmpty(Descricao))
            {
                throw new ArgumentNullException("Descricao");
            }

            if (Date == null || Date == DateTime.MinValue)
            {
                throw new ArgumentNullException("Date");
            }

            if (PlanoDeTarifacao == null)
            {
                throw new ArgumentNullException("PlanoDeTarifacao");
            }
        }
    }
}
