using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            //if(target >= )
            return new int[2];
        }

        public int FindIndex(int[] data, int lowerBound, int upperBound, int item)
        {
            if (lowerBound > upperBound) return lowerBound;
            int mid = (lowerBound + upperBound) / 2;

            if (data[mid] == item) return mid;

            if (data[mid] > item)
                upperBound = mid - 1;
            if (data[mid] < item)
                lowerBound = mid + 1;

            return FindIndex(data, lowerBound, upperBound, item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 3, 5, 6};
            int position = new Solution().FindIndex(numbers, 0, numbers.Length-1, 7);

            Console.WriteLine(position);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
