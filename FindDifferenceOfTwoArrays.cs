public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        List<int> list1 = nums1.Except(nums2).ToList(); //A list which gets all the elements present in nums1 and excludes the elements present in nums2 
        List<int> list2 = nums2.Except(nums1).ToList(); //A list which gets all the elements present in nums2 and excludes the elements present in nums1 

        IList<IList<int>> result = new List<IList<int>>();
        result.Add(list1);
        result.Add(list2);

        return result; 
    }
}
