//Medium

using System.Linq; 
public class Solution
{
    public string ReverseWords(string sentence)
    {

        return string.Join(' ', sentence.Split(' ').Reverse().Where(word => word.Length > 0));
//If you do not want to use LINQ, you can simply iterate through the same and get the same thing done. I simply chose a shortcut

    }
}
