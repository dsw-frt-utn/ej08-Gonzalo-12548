using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            Product refeProd = product;
            copia += 10;
            refeProd.SetDescription("nueva descripcion");

            return $"{originalValue} - {copia} - {refeProd.GetDescription}";

        }
    }
}
