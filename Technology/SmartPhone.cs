using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public int NumberOfSelfies { get; set; }
        public SmartPhone(double ram, double storage, bool hasKeyboard, int numberOfSelfies) : base(ram, storage, hasKeyboard)
        {
            NumberOfSelfies = numberOfSelfies;
        }

        public int TakeSelfies(int moreSelfies)
        {
            return NumberOfSelfies += moreSelfies;
        }
        
    }
}
