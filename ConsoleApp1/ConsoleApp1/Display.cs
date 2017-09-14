using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Display
    {
        private DisplayImpl _displayImpl;

        public Display(DisplayImpl displayImpl)
        {
            _displayImpl = displayImpl;
        }

        public void Open()
        {
            _displayImpl.RawOpen();
        }

        public void Print()
        {
            _displayImpl.RawPrint();
        }

        public void Close()
        {
            _displayImpl.RawClose();
        }

        public void ExecuteDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
