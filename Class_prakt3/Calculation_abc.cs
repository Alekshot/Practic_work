using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt3
{
    public class Calculation_abc
    {
        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        int a, b, c;
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double D()
        {
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                // Всі три числа парні, знайдемо їх добуток
                return a * b * c;
            }
            else
            {
                // Якщо хоча б одне число не парне, то знайдемо квадрат суми
                int sum = a + b + c;
                return sum * sum;
            }
        }
    }
}
