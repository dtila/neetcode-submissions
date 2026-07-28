public class Solution {
    private static HashSet<char> set = new ();

    public int LengthOfLongestSubstring(string s) {

        var max = 0;
        var l = 0;
        var r = 0;
        set.Clear();

        // we move right, when the next character is NOT within the set, we add right, we calculate max
        // we move left, when the next character is within the set

        while (r < s.Length)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }
            
            set.Add(s[r]);
            max = Math.Max(max, r - l + 1);
            r++;
        }

        return max;
    }
}
