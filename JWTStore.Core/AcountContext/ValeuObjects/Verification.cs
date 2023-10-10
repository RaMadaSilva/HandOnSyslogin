using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTStore.Core.AcountContext.ValeuObjects
{
    public class Verification
    {
        public string Code { get; } = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6).ToUpper();
        public DateTime? ExpireAt { get; private set; } = DateTime.UtcNow.AddMinutes(5);
        public DateTime? VerifiedAt { get; private set; } = null;
        public bool IsActive => VerifiedAt != null && ExpireAt == null;

        public void Verify(string code)
        {
            if (IsActive)
                throw new Exception("Este item ja foi activado");
            if (ExpireAt < DateTime.UtcNow)
                throw new Exception("Este codigo já expirou");

            if (!string.Equals(code.Trim(), code.Trim(), StringComparison.CurrentCultureIgnoreCase))
                throw new Exception("Codigo Invalido");

            ExpireAt = null;
            VerifiedAt = DateTime.UtcNow;
        }
    }
}