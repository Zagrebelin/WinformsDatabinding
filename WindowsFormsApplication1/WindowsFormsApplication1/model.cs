using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Model 
    {
        private string _a;
        private string _lower;
        private string _upper;

        public string A
        {
            get { return _a; }
            set
            {
                _a = value;
                if (UseThread)
                {
                    new Thread(() => { Upper = $"{A.ToUpper()} [Tid={Thread.CurrentThread.ManagedThreadId}]"; }).Start();
                    new Thread(() => { Lower = $"{A.ToLower()} [Tid={Thread.CurrentThread.ManagedThreadId}]"; }).Start();
                }
                else
                {
                    Upper = A.ToUpper();
                    Lower = A.ToLower();
                }
            }
        }

        public bool UseThread { get; set; }

        public string Lower
        {
            get { return _lower; }
            set
            {
                if (value == _lower)
                    return;
                _lower = value;
            }
        }

        public string Upper
        {
            get { return _upper; }
            set
            {
                if (value == _upper) return;
                _upper = value;
            }
        }
    }
}
