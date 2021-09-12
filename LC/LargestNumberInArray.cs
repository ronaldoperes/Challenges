/*
 You are given an integer array nums where the largest integer is unique.

Determine whether the largest element in the array is at least twice as much as every other number in the array. If it is, return the index of the largest element, or return -1 otherwise.


Example 1:

Input: nums = [3,6,1,0]
Output: 1
Explanation: 6 is the largest integer.
For every other number in the array x, 6 is at least twice as big as x.
The index of value 6 is 1, so we return 1.
Example 2:

Input: nums = [1,2,3,4]
Output: -1
Explanation: 4 is less than twice the value of 3, so we return -1.
Example 3:

Input: nums = [1]
Output: 0
Explanation: 1 is trivially at least twice the value as any other number because there are no other numbers.
 */

using System;
using System.Linq;

namespace LC
{
    public static class LargestNumberInArray
    {
        public static int DominantIndex(int[] nums)
        {
            int result = -1;

            if (nums.Length == 1) return 0;

            // Get largest number and respective index
            int max = nums.Max();
            int tempResult = Array.IndexOf(nums, max);
            
            Array.Sort(nums);

            // Sort array in desc order and get a new one skipping first number as we know it is the largest
            var arr = nums.Reverse().Select(x => x * 2).ToArray().Skip(1);

            int newMax = arr.Max();

            if (max >= newMax)
            {
                result = tempResult;
            }

            return result;
        }
    }
}
