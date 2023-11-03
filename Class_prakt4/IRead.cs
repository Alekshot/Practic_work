using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt4
{
    internal interface IRead
    {
        void read(string patch, ArraysAB a);
    }
    internal interface IWrite
    {
        void write(string patch, ArraysAB a);
    }
}
