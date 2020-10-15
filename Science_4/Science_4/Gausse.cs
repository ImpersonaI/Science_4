using System;
using System.Collections.Generic;
using System.Text;

namespace Science_4
{
    class Gausse
    {

        public void DoGuess()
        {
            Console.WriteLine();
            double s = 0;
            int n = 4; //размерность системы           
            double[] x = new double[n];

            for (int i = 0; i < n; i++)

                x[i] = 0;

            double[,] a =
            {

            {0.08, 0.064, 0.9, 0.75},

            {0.06, 0.467, 0.107, 0.4},

            {1.65, 0.533, 0.094, 0.277},

            {0.046, 0.85, 0.2, 0.4}

            };

            double[] b = { 9.592, 6.862, 32.278, 10.198 };

            for (int k = 0; k < n - 1; k++)
            {

                for (int i = k + 1; i < n; i++)
                {

                    for (int j = k + 1; j < n; j++)
                    {

                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }

                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }

            for (int k = n - 1; k >= 0; k--)
            {

                s = 0;

                for (int j = k + 1; j < n; j++)

                    s = s + a[k, j] * x[j];

                x[k] = (b[k] - s) / a[k, k];
            }

            Console.WriteLine();
            Console.WriteLine("Система имеет следующие решения:");

            for (int i = 0; i < x.Length; i++)
            {
                
                Console.WriteLine(x[i] + "\t");
            }
          
        }
    }
}
