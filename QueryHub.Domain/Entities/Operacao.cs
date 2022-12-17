using QueryHub.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryHub.Domain.Entities
{
    public class Operacao : IValidation
    {
        public Guid Identificador { get; private set; } 
        public Usuario Usuario { get; private set; }
        public String Descricao { get; private set; }
        public DateTime? Date { get; private set; }
        public IList<ConsultaDaOperacao> Consultas { get; set; }

        public Operacao(Usuario usuario, string descricao, DateTime? date, IList<ConsultaDaOperacao> consultas)
        {
            Consultas = consultas;
            Identificador = Guid.NewGuid();
            Usuario = usuario;
            Descricao = descricao;
            Date = date;

            Validation();
        }

        public void Validation()
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

            if (Consultas == null)
            {
                throw new ArgumentNullException("Consultas");
            }

            if (Consultas.Count() == 0)
            {
                throw new Exception("Consultas da operação não informado.");
            }
        }
    }
}
