using System;

namespace ArrayRotationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 3, 8, 9, 7, 6 };
            solution(A, 3);
            Console.ReadLine();

            //solution3(A, 3);
            //Console.ReadLine();
        }


        public static int[] solution(int[] A, int K)
        {
            //Thought Process
            //---> I need to copy what is in the first index into the second index
            //--> before copying the value of the first index of the array in to the second index postion, i need to keep track of the value in the second Index postion. 
            //So as to not loose track of it
            // ---> swap value in the second index postion with the first index position value
            //--> Repeat the process.. 
            //--> cater for the index out of range bounds exception edgecase
            //--> replace the last value into the first index position

            //sample
            //[3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
            //[6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
            //[7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
            if (A.Length > 1)
            {
                for (int j = 0; j < K; j++)
                {
                    // sample {1, 2 , 3, 4 } ==> cuurentValue = 1, nextValue = 2 
                    var currentValue = A[0];
                    var nextValue = A[1];
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        nextValue = A[i + 1];
                        A[i + 1] = currentValue;
                        currentValue = nextValue;
                        //currentValue++;
                    }
                    A[0] = nextValue;
                }
            }
            return A; 
        }

        //public static int[] solution2(int[] A, int K)
        //{
        //    if(A.Length > 1)
        //    {
        //        //sample { 6, 7, 8, 9  } --> {9, 6, 7, 8}
        //        int currentValue = A[0];
        //        int nextValue = A[1];

        //        //int[] newArray = new int[4];
        //        for (int i = 0; i < A.Length-1; i++)
        //        {
        //            nextValue = A[i + 1];
        //            A[i + 1] = currentValue;

        //            currentValue = nextValue;

        //        }

        //        A[0] = nextValue;
               
        //    }
        //    return A;

        //}


        public static int[] solution3(int[] A, int K)
        {
            //Thought Process
            //---> I need to copy what is in the first index into the second index
            //--> before copying the value of the first index of the array in to the second index postion, i need to keep track of the value in the second Index postion. 
            //So as to not loose track of it
            // ---> swap value in the second index postion with the first index position value
            //--> Repeat the process.. 
            //--> cater for the index out of range bounds exception edgecase
            //--> replace the last value into the first index position

            //sample
            //[3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
            //[6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
            //[7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
            if (A.Length > 1)
            {
                for (int j = 0; j < K; j++)
                {
                    int NextValue = 0; int currentValue = A[0];
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        NextValue = A[i + 1];
                        //currentValue = A[i + 1 - 1];
                        //currentValue = A[i];
                        A[i + 1] = currentValue;

                        currentValue = NextValue;
                    }

                    A[0] = NextValue;
                }
            }
            return A;
        }
    }
}
