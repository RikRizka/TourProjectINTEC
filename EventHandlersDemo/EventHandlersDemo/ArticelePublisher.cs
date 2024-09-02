using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlersDemo
{
    public class ArticelePublisher
    {
        //ini adalah delegate
        public delegate void ArticelePublisheEventHandler(string messege);
        //ArticelePublishe is de name
        public event ArticelePublisheEventHandler ArticelePublishe;
        //Method publish
        public void publishArticle(string articelTitle)
        {
            //ArticelePublishe?.Invoke($"Nieuwe articel beschikbaar {articelTitle}");//sintac pertama
            var handler = ArticelePublishe;
            if (handler != null)
            {
                handler($"Nieuwe articel beschikbaar {articelTitle}");
            }
        }
    }
}
