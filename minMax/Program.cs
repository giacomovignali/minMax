using System;

namespace minMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore = new int[5] { 3, 5, 2, 4, 9 };

            int min = vettore[0];

            for(int i = 0; i < 5; i++)
            {
                if(vettore[i] < min)
                {
                    min = vettore[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
