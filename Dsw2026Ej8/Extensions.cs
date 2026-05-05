using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dsw2026Ej8
{
    public static  class Extensions
    {
        public static string ToProductCode(this string code)
        {
            return (code ?? "SIN-CODIGO")
              .Trim()
              .ToUpper()
              .Replace(" ", "-");

        }
    }
}
