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
            return 15 * 37;
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else 
            {
                Credit c = (Credit)obj;
                return this.amount == c.amount;
            }
        }

        public override int GetHashCode()
        {
            if (amount == null)
            {
                return default;
            }
            else 
            {
                return amount.GetHashCode();
            }
        }

    }
}
