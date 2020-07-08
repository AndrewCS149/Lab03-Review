using System;

namespace Review
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Challenge 1: GetProduct
            Console.Write("Please enter 3 numbers sepearted by a space: ");
            string input1 = Console.ReadLine();
            Console.WriteLine(GetProduct(input1));


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

            return product;
        }
    }
}
