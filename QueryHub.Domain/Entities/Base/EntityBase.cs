using System;

namespace QueryHub.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        public Guid Identificador { get; private set; }

        public EntityBase()
        {
            Identificador = Guid.NewGuid();
        }

        protected abstract void Validation();
    }
}
