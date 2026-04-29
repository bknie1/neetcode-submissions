public class Solution {
    public bool IsAnagram(string s, string t) {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) return true;
        if (s.Length != t.Length) return false;

        int[] counts = new int[26];
        for(var i = 0; i < s.Length; i++) {
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }

        foreach (int count in counts) {
            if (count != 0) return false;
        }

        return true;
    }
}