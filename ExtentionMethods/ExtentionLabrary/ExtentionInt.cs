using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionLabrary
{

    #region Rik
    //{
    //    public static class ExtentionStringsType
    //    {
    //        public static bool IsPalinroom(this string str) //this ini adalah Extention
    //        {
    //            int right = str.Length - 1;
    //            for (int left = 0; left < right;)
    //            {
    //                if (str[right] != str[left])
    //                {
    //                    return false;
    //                }
    //                left++;
    //                right--;
    //            }
    //            return true;
    //        }



    //        }
    //    }

    //}
    #endregion

    public static class ExtentionInt
        {

            public static void Lijn(this int aantal)
            {
                Console.WriteLine(new string('_', aantal));

            }
            public static void Lijn(this int aantal, char karakter)
            {
                Console.WriteLine(new string(karakter, aantal));
            }

        
    }
}
