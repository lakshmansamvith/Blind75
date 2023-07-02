//Medium
public class Solution {
    public string RemoveStars(string s) {
        StringBuilder sb = new StringBuilder();

        foreach(char character in s){
            if(character == '*'){
                sb.Length -= 1;
            }
            else{
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}