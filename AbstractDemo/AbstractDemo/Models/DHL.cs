using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public class DHL:Post
    {
       public PostBE( Adres adres) : base(PostBE, adres) 
        { 
        
        }
        public override void BerekenVerzendKosten(P oph)
    }
}
