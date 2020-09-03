using System;

namespace avoidObstacles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] inputArray = new int[length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("Enter an element: ");
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(avoidObstacles(inputArray));
            Console.ReadLine();
        }
        static int avoidObstacles(int[] inputArray)
        {
            int num = 2;
            bool isRight = false;
            while (isRight == false)
            {
                isRight = true;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % num == 0)
                    {
                        num++;
                        isRight = false;
                        break;
                    }
                }
            }
            return num;
        }
    }
}
