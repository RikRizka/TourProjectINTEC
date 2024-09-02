using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomException
{
    public class UserNameExpection:Exception
    {
        public UserNameExpection()
        {
            
        }
        public UserNameExpection(string message) : base(message)
        {

        }
        public override string Message
        {
            get
            {
                return "User name is not correct";
            }
        }
    }

}
