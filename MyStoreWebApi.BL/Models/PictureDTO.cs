using System;

namespace MyStoreWebApi.BL.Models
{
    public class PictureDTO
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime UpdateTimestamp { get; set; }
    }
}
