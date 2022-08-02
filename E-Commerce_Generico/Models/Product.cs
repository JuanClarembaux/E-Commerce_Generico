using System;
using System.Collections.Generic;

namespace E_Commerce_Generico.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductBrand { get; set; }
        public string ProductCategory { get; set; } = null!;
        public decimal? ProductPrice { get; set; }
        public byte[]? ProductImage { get; set; }
    }
}
