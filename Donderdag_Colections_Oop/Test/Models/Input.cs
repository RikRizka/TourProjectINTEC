using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagboek.Models
{
    public class Input
    {
        public DateTime DateTime { get; set; }
        public string Text { get; set; }

        //public Input(string text, DateTime dateTime)
        //{
        //    Text = text;
        //    DateTime = dateTime;
        //}

        public override string ToString()
        {
            return $"{DateTime: MM/dd/yyyy} - {Text: Boek lezen}";
        }
    }
}
