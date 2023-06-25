using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0, j = 0;
        StringBuilder stringValue = new StringBuilder();
        while (i < word1.Length && j < word2.Length)
        {
            stringValue.Append(word1[i]).Append(word2[j]);
            i++; 
            j++; 

        }

        while (i < word1.Length)
        {
            stringValue.Append(word1[i]);
            i++;
        }

        while (j < word2.Length)
        {
            stringValue.Append(word2[j]);
            j++;
        }
        return stringValue.ToString();
    }
}
