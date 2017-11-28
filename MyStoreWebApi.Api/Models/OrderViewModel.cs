using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStoreWebApi.Api.Models;

namespace MyWebAPI.Api.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public UserModel UserModel { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
        

        public OrderViewModel()
        {
            Products = new List<ProductViewModel>();
        }
    }
}