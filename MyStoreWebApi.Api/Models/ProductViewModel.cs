namespace MyWebAPI.Api.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string PictureName { get; set; }
        public string ImageBase64 { get; set; }
    }
}