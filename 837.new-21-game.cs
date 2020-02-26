using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution837
{
    public double New21Game(int N, int K, int W) {
        int maxPoints = K - 1 + W;
        double[] dp = new double[maxPoints + 1];

        for (int lastPoints = K; lastPoints <= maxPoints; lastPoints++)
        {
            dp[lastPoints] = (lastPoints <= N ? 1 : 0);
        }

        double sum = 0;
        for (int nextDraw = 1; nextDraw <= W; nextDraw++)
        {
            sum += (dp[K - 1 + nextDraw] / W);
        }

        for (int points = K - 1; points >= 0; points--)
        {
            dp[points] += sum;
            sum -= (dp[points + W] / W);
            if (points != 0)
            {
                sum += (dp[points] / W);
            }
        }

        return dp[0];
    }
}