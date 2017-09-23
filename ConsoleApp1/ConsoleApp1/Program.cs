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
            Display d1 = new Display(new NormalDisplayImpl("枠線で表示"));
            Display d2 = new Display(new StarDisplayImpl("星で表示"));
            Display d3= new CountDisplay(new StarDisplayImpl("星で表示(子クラス)"));

            CountDisplay C1 = new CountDisplay(new NormalDisplayImpl("増幅して枠線で表示"));
            CountDisplay C2 = new CountDisplay(new StarDisplayImpl("増幅して星で表示"));

            d1.ExecuteDisplay();
            d2.ExecuteDisplay();
            d3.ExecuteDisplay();

            C1.MultiDisplay(5);
            C2.MultiDisplay(3);

            Console.ReadLine();
        }
    }
}
