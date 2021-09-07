// Leetcode - Introduction to Array
//
//https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC
{
    public class PivotArray
    {
        public int PivotIndex(int[] nums)
        {
            int result = -1;
            if (nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result = GetPivot(nums, i);
                    if (result != -1)
                    { break; }
                }
            }
            return result;
        }

        private static int GetPivot(int[] num, int index)
        {
            int result = -1;
            int left = 0;
            int right = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (i < index)
                {
                    left += num[i];
                }
                else if (i > index)
                {
                    right += num[i];
                }
            }

            if (left == right)
            {
                result = index;
            }

            return result;
        }



    }
}
