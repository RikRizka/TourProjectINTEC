﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomException
{
    public class PasswordException:Exception
    {
        public PasswordException()
        { 

        }
        public PasswordException(string message):base(message)
        {

        }
        public override string Message
        {
            get
            {
                return "Password is not correct format";
            }
        }
    }

}
