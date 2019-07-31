using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard c1 = new CreditCard();
            c1.Name = "Joe Forrester";
            c1.Card = "1234-5678-9012-3456";
            c1.Security = 123;
            c1.Date = "01/06/21";

            Console.WriteLine($"Credit Card Details:\nName: {c1.Name}\nExpiration: {c1.Date}\n");

            // to display private card number
            Console.WriteLine("Please enter your password");
            string pw = Console.ReadLine();
            c1.DisplayForbidden(c1, pw);
            Console.ReadLine();
        }
    }
    class CreditCard
    {
        // attributes
        private string name;
        private string card;
        private int security;
        private string date;
        
        // properties (getters and setters) Card & Security gets have been set to private.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Card
        {
            private get { return card; }
            set { card = value; }
        }
        public int Security
        {
            private get { return security; }
            set { security = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        // Constructors
        public CreditCard() { }
        public CreditCard(string _name, string _card, int _security, string _date)
        {
            Name = _name;
            Card = _card;
            Security = _security;
            Date = _date;
        }

        // Method to bypass private card get
        public void DisplayForbidden(CreditCard c1, string pw)
        {
            if (pw == "Mary")
                Console.WriteLine(c1.Card);
        }
    }
}
