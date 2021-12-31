using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_задание.Models
{
    public class Customer
    {
        public static List<Customer> list = new List<Customer>
        {
            new Customer("Vasiliy", "Chubatkov", 40, "+375293456512"),
            new Customer("Petya", "Petrov", 27, "+375293465512"),
            new Customer("Vanya", "Salosov", 18, "+375293568812"),
            new Customer("Grigory", "Vitalev", 40, "+37529877892"),
            new Customer("Ignat", "Tarasov", 35, "+375295645662"),
        };
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Customer(string Name, string Surname, int Age, string Phone)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Phone = Phone;
        }
    }
}