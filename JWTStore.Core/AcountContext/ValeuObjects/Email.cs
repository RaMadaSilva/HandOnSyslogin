using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JWTStore.Core.SharedContext.Extentions;
using JWTStore.Core.SharedContext.ValueObjects;

namespace JWTStore.Core.AcountContext.ValeuObjects
{
    public partial class Email : ValeuObject
    {
        private const string Pattern = @"/^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/";
        public Email(string Adress)
        {
            if (string.IsNullOrEmpty(Adress))
                throw new Exception("E-mail invalido");

            Adress = Adress.Trim().ToLower();

            if (Adress.Length < 5)
                throw new Exception("E-mail Invalido");

            if (!EmailRegex().IsMatch(Adress))
                throw new Exception("E-mail Invalido");

        }
        public string Adress { get; }
        public string Hash => Adress.ToBase64();

        [GeneratedRegex(Pattern)]
        private static partial Regex EmailRegex();

        public static implicit operator String(Email email)
            => email.ToString();

        public static implicit operator Email(string Adress)
            => new Email(Adress);

    }
}