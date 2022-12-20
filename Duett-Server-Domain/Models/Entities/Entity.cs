using System.Globalization;
using System;

namespace Duett_Server_Domain.Models.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public void setId(Guid id)
        {
            Id = id;
        }

        public bool Equals(Entity? other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}