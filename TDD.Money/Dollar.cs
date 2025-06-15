using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDD.Money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
            : base(amount, currency) { }
        public override Money times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }

    }
}
