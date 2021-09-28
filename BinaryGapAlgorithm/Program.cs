using System;

namespace BinaryGapAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a Number:");
            //var number = Convert.ToInt32(Console.ReadLine());

            //var binaryRep = Convert.ToString(number, 2);

            //for (int i = 0; i < binaryRep.Length; i++)
            //{
            //    var gap = 0;
            //    if(binaryRep[i] == '1')
            //    {

            //    }

            //}



            //Solution 2
            Console.WriteLine("Enter a Number:");
            var number = Convert.ToInt32(Console.ReadLine());

            var binaryRep = Convert.ToString(number, 2);

            int count = 0, maxCount = 0;
            for (int i = 0; i < binaryRep.Length; i++)
            {
                if(binaryRep[i] == '0')
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }
           // return maxCount;
            
            Console.WriteLine("This is the Binary Gap:{0}", maxCount);
        }
    }
}
