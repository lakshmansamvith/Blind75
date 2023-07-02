//Medium
public class Solution {
    public int MaxOperations(int[] nums, int k) {
    Array.Sort(nums); 
    int i = 0, j = nums.Length-1, count = 0; 
    while(i < j)
    { 
        if(k == nums[i] + nums[j])
        { 
            count++; 
            i++; 
            j--; 
        }
        else if(nums[i] + nums[j] < k)
            i++; 
        else
            j--; 
    }
    return count; 
    }
}