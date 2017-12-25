using System.Collections.Generic;

namespace MyWebAPI.Api.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public ICollection<PictureViewModel> Pictures { get; set; }

        public ProductViewModel()
        {
            Pictures = new List<PictureViewModel>();
        }
        
    }
}