using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Producten { get; set; } = new List<Product>();
    }
}
