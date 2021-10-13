using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Figure
    {
        public int Type { get;  }

        public Figure(int type)
        {
            Type = type;
        }
        public virtual void CakculateArea()
        {
            return;
        }
    }
}
