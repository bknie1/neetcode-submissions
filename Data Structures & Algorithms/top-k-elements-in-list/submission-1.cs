public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Count nums
        // Dictionary: <int>, <int> : Number : Tally
        // Sort Dictionary
        // Return top k values

        var tally = new Dictionary<int, int>();

        foreach(int v in nums) {
            if(!tally.ContainsKey(v)) {
                tally.Add(v, 1);
            }
            else {
                tally[v]++;
            }
        }

        return tally.OrderByDescending(pair => pair.Value)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys
            .Take(k)
            .ToArray();
    }
}
