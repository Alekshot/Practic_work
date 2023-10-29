using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_work
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_length = 5;
        int y_length = 3;
        private int[,] a;

        public int X_length
        {
            get { return x_length; }
            set { x_length = value; }
        }

        public int Y_length
        {
            get { return y_length; }
            set { y_length = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length)
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if(0 <= i && i < x_length && 0 <= j && j < y_length
                    && value >= -10 && value <= 10)
                    a[i, j] = value;
                else
                {
                    error = true;
                }
            }
        }

        void generate(int n, int m)
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rand.Next(-10, 10);
        }

        public Arrays2D(int a_length, int b_length)
        {
            X_length = a_length;
            Y_length = b_length;

            a = new int[x_length, y_length];
            generate(a_length, b_length);
        }

        public Arrays2D()
        {
            a = new int[x_length, y_length];
            generate(x_length, y_length);
        }

        public void Multiplesof5(ListBox listBox1)
        {
            for (int i = 0; i < X_length; i++)
            {
                for (int j = 0; j < Y_length; j++)
                {
                    if (a[i, j] % 5 == 0)
                    {
                        string message = $"A[{i + 1}, {j + 1}] = {a[i, j]}";
                        listBox1.Items.Add(message);
                    }
                }
            }
        }
    }
}
