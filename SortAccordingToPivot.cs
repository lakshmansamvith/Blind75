using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        List<int> lesser = nums.Where(x => x < pivot).ToList();
        return lesser.Concat(nums.Where(x => x == pivot)).Concat(nums.Where(x => x > pivot)).ToArray();
    }
}


