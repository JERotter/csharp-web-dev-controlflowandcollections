using System;
using System.Collections.Generic;


namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numList = new List<int> {1,1,2,3,5,8,12,3,6};
            int addArr = 0;
            foreach(int num in numList)
            {
                if (num % 2 == 0)
                {
                    addArr += num;
                    
                }
            }
            Console.WriteLine(addArr);
        }
    }
}
