using System;

namespace Science_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Matrix matrix = new Matrix();
            matrix.Writemyarray();
            matrix.Writemyarraytrans();
            matrix.DoMinor();

            Gausse gausse = new Gausse();

            gausse.DoGuess();
                       

            Console.ReadKey();
           
        }
    }
}
