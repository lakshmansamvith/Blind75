//Solution can be further optimized, get back to this. 

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        //Boolean Array which stores which kid has the highest number of candies
        bool[] isHighest = new bool[candies.Length];
        int totalCandies = 0;

        for(int i= 0; i < candies.Length; i++)
        {
            totalCandies = candies[i] + extraCandies;
            if (totalCandies >= candies.Max())
                isHighest[i] = true;
            else
                isHighest[i] = false; 
        }

        return isHighest;
    }
}
