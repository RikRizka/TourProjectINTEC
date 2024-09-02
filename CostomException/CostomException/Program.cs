using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomException
{
    internal class Program
    {
        private static string userName;
        private static string password;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();

            Console.Write("Enter your pasword please: ");
            string password = Console.ReadLine();

            LoginInformation loginInformation = new LoginInformation()
            {
               UserName = userName,
              Password = password
            };
            UserValidation userValidation = new UserValidation();
            try
            {
               string result = userValidation.ValidateLoginData(loginInformation);
                Console.WriteLine(result);
            }
            catch (UserNameExpection ex)
            {
                Console.WriteLine( ex.Message);
            }
            catch (PasswordException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) // Genereci
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
