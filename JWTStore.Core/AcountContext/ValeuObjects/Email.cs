using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTStore.Core.SharedContext.Extentions;
using JWTStore.Core.SharedContext.ValueObjects;

namespace JWTStore.Core.AcountContext.ValeuObjects
{
    public class Email : ValeuObject
    {
        private const string Pattern = @"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/";
        public string Adress { get; }
        public string Hash => Adress.ToBase64();
    }
}