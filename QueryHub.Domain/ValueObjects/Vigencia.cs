using QueryHub.Domain.ValueObjects.Base;
using System;

namespace QueryHub.Domain.ValueObjects
{
    public class Vigencia : ValueObjectsBase
    {
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }

        public Vigencia(DateTime? inicio, DateTime? fim)
        {
            Inicio = inicio;
            Fim = fim;

            Validation();
        }

        protected override void Validation()
        {
            if (Inicio == null || Inicio == DateTime.MinValue)
            {
                throw new ArgumentNullException("Inicio");
            }

            if (Fim == null || Fim == DateTime.MinValue)
            {
                throw new ArgumentNullException("Fim");
            }

            if( Fim < Inicio)
            {
                throw new ArgumentException("Data Fim menor que data inicio");
            }
        }
    }
}
