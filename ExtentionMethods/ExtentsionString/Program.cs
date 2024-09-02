
using ExtentionLabrary;
using System.Diagnostics;

Main();
Main();
void Main()
{
    // SayHello();
    // SayGoodByeToOldFramework();
    Person person = new Person();
    person.Id = 1;
    person.FirstName = "Rik";
    person.LastName = "Junior";
    Console.WriteLine(person.GetPersonFullName());

    Print();
    IsPalindroom();
    WoordTellen();
    //HerhaalKarakter();
    GrootErsteLetter();



}
void Print()
{
    Console.WriteLine(new string('_', 60));
    80.Lijn();
    30.Lijn();

}
void IsPalindroom()
{
    // string str = "kayak";
    // bool isPalindroom = str.IsPalindroom();
    Console.WriteLine("lepel".IsPalindroom());
}
void WoordTellen()
{
    string zin = "Dit is een voorbeeld zin";
    Console.WriteLine($"aantal woord:{zin.WoordTellen()}");
}
//void HerhaalKarakter()
//{
//    ('*');                    //Extension Method
//                                                // ExtensionsInt.HerhaalKarakter(50, '*');  // Normal Method
//}
void GrootErsteLetter()
{
    string zin = "Dit iS eEn moOie prograMMA";
    Console.WriteLine(zin.NaarTitelNotatie());


}
//void SayHello()
//{
//    Console.WriteLine("Hello");
//}
//void SayGoodByeToOldFramework()
//{
//    Console.WriteLine("Say good bye");
//}




//void Main()
//{
//    Person person = new Person();
//    person.Id = 1;
//    person.FirstName = "Rik";
//    person.LastName = "Junior";

//    Console.WriteLine(person.GetPersonFullName());
//    Print();
//    10.Lijn();
//    Test();
//    HerhaalKarakter();
//    BigLettersT();
//}
//void Print()
//{
//    Console.WriteLine(new string('_', 60));
//    80.Lijn();
//    //int u = 10;

//}
//void HerhaalKarakter()
//{
//    60.Lijn('4');
//}
//void Test()
//{
//    string test = "kayako";
//    bool testeten = test.IsPalindroom();
//    Console.WriteLine(testeten);
//    //Console.WriteLine("Kayak".IsPalinroom());
//}

////void CountWords()
////{
////    string zin = "Dit is een cvoorbeeld zin";
////}
//void BigLettersT()
//{
//    string test = "Ik Ben rIk";
//    string result = test.();
//    Console.WriteLine( result);


//}




