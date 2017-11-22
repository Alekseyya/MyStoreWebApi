namespace MyStoreWebApi.BL.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
        public int Count { get; set; }
    }
}
