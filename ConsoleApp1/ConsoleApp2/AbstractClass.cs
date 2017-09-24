using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class AbstractClass 
    {
        public void Execute()
        {
            ExecuteInnerProc();
        }

        protected abstract void ExecuteInnerProc();
    }
}
