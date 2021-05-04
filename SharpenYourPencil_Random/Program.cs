using System;

namespace SharpenYourPencil_Random
{
    class Program
    {

        /*
            The methods of the Random class:
            Equals
            GetHashCode
            GetType
            Next
            NextDoubles
            NextBytes
            ToString
            
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Random random = new Random();
            double[] randomDoubles = new double[20];

            for(int i = 0; i < 20; i++ )
            {
                double value = random.NextDouble();
                randomDoubles[i] = value;

                Console.WriteLine(randomDoubles[i].ToString());


            }

        }
    }
}
