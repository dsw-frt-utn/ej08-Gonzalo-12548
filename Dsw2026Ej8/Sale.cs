using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        private decimal _importe;
        public decimal GetImporte() => _importe;
        public Sale(decimal importe) => _importe = importe;
        public virtual decimal CalculateTotal() => _importe;
    }
}
