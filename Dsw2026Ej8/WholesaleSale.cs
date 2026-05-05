using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        private const decimal _descuento = 0.10M;
        public WholesaleSale(decimal importe) : base(importe) { }
        public override decimal CalculateTotal() => GetImporte() * (1 - _descuento);
    }
}
