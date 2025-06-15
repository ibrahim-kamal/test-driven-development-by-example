namespace TDD.Money
{
    public abstract class Money
    {
        protected int amount { get; set; }

        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            currency = currency;
        }

        public override bool Equals(object obj)
        {
            if (obj is null && obj is not Money) return false;
            Money money = (Money)obj;
            return amount == money.amount 
                && GetType().Equals(money.GetType());
        }


        public static Dollar dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }
        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
        public abstract Money times(int multiplier);
        public string Getcurrency()
        {
            return currency;
        }
    }
}
