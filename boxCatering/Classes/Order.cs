using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public class Order
    {
        public Customer customers { get; private set; }
        public Card cards { get; private set; }

        public Order(Customer customer, Card cards)
        {
            setCustomer(customer);
            setCard(cards);
        }

        public void setCustomer(Customer customer)
        {
            this.customers = customer;
        }

        public void setCard(Card card)
        {
            this.cards = card;
        }

    }
}
