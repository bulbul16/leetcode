using System.Collections;

namespace TwoSum
{

    /// <summary>
    /// Solution 1: Brute force method
    /// Complexity: O(n^2)
    /// </summary>
    public class Solution1
    {
         public static int[] TwoSum(int[] nums, int target)
        {
            int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        twoSum[0] = i;
                        twoSum[1] = j;

                        return twoSum;
                    }
                }
            }
            return twoSum;
        }
    }




    /// <summary>
    /// Optimized solution
    /// Complexity: O(n)
    /// </summary>
    public class Solution2
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            //For fast retrival
            Hashtable hashtable = new Hashtable();
            hashtable[nums[0]] = 0; //hashtable["key"] = value;

            for (int i = 1; i < nums.Length; i++)
            {
                // difference or complement
                int diff = target - nums[i];

                // if this complement present in the list 
                // return the index of the difference and current number
                if (hashtable.Contains(diff))
                {
                    return new int[2] { (int)hashtable[diff], i };
                }
                else
                {
                    hashtable[nums[i]] = i;
                }
            }

            return null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,7,11,15};
            int target = 9;

            int[] twoSum = Solution1.TwoSum(nums, target);
            twoSum = Solution1.TwoSum(nums, target);
        }
    }
}
