using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyListDemo
{
    public class MyList : IMyList
    {
        private int[]array = null;
        private int count;

        public MyList(int size)
        {
            array = new int[size];
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public void Add(int item)
        {
          if (count == array.Length)
            {
                array[count++] = item;
            }
        }

        public int GetItem(int index)
        {
            
        }

        public void ToonAlles()
        {
            throw new NotImplementedException();
        }
    }
}
