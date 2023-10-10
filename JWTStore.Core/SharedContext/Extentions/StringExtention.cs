using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTStore.Core.SharedContext.Extentions
{
    public static class StringExtention
    {
        public static string ToBase64(this string text)
                => Convert.ToBase64String(Encoding.ASCII.GetBytes(text));
    }
}