public class Solution {
    public int MaxProfit(int[] prices) {
        // buy low
        // sell high
        // single day to buy per array

        var maxProfit = 0;
        var l = 0;
        var r = 1;

        while (r < prices.Length)
        {
            var profit = prices[r] - prices[l];
            if (profit > 0)
            {
                maxProfit = Math.Max(profit, maxProfit);
            } 
            else
            {
                l = r;
            }

            r++;
        }

        return maxProfit;
    }
}
