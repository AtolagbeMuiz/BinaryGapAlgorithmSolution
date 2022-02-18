using System;

namespace OddOcurrencesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            int val = solution(A);
            Console.ReadLine();
        }


        public static int solution(int[] A)
        {
            //--> sample {9, 3, 9, 3, 9, 7, 9}

            // --> loop through the array
            //--> while looping, do a check with the array index loop value with the current value
            //--> if the values are not equal, return that value

            //--> reverse loop
            if(A.Length > 1)
            {
                int unpairedValue = A[0];
                for (int i = 1; i < A.Length; i++)
                {
                    unpairedValue = unpairedValue ^ A[i];
                }
                return unpairedValue;
            }
            else
            {
                return A[0];
            }
           
        }
    }
}
