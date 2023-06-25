public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        for (var i = index; i < nums.Length; i++)
        {
            nums[index] = 0;
            index++;
        }

    }
}
