using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 1, 2, 3, 5, 8 };
            foreach(int num in numArr)
            {
                if (num % 2 == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine(num);
                    Console.ReadLine();
                }
            }

        }
    }
}
