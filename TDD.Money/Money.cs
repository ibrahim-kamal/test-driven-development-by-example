namespace TDD.Money
{
    public class Money
    {
        protected int amount { get; set; }

        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object obj)
        {
            if (obj is null && obj is not Money) return false;
            Money money = (Money)obj;
            return amount == money.amount 
                && Getcurrency().Equals(money.Getcurrency());
        }


        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }
        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }
        
        public Money times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
        public string Getcurrency()
        {
            return currency;
        }

        public String toString()
        {
            return amount + " " + currency;
        }
    }
}
