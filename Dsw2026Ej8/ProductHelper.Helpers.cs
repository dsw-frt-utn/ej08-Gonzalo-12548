using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static partial class ProductHelper
    {
        public static string FormatearPrice(decimal price) => price.ToString("C2"); 
    }
}
