using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTStore.Core.SharedContext.Entities
{
    public abstract class Entity : IEquatable<Guid>
    {
        public Entity() => Id = Guid.NewGuid();
        public Guid Id { get; private set; }
        public bool Equals(Guid id) => Id == id;
    }
}