using System.ComponentModel.DataAnnotations;

namespace OneToManyDemo.Models.ViewModels
{
    public class ProductenCategoriesViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Titel")]
        public string ProductName { get; set; }
       
        public string AuteurNaam { get; set; }
    }
}
