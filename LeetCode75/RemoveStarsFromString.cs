using System.Text;

public class Solution
{
    public string RemoveStars(string s)
    {
        StringBuilder modified = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                modified.Length = modified.Length - 1;
            }
            else { 
                modified.Append(s[i]);
            }
        }
        return modified.ToString(); 
    }
}
