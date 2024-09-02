using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models.ViewModels;

namespace ProductCatalog.Models.ViewModel
{
    [Keyless]
    public class ProductenViewModel
    {
        public List<ProductenCategoriesViewModel> Boeken { get; set; }
        public List<Category> Categories { get; set; }
        public int GeselecteerdeAuteurId { get; set; }

    }
}
