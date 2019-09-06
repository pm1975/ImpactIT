using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    /// <summary>
    /// Klasa pomocnicza
    /// </summary>
    public class Customer
    {
        private List<Address> Adresses = new List<Address>();
        public Customer()
        {
            Adresses.Add(new Address { Pin = 123456, Street = "ul.Lenina", City = "Stalowa Wola", Country = "Poland" });
            Adresses.Add(new Address { Pin = 123457, Street = "ul.Wyzwolenia", City = "Ipactwo", Country = "Republika Impactu" });
            Adresses.Add(new Address { Pin = 123466, Street = "ul.Zniewolenia", City = "Warszawa", Country = "Poland" });
            Adresses.Add(new Address { Pin = 123478, Street = "ul.Pisanek", City = "Warszawa", Country = "Poland" });
            Adresses.Add(new Address { Pin = 123567, Street = "ul.Samopomocy", City = "Kraków", Country = "Poland" });
            Adresses.Add(new Address { Pin = 123411, Street = "ul.Jana III", City = "Stalowa Wola", Country = "Poland" });
            Adresses.Add(new Address { Pin = 344667, Street = "ul.Ptaka", City = "Nisko", Country = "Poland" });
        }
        public Address GetAddress(int Pin)
        {
            foreach (Address item in Adresses)
            {
                if (item.Pin == Pin) return item;
            }
            return null;
        }
        public Address GetAddress(string City)
        {
            foreach (Address item in Adresses)
            {
                if (item.City.Equals(City))
                    return item;
            }
            return null;
        }

        public Address this[int Pin]
        {
            get
            {
                foreach (Address item in Adresses)
                {
                    if (item.Pin == Pin) return item;
                }
                return null;
            }        
        }
        public Address this[string City]
        {
            get
            {
                foreach (Address item in Adresses)
                {
                    if (item.City.Equals(City)) return item;
                }
                return null;
            }
        }
    }

    /// <summary>
    /// Address class
    /// </summary>
    public class Address
    {
        public int Pin { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
