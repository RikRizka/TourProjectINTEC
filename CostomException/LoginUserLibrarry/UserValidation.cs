using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomException
{
    public class UserValidation
    {
        public string ValidateLoginData(LoginInformation loginInformation)
        {
            if (!IsValidUserName(loginInformation.UserName))
            {
                throw new UserNameExpection();
               // throw new Exception("User name is not correct");
            }
            if (!IsValidUserName(loginInformation.UserName))
            {
                throw new PasswordException();
                //throw new Exception("Pasword is not in ocrrect i format");
            }
            return "Log in wa succesfull";
        }
        public bool IsValidUserName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                return true;
            }
            if(userName.Length <4 || userName.Length > 20)
            {
                return false;
            }
          return true;
        }
        public bool ValidatePassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                return true;
            }
            if(password.Length <4 || password.Length > 20)
            {
                return false;
            }
            return true;
        }
    }
}
