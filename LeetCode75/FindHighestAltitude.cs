//Easy
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int maxAltitude = 0, sum=0; 
        foreach(var altitude in gain)
        {
            sum = sum + altitude; 
            if(sum > maxAltitude)
            {
                maxAltitude = sum; 
            }
        }
        return maxAltitude; 
    }
}
