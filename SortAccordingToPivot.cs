//Without Using LINQ, check below for a solution using LINQ
using System.Collections;

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();
        List<int> pivots = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                lesser.Add(nums[i]);
            }

            else if (nums[i] > pivot)
            {
                greater.Add(nums[i]);
            }

            else
            {
                pivots.Add(nums[i]); 
            }
        }
        lesser.AddRange(pivots);
        lesser.AddRange(greater);
        return lesser.ToArray(); 
    }
}


//LINQ Solution 
/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        List<int> lesser = nums.Where(x => x < pivot).ToList();
        return lesser.Concat(nums.Where(x => x == pivot)).Concat(nums.Where(x => x > pivot)).ToArray();
    }
}
*/

