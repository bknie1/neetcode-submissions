public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var tally = new Dictionary<int, int>();

        // Count nums
        foreach(int v in nums) {
            if(!tally.ContainsKey(v)) { tally[v] = 0; }
            tally[v]++;
        }

        // Sort Dictionary
        var sorted = tally
            .OrderByDescending(pair => pair.Value)
            .ToDictionary(x => x.Key, x => x.Value);
        
        // Return top k values
        var result = sorted.Keys
            .Take(k)
            .ToArray();

        return result;
    }
}
