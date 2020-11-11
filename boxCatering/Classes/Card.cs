using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public class Card
    {
        public int cardNumber { get; private set; }
        public int cardExpDate { get; private set; }
        public int cardCCV { get; private set; }


        public Card(int cardnumber, int cardexpdate, int cardccv)
        {
            setCardNumber(cardnumber);
            setCardExpDate(cardexpdate);
            setCardCCV(cardccv);
        }

        public void setCardNumber(int cardnumber)
        {
            this.cardNumber = cardnumber;
        }

        public void setCardExpDate(int cardexpdate)
        {
            this.cardExpDate = cardexpdate;
        }
        public void setCardCCV(int cardcvv)
        {
            this.cardCCV = cardcvv;
        }
    }
}
