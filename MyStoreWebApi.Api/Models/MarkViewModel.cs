

using System.Collections.Generic;

namespace MyWebAPI.Api.Models
{
    public class MarkViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }

        public MarkViewModel()
        {
            Products = new List<ProductViewModel>();
        }
    }
}