using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

namespace Review
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Challenge 1: GetProduct()
            //Console.Write("Please enter 3 numbers sepearted by a space: ");
            //string input1 = Console.ReadLine();
            //GetProduct(input1);

            // Challenge 2: GetAvg()
            //double[] getAvgData = GetAvgSetup();
            //GetAvg(getAvgData);

            // Challenge 3: PrintDiamond()
            //Console.Write("Please enter the amount of rows you would like\n" +
            //              "the diamond to be (enter odd number for symetrical purposes): ");
            //int rows = int.Parse(Console.ReadLine());
            //PrintDiamond(rows);

            // Challenge 4: MaxDupe()
            int[] nums = new int[]{1,1,2,2,2,2,2,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1};
            MaxDupe(nums);

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
        public static double[] GetAvgSetup()
        {
            Console.Write("Please enter a number between 2-10: ");
            string input = Console.ReadLine();
            int toNum = Convert.ToInt32(input);

            double[] numArr = new double[toNum];
            for (int i = 1; i <= toNum; i++)
            {
                Console.Write($"{i} of {toNum} - Enter a number: ");
                string inputNum = Console.ReadLine();

                while (!(double.TryParse(inputNum, out double returnVal)) ||
                        double.Parse(inputNum) < 0)
                {
                    Console.WriteLine("Please enter a number positive, real number.");
                    Console.Write($"{i} of {toNum} - Enter a number: ");
                    inputNum = Console.ReadLine();
                }
                numArr[i - 1] = double.Parse(inputNum);
            }
            return numArr;
        }

        /// <summary>
        /// Returns the avg of the passed in array
        /// </summary>
        /// <param name="nums">Int array</param>
        /// <returns>The avg of the array</returns>
        public static double GetAvg(double[] nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }

            double avg = sum / nums.Length;
            Console.WriteLine($"Average: {avg}");
            return avg;
        }

        /// <summary>
        /// Prints a diamond shape to the console
        /// </summary>
        /// <param name="rows">How many rows the diamond will have</param>
        static void PrintDiamond(int rows)
        {
            string diamond = "*";
            int mid = rows / 2;
            diamond = diamond.PadLeft(mid + 1);
            for (int i = 0; i < rows; i++)
            {
                if (i < mid)
                {
                    Console.WriteLine(diamond);
                    diamond = diamond.Substring(1);
                    diamond += "**";
                }
                else if (i == mid)
                    Console.WriteLine(diamond);
                else
                {
                    diamond = diamond.Substring(0, diamond.Length - 2);
                    diamond = " " + diamond;
                    Console.WriteLine(diamond);
                }
            }
        }

        /// <summary>
        /// Given an array of ints, return the number that appears the most
        /// </summary>
        /// <param name="nums">Array of ints</param>
        /// <returns>Number that appears the most</returns>
        public static int MaxDupe(int[] nums)
        {
            int max = 0;
            int num = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        counter++;
                }
                if (counter > max)
                {
                    num = nums[i];
                    max = counter;
                }
            }
            Console.WriteLine(num);
            return num;
        }
    }
}
