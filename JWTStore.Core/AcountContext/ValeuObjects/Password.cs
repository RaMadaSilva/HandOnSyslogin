using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTStore.Core.SharedContext.ValueObjects;

namespace JWTStore.Core.AcountContext.ValeuObjects
{
    public class Password : ValeuObject
    {
        private const string Valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPRSTUVWXYZ";
        private const string Special = "!@#$%^&*(){}[];";

        public string Hash{ get;} = string.Empty; 
        public string ResetCode { get; } = Guid.NewGuid().ToString("N")[..8].ToUpper(); 

    }
}