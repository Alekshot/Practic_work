using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work
{
    internal class Arrays
    {
        public bool error = false; //відкрите поле помилки
        int[] a; //закритий масив
        //закрита довжина масиву
        int length = 7;
        //властивість розмірність
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int this[int i]
        {
            get
            {
                if (0 <= i && i < length)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < length && value >= -100 && value <= 100)
                    a[i] = value;
                else
                    error = true;
            }
        }
        //Конструктори
        public Arrays()
        {
            a = new int[length];
        }
        public Arrays(int[] mas)
        {
            a = mas;
        }
        public Arrays(int size)
        {
            length = size;
            a = new int[length];
            Random rand = new Random();
            for(int i = 0; i < length; i++)
            {
                a[i] = rand.Next(-50, 50);
            }
        }
        //Властивість для обрахунку сум
        public int SumAfterDoubling()
        {
            int S = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2; // Збільшуємо всі елементи масиву у 2 рази.
                S += a[i]; // Додаємо кожний елемент до суми.
            }
            return S;
        }
    }
}
