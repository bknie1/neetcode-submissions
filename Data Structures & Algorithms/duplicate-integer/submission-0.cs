public class Solution {
    HashSet<int> tracker = new HashSet<int>();

    public bool hasDuplicate(int[] nums) {
        foreach(var i in nums) {
            if(tracker.Contains(i)) return true;
            tracker.Add(i);
        }
        return false;
    }
}