using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStoreWebApi.Api.Models;

namespace MyWebAPI.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<Product> Products { get; set; }
        

        public Order()
        {
            Products = new List<Product>();
        }
    }
}