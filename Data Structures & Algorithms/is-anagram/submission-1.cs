public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s == null || t == null) return false;
        if(s.Length != t.Length) return false;

        // Add first string letters then subtract second string letters
        var intersection = new Dictionary<char, int>();

        for(var i = 0; i < s.Length; i++) {
            var currentFirst = s[i];
            var currentSecond = t[i];
            intersection = processCurrentLetter(intersection, currentFirst);
            intersection = processCurrentLetter(intersection, currentSecond, isRemoving: true);
        }

        if(intersection.Any()) return false;
        return true; // No diff tallied? Anagram
    }

    Dictionary<char, int> processCurrentLetter(Dictionary<char, int> d, char c, bool isRemoving = false) {
        if (d.ContainsKey(c)) {
            if (isRemoving) d[c] -= 1;
            else d[c] += 1;
            if (d[c] == 0) d.Remove(c);
            return d;
        }

        if (!isRemoving) d.Add(c, 1);
        else d.Add(c, -1);
        return d;
    }
}
