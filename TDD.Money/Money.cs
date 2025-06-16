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


        public static Dollar dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }
        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
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
