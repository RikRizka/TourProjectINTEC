using System.ComponentModel.DataAnnotations;

namespace CalculatorMVC.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter mothly investment")]
        [Range(1, 500, ErrorMessage = "Mothly investment must be between 1 nand 500 ")]
        public decimal? MonthlyInvestment { get; set; }
        [Required(ErrorMessage = "Please enter a yearly interest rate")]
        [Range(1, 500, ErrorMessage = "Mothly investment must be between 1 nand 50")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Pleqse enter a number of years")]
        [Range(1, 50, ErrorMessage = "Number of years must be between 1 and 50")]
        public int? Years { get; set; }
        public decimal Calculate()
        {
            int months = Years.Value * 12;
            decimal montlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) * (1 + montlyInterestRate);
            }


            return futureValue;
        }
       
    }
}
