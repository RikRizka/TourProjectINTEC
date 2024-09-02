using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public double price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
    
}
