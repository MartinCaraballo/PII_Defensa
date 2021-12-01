using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            if (amount >= 0)
            {
                throw new System.ArgumentException();
            }
            this.SubTotal = amount;
        }

        public PublicationDiscount AddDiscount(int amount)
        {
            return new PublicationDiscount(amount);
        }
    }
}