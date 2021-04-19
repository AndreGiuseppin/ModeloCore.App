using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloCore.Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        /* EF Relations */
        public Guid Id { get; set; }
    }
}
