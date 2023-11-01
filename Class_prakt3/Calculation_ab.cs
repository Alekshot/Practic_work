using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt3
{
    public class Calculation_ab
    {
        int a, b;
        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int A { get { return a; } }
        public int B { get { return b; } }
        public int Sum()
        {
            int product = 1; // Початкове значення добутку - 1

            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0 && i % 8 == 0)
                    {
                        product *= i; // Перемножуємо числа, які задовольняють умови
                    }
                }
            }
            else
            {
                // Обмін значень a і b, якщо a > b
                int temp = a;
                a = b;
                b = temp;

                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0 && i % 8 == 0)
                    {
                        product *= i;
                    }
                }
            }

            return product;
        }
    }
}
