using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemoAnother
{
    public static class Helper
    {
        public static string TotalString = "Total value of card in our garage: ";
        public static string GenerateHeader()
        {
            string yearHeader = "year".PadRight(16);
            string makeHeader = "Make".PadRight(16);
            string colorHeader = "Color".PadRight(15);
            string priceHeader = "Price".PadLeft(9);
           

            string header = yearHeader + makeHeader + colorHeader + priceHeader; //Menggambungkan semua tanpa spasi YearMakeColorPrice
            return header;
        }
        public static string GenerateFooter(decimal total, string lijn)
        {

            string totalDetail = total.ToString("C").PadLeft(lijn.Length - TotalString.Length);
            return totalDetail;
        }
    }
}
