using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
