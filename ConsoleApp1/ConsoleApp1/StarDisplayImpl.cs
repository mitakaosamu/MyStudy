using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StarDisplayImpl : DisplayImpl
    {
        private string _string;
        private int _width;
        
        public StarDisplayImpl(string s)
        {
            _string = s;
            _width = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(s);
        }

        public void RawOpen()
        {
            PrintLine();
        }

        public void RawPrint()
        {
            Console.WriteLine("*" + _string + "*");
        }

        public void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("*");
            for( int i = 0; i < _width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}
