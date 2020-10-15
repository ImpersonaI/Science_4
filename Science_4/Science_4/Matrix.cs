using System;
using System.Collections.Generic;
using System.Text;

namespace Science_4
{
    class Matrix
    {
        double[,] myArr = 
        {

            {0.08, 0.064, 0.9, 0.75},

            {0.06, 0.467, 0.107, 0.4},

            {1.65, 0.533, 0.094, 0.277},

            {0.046, 0.85, 0.2, 0.4}

        };

        double[,] myArrTrans =
        {

            {0.021, -0.176, 0.62, -0.294},

            {-0.27, -1.533, 0.012, 2.031},

            {1.117, -4.468, 0.043, 2.344},

            {0.014, 5.511, -0.119, -2.954}

        };

        double[,] resultOfMul =
        {

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0}

        };

        double[] b = {9.592, 6.862, 32.278, 10.198};

        double[] bb = { 16.005, 7.998, 5.343, 3.988 };

        double op = 0.222;


        //исходный массив

        public void Writemyarray()
        {

            Console.WriteLine("Исходная матрица");

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    Console.Write(myArr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        
        //транспанированный массив

        public void Writemyarraytrans()
        {

            Console.WriteLine("Обратная матрица:");
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    Console.Write(myArrTrans[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }


        public void DoMinor()
        {
            Console.WriteLine("x = A^(-1) * b = ");
            for (int i = 0; i < 4; i++)
            {
                                
                for (int j = 0; j < 4; j++)
                {


                    for (int k = 0; k < 4; k++)
                    {
                        resultOfMul[i,j] += myArrTrans[k, j] * b[k];
                       
                    }

                    

                }
                Console.Write(bb[i] + "\t");
            }
        }

    }

}
