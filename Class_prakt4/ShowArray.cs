using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt4
{
    internal class ShowArray
    {
        public string writeArray(int[] array)
        {
            string s = "";
            foreach(int i in array)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}
