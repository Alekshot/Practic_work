using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            return (Math.Pow(Math.Sin(x + 5), 2) / (Math.Exp(-x) + Math.Pow(3 * Math.Pow(x, 2) + 1, 1.0 / 3.0)));
        }

        private double f2(double x)
        {
            return (Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x) / Math.Pow(Math.Cos(x + 3), 2);
        }

        private double f3(double x)
        {
            return Math.Tan(Math.Pow(x, 2) + 4 * x - 1) / (2 * Math.Sqrt(Math.Pow(x, 3)) * Math.Sin(Math.Pow(x, 3)));
        }
        
        public void tab(double xn = 2.45, double xk = 25.2, double h = 0.1, double a = 0.1)
        {
            double x = xn, y;
            int i = 0;
            while(x <= xk)
            {
                if(x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                        y = f3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
