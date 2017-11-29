using System.Collections.Generic;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Models
{
    public class MarkDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductDTO> Products { get; set; }

        public MarkDTO()
        {
            Products = new List<ProductDTO>();
        }
    }
}
