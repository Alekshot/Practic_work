using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work.Class_prakt4
{
    public class ArraysAB
    {
        public int[] a;
        public int[] b;
        int length = 0;
        public int Length { get { return length; } set { length = value; } }
        public ArraysAB(int n)
        { a = new int[n]; }
        public void calculate()
        {
            // Знаходимо найбільший модуль серед всіх елементів масиву a
            int maxModulus = 0;
            foreach (int element in a)
            {
                int modulus = Math.Abs(element);
                if (modulus > maxModulus)
                {
                    maxModulus = modulus;
                }
            }

            // Створюємо новий масив b на основі умов вашого завдання
            b = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (Math.Abs(a[i]) == maxModulus)
                {
                    b[i] = 1; // Замінюємо на 1, якщо збігається з максимальним модулем
                }
                else
                {
                    b[i] = 0; // Замінюємо на 0, якщо не збігається
                }
            }
        }
    }
}
