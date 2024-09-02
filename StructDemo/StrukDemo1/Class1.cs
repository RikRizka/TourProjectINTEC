using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukDemo1
{
    public struct Student
    {
       public int Age;
       public string Name;
       public string Address;
       public string Email;

        public override string ToString()
        {
            return $"Age {Age} name:{Name}address: {Address}email:{Email}";
        }
    }
}
