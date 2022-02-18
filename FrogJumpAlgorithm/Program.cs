using System;

namespace FrogJumpAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = solution(10, 85, 30);
            //Console.ReadLine();

            
            int result = solution(1, 5, 2);
            Console.ReadLine();

        }

        public static int solution(int X, int Y, int D)
        {
            //--> Position X to Position Y 
            //--> looping from Postion X to Position Y with Distance
            //--> do a check if X is greater than or equal to Y value
            //--> track the number of loop execution to track number of jumps
            // --> return number of loop execution if X is greater than or equal to Y

            int jumpTracker = 0;
            for (int i = X; i < Y;)
            {
                int jump = X + D;
                jumpTracker++;
                X = jump;
                i = jump;
                if (jump >= Y)
                {
                    return jumpTracker;
                }
                //jumpTracker++;
            }
            return jumpTracker;
        }
    }
}
