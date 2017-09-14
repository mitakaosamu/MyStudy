using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class DisplayImpl
    {
        public abstract void RawOpen();

        public abstract void RawPrint();

        public abstract void RawClose();
    }
}
