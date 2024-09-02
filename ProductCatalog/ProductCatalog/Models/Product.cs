using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsNewRelease { get; set; }
        public bool? IsBestSeller { get; set; }
        public int? BindingType { get; set; } //opsi apakah itu Pdf or hard Cover
        public string GetBidningType
        {
            get
            {
                return BindingType switch
                {

                    1 => "Heavy Food",
                    2 => "HardCover",
                    3 => "E-Book",
                    _ => "Unknown",

                };
            }
        }
    }
    }
        
    
