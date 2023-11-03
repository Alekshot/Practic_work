using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt4
{
    internal class FileRead:IRead
    {
        public void read(string patch, ArraysAB a)
        {
            using (StreamReader sr = new StreamReader(patch,
                System.Text.Encoding.Default))
            {
                string line = "";
                try
                {
                    int i = 0;
                    while((line = sr.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToInt32(line);
                        i++;
                    }
                    a.Length = i;
                    sr.Close();
                }
                catch
                {
                    throw new AccessViolationException("Error in file");
                }
            }
        }
    }
}
