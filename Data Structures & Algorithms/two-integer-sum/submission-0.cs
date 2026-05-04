public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length <= 0) return null;

        var d = new Dictionary<int, int>(); // number, loc/index of number

        for(var i = 0; i < nums.Length; i++) {
            var current = nums[i];
            var seeking = target - current; // What's the compliment?
            if(d.ContainsKey(seeking)) {
                return new int[] {d[seeking], i};
            }

            d.Add(current, i);

        }

        return null;
    }
}
