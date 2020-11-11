using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public class Customer
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public int Postcode { get; private set; }
        public string City { get; private set; }
        public int Phone { get; private set; }


        public Customer(string name, string surname, string email, string address, int postcode, string city, int phone)
        {
            setCustomerName(name);
            setCustomerSurname(surname);
            setCustomerEmail(email);
            setCustomerAddress(address);
            setCustomerPostcode(postcode);
            setCustomerCity(city);
            setCustomerPhone(phone);
        }

        public void setCustomerName(string name)
        {
            this.Name = name;
        }
        public void setCustomerSurname(string surname)
        {
            this.Surname = surname;
        }
        public void setCustomerEmail(string email)
        {
            this.Email = email;
        }
        public void setCustomerAddress(string address)
        {
            this.Address = address;
        }
        public void setCustomerPostcode(int postcode)
        {
            this.Postcode = postcode;
        }
        public void setCustomerCity(string city)
        {
            this.City = city;
        }
        public void setCustomerPhone(int phone)
        {
            this.Phone = phone;
        }

    }
}
