using System;
using System.Runtime.Remoting.Services;

namespace ClassC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region howOldAreU?
            //String studentName;
            //int studentBornYear;
            //int thisYear = 2023;

            //Console.Write("What is your name :");
            //studentName = Console.ReadLine();

            //Console.Write("when u were born :");
            //studentBornYear = Convert.ToInt32(Console.ReadLine());

            //thisYear= thisYear - studentBornYear;

            //Console.WriteLine($"you are {studentBornYear} years old");
            #endregion

            #region mengubahWarnaDanMenggeserkanCorsor

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.White;
            ////Console.Clear(); //kamu harus tau di mana kamu harus meletakan 
            //Console.WriteLine("hello c# programers");
            //Console.ReadLine();
            //#region ConsorPotito

            //int row = 50; int col = 20; // row ke kanan kiri dan col atas bawah
            //row = row - 10; col = col - 19; // ini adalah cara lain untuk mengubah posisi dari samping kiri kana dan atas bawah

            //Console.SetCursorPosition(row, col);
            //Console.WriteLine("left");
            //Console.Title = "this is good";
            #endregion

            #region ProjectWarnaDanCoursor
            //Console.WriteLine("Druk enter");
            //Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("de vier elemet zijn");

            //Console.SetCursorPosition(50, 10);
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Water");

            //Console.SetCursorPosition(10, 15);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Vuur");

            //Console.SetCursorPosition(100, 15);
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Aardere");

            //Console.SetCursorPosition(50, 20);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Lucht");
            //#endregion

            //#region

            //string name = null;
            //decimal salary = 0;
            //bool isMale = false;

            //Console.Write("Enter your name please :");
            //name = Console.ReadLine();
            //Console.Write("Enter ur salari :");
            //salary = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("are u male?");
            //isMale = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine($"U enetereed following salary {isMale}");
            #endregion

            #region TrueOrFalse

            //string name = null;
            //decimal salary = 0;
            //bool isMale = false;

            //Console.Write("Enter your name please :");
            //name = Console.ReadLine();
            //Console.Write("Enter ur salari :");
            //salary = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("are u male?");
            //isMale = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine($"U enetereed following salary {isMale}");

            #endregion

            #region dataRange
            //Console.WriteLine("int min. value \t " + int.MinValue);
            //Console.WriteLine("int max. value " + int.MaxValue + "\n");

            //Console.WriteLine("double min value " + double.MinValue);
            //Console.WriteLine("double max value " + double.MaxValue + "\n");

            //Console.WriteLine("byte min value " + byte.MinValue);
            //Console.WriteLine("byte max value " + Byte.MaxValue + "\n");

            //string name = "intec brussels  13, 100 bxl";
            //Console.WriteLine("the length of the name variabel is : " + name.Length);

            //Console.ReadLine()

            #endregion

            #region ConverData

            // kenapa di masukan int di situ? karena untuk menganti double
            //(double ke int terlalu besar) makanya di gati ke int.

            //double akan ada kome Tetatpi
            //kita sudah mengganti ke int jadi koma akan hilang.
            //(kapasitas double terlalu besar)

            //double salary = 1500.5;

            //int salaryDouble = (int)salary;

            //Console.WriteLine("salaryDouble " + salaryDouble); 

            // ConverDataAdaBeberapa

            //int a;

            //Console.WriteLine("Enter a nunber");
            //a = int.Parse(Console.ReadLine());
            //a = a - 2;
            //Console.WriteLine(a);

            //Decimal x;
            //int y = 0;
            //checked
            //{// jika check harus memasukan ini { dan di tutup di bawah

            //    //Dari Decimal Conver ke int
            //    x = (int)y;
            //    Console.WriteLine("you are losing data");

            //}
            //Console.WriteLine("value of x is + x");

            // Cara lain =

            //int x;
            //decimal y = 250.5m;
            //checked
            //{
            //    x = (int)y;
            //    Console.WriteLine("value of is :" + x);

            //Console.WriteLine("Geef een getal in: ");
            //string input = Console.ReadLine();
            //int getal = Int32.Parse(input);

            //Console.WriteLine("Het kwadraat is: {0}", getal * getal);
            //Console.WriteLine("De derde macht is: {0}", getal * getal * getal);

            //Console.ReadKey();
            //}



            #endregion

            #region VariabelenConstant
            //System.String address = "";
            //string schoolName;
            //schoolName = "ABC";
            //Console.WriteLine(schoolName);
            //bool isMarried = false;
            //const double btw = 17.0;
            //const double pi = 3.14;

            //char letter = 'a';
            //int? inhabitansInBelgium = null;
            //short inhabitansIntAmandsberg = 0;
            //int age = 0;
            ////schoolName = "VDAB";
            //byte studentAge = 255;
            //decimal slari = 1500.25m;
            //float piFloat = 3.1445545f;
            //Console.WriteLine(schoolName.Trim());
            //Console.WriteLine(schoolName.Length);
            //Console.WriteLine(schoolName);
            //Console.ReadLine();
            #endregion




        }
    }
}
