using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagboek.Models
{   
    public class DataBank
    {
        private List<Input> inputs = new List<Input>();

        public void AddInput(Input input)
        {
            inputs.Add(input);
        }
        public List<Input> FindInput (DateTime dateTime)
        {
          List<Input> inputs = new List<Input>();
           foreach (Input input in inputs)
            {
                if (input.DateTime.Date == dateTime.Date)
                {
                    inputs.Add(input);
                }
               
            }
          return inputs;
        }
        public void RemoveInput(List <Input> delete)
        {
            foreach (var input in delete)
            {
                delete.Remove(input);
            }
            
        }       
        
    }
}
