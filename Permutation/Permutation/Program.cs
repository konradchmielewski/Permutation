using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Permutation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numGroup1;
            string numGroup2;
            int[] arr1 = { 0 };
            int[] arr2 = { 0 };

            while (arr1.Length != 11)
            {
                Console.WriteLine("Please provide first group of eleven integers with spaces in between them.");
                numGroup1 = Console.ReadLine();
                numGroup1 = numGroup1.TrimEnd();
                arr1 = StringConvertToSortedArr(numGroup1);
            }

            while (arr2.Length != 11)
            {
                Console.WriteLine("Please provide second group of eleven integers with spaces in between them.");
                numGroup2 = Console.ReadLine();
                numGroup2 = numGroup2.TrimEnd();
                arr2 = StringConvertToSortedArr(numGroup2);
            }

            if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }

        // Method which converts string into sorted array of integers.
        public static int[] StringConvertToSortedArr(string s)
        {
            string[] StringArray = s.Split(' ');
            int[] asIntegers = StringArray.Select(token => int.Parse(token)).ToArray();
            Array.Sort(asIntegers);
            return asIntegers;
        }
    }
}