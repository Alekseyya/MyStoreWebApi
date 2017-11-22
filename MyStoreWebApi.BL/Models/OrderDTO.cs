using System;
using System.Collections.Generic;

namespace MyStoreWebApi.BL.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<ProductDTO> Products { get; set; }
        public UserDTO User { get; set; }

        public OrderDTO()
        {
            Products = new List<ProductDTO>();
        }
    }
}
