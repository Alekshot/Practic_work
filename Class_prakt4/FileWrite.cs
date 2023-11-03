using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt4
{
    internal class FileWrite:IWrite
    {
        public void write(string patch, ArraysAB a)
        {
            using(StreamWriter sw = new StreamWriter(patch, false, 
                System.Text.Encoding.Default))
            {
                foreach(var item in a.b)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
    }
}
