using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_задание.Models
{
    public class Product
    {
        public static List<Product> list = new List<Product>
         {
                new Product(0, "Phone", 300, "Some good phone"),
                new Product(1, "MacBook Air", 999, "Very good computer"),
                new Product(2, "MacBook Pro 13", 1299, "Very good smartphone"),
                new Product(3, "MacBook Pro 14", 1999, "Very good smartphone"),
                new Product(4, "Phone", 300, "Some good phone"),
                new Product(5, "MacBook Air", 999, "Very good computer"),
                new Product(6, "MacBook Pro 13", 1299, "Very good smartphone"),
                new Product(7, "MacBook Pro 14", 1999, "Very good smartphone"),
                new Product(8, "Phone", 300, "Some good phone"),
                new Product(9, "MacBook Air", 999, "Very good computer"),
                new Product(10, "MacBook Pro 13", 1299, "Very good smartphone"),
                new Product(11, "MacBook Pro 14", 1999, "Very good smartphone"),
        };
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public Product(int Id, string Name, double Price, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
        }

        public Product()
        {
            this.Name = null;
        }
    }   
}   