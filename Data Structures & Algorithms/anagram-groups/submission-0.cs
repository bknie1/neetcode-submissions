public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length <= 0) return null;
        var map = new Dictionary<string, List<string>>();

        foreach(var raw in strs) {
            var sorted = new string(raw.OrderBy(c => c).ToArray()); // Create shared key

            if(!map.ContainsKey(sorted)) {
                map.Add(sorted, new List<string>()); // Add if not present
            }

            map[sorted].Add(raw); // Add raw to raw's key bucket
        }

        return new List<List<string>>(map.Values);
    }
}
