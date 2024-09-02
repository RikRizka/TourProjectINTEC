using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceDictionarryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion Dictionary<int, string>
            // Dictionary<int, string> dic = new Dictionary<int, string>();
            // dic.Add(1, "One");
            // dic.Add(2, "Twe");
            // dic.Add(3, "Theree");
            // dic.Add(4, "Four");
            // dic.Add(5, "Five");
            //// dic.Add(3, "Six"); // di sini the keys harus berbeda kalau tidak makan akan crash "key is 3" tidak boleh sama

            // foreach (KeyValuePair<int, string> kvp in dic) // ini untuk membaca semua ynag di atas
            // {
            //     Console.WriteLine($"key: {kvp.Key}, Value: {kvp.Value}");
            // }
            // Console.WriteLine("Press key to exit.");
            // foreach(KeyValuePair<int, string> kvp in dic) 
            // {
            //     Console.WriteLine($"Value: {kvp.Value}");
            // }
            #endregion

            #region Myregion SortedDictionary <string, string>

            //Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase); //(ini di gunakan ketika kita ingin kalau huruf nya One dan one akan salah) tanpa ini O dan o tidak masalah
            //dictionary.Add("One", "1" );
            //dictionary.Add("Twe","2");
            //dictionary.Add("Theree","3");
            //dictionary.Add("Four","4" );
            //dictionary.Add("Five", "5");
            //dictionary.Add("one", "11");

            ////foreach(KeyValuePair<string, string> pair in dictionary)
            //foreach (var kvp in dictionary) // lebih baik dan simple
            //{
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            //}
            #endregion

            #region Myregion Maanden
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add
            #endregion

        }
    }
}
