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

        public string Hash { get; } = string.Empty;
        public string ResetCode { get; } = Guid.NewGuid().ToString("N")[..8].ToUpper();

        private static string Generator(short length = 16, bool includeSpecialChars = true, bool upperCase = false)
        {
            var chars = includeSpecialChars ? (Valid + Special) : Valid;
            var starRandom = upperCase ? 26 : 0;
            var index = 0;
            var res = new char[length];
            var rnd = new Random();

            while (index < length)
                res[index++] = chars[rnd.Next(starRandom, chars.Length)];

            return new string(res);
        }

    }
}