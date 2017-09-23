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

        /// <summary>
        /// 出力の前処理
        /// </summary>
        protected void Open()
        {
            _displayImpl.RawOpen();
        }

        /// <summary>
        /// データの出力
        /// </summary>
        protected void Print()
        {
            _displayImpl.RawPrint();
        }

        /// <summary>
        /// 出力の後処理
        /// </summary>
        protected void Close()
        {
            _displayImpl.RawClose();
        }

        /// <summary>
        /// 出力実行
        /// </summary>
        public void ExecuteDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
