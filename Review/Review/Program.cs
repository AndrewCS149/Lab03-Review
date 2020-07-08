using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Review
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Challenge 1: GetProduct()
            Console.Write("Please enter 3 numbers sepearted by a space: ");
            string input1 = Console.ReadLine();
            GetProduct(input1);

            // Challenge 2: GetAvg()
            int[] getAvgData = GetAvgSetup();
            GetAvg(getAvgData);
        }

        /// <summary>
        /// Challenge 1: Given user input as a string, return the product of the first
        /// three numbers
        /// </summary>
        /// <param name="input">User input as a string</param>
        /// <returns>Product of first three numbers</returns>
        public static int GetProduct(string input)
        {
            string[] strArr = input.Split(' ');

            if (strArr.Length < 3)
                return 0;

            int product = 1;
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(strArr[i], out int returnVal))
                    product *= returnVal;
                else
                {
                    product *= 1;
                }
            }

            Console.WriteLine($"Product: {product}");
            return product;
        }

        /// <summary>
        /// Gets the user input to be used for challenge 2
        /// </summary>
        /// <returns>The integer array to be used for challenge 2</returns>
        public static int[] GetAvgSetup()
        {
            Console.Write("Please enter a number between 2-10: ");
            string input = Console.ReadLine();
            int toNum = Convert.ToInt32(input);

            int[] numArr = new int[toNum];
            for (int i = 1; i <= toNum; i++)
            {
                Console.Write($"{i} of {toNum} - Enter a number: ");
                string inputNum = Console.ReadLine();

                while (!(int.TryParse(inputNum, out int returnVal)) ||
                        int.Parse(inputNum) < 0)
                {
                    Console.WriteLine("Please enter a number positive, real number.");
                    Console.Write($"{i} of {toNum} - Enter a number: ");
                    inputNum = Console.ReadLine();
                }
                numArr[i - 1] = int.Parse(inputNum);
            }
            return numArr;
        }

        public static int GetAvg(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            int avg = sum / nums.Length;
            Console.WriteLine($"Average: {avg}");
            return avg;
        }
    }
}
