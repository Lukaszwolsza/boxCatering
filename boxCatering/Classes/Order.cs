using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public class Order
    {
        //public int orderID { get; private set; }
        public Customer customers { get; private set; }
        public Card cards { get; private set; }

        public object diets { get; set; }


        public Order(Customer customer, Card cards, object diets)
        {
            setCustomer(customer);
            setCard(cards);
            setDiet(diets);
        }

        public void setCustomer(Customer customer)
        {
            this.customers = customer;
        }

        public void setCard(Card card)
        {
            this.cards = card;
        }
        public void setDiet(object diet)
        {
            this.diets = diet;
        }

    }
}
