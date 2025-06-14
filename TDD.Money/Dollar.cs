using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDD.Money
{
    public class Dollar
    {
        private int amount { get; set; }
        public Dollar(int amount) {
            this.amount = amount;
        }
        public Dollar times(int multiplier) {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            if (obj is null && obj is not Dollar) return false;
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }

    }
    public class Franc
    {
        private int amount { get; set; }
        public Franc(int amount)
        {
            this.amount = amount;
        }
        public Franc times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            if (obj is null && obj is not Franc) return false;
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }

    }
}
