using System.ComponentModel.DataAnnotations;

namespace MVCProjectPelelangan.Models
{
    public class ResponsCostumers
    {
        [Required (ErrorMessage ="Please enter ur name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter ur Email")]
        //[RegularExpression("\\@\\.", ErrorMessage = "PLease chech again")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Please enter your phone number")]
        public string Gsm { get; set; }
        [Required(ErrorMessage ="Please enter your nominal")]
        public string Nominal { get; set; }
        public bool? ConfirmationAuction { get; set; }

    }
}
