using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagboek.Models
{
    public class Agenda
    {

        private DataBank dataBank;

        private List<DataBank> dataB;
        public Agenda()
        {
            dataBank = new DataBank();
        }

        public void AddInput(DataBank data)
        {
            dataB.Add(data);
        }
        public void DeleteInput(DataBank data)
        {
            dataB.Remove(data);
        }
        public List<Input> SearchInput(DateTime dateTime)
        {
            return dataBank.FindInput(dateTime);
        }
        public void PrintInput(DateTime dateTime)
        {
            List<Input> inputs = SearchInput(dateTime);
            foreach (Input input in inputs)
            {
                Console.WriteLine(input);
            }
        }

    }
}
