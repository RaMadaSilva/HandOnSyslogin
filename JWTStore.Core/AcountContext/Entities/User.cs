using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTStore.Core.AcountContext.ValeuObjects;
using JWTStore.Core.SharedContext.Entities;

namespace JWTStore.Core.AcountContext.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public Email Email { get; private set; }

    }
}