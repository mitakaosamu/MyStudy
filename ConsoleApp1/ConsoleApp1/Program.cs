using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello,Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello,World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello,Universe."));

            d1.ExecuteDisplay();
            d2.ExecuteDisplay();
            d3.ExecuteDisplay();

            d3.MultiDisplay(5);

            Console.ReadLine();
        }
    }
}
