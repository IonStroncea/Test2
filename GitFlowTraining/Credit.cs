using System;


namespace GitFlowTraining
{
    public class Credit : IComparable<Credit>
    {
        private readonly decimal amount;

        public Credit(decimal amount)
        {
            this.amount = amount;
        }

        public decimal Amount { get { return amount; } }

        public int CompareTo(Credit c)
        {
            if (this.amount - c.amount > 0)
            {
                return 1;
            }
            else if (this.amount - c.amount < 0)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }

        public override bool Equals(object obj)
        {
            return ((obj == null) || (!this.GetType().Equals(obj.GetType())) ? false : (((Credit)obj).amount == this.amount));
        }

        public override int GetHashCode()
        {
            return (amount == default) ? 3 : (amount.GetHashCode() + 3);
        }

    }
}
