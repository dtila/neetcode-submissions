public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0)
            return 0;

        int rob1 = 0;
        int rob2 = 0;

        // [rob1, rob2, k, k+1 ]
        for (int k=0 ; k<nums.Length ; k++) 
        {
            var current = Math.Max(rob2, rob1 + nums[k]);
            rob1 = rob2;
            rob2 = current;
        }

        return rob2;
    }
}
