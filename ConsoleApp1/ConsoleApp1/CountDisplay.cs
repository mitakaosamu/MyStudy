using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl displayImpl) : base(displayImpl)
        {
        }

        public void MultiDisplay(int times)
        {
            Open();
            for(int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
