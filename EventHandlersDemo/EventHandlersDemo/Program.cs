using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new ArticelePublisher();

            //maak abonomenten
            var subscriber1 = new Subscribe("Rick ulili");
            var subscriber2 = new Subscribe("Gabriella ulala");

            //abonamente
            publisher.ArticelePublishe+= subscriber1.OnArticelPublished;
            publisher.ArticelePublishe+= subscriber2.OnArticelPublished;

            publisher.publishArticle ( "Introduction on .Net programing");

        }
    }
}
