using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionMock052502
{
    public int DistributeCoins(TreeNode root) {
        DSFSMove(root);

        return move;
    }

    private int move = 0;

    public int DSFSMove(TreeNode node)
    {
        if(node == null) return 0;

        int L = DSFSMove(node.left);
        int R = DSFSMove(node.right);

        move += Math.Abs(L) + Math.Abs(R);

        return node.val + L + R -1;
    }

    private readonly Dictionary<int, int[]> _moves = new Dictionary<int, int[]>() { 
        { 0, new[] { 4, 6 } },
        { 1, new[] { 6, 8 } },
        { 2, new[] { 7, 9 } },
        { 3, new[] { 4, 8 } },
        { 4, new[] { 0, 3, 9 } },
        { 5, new int[0] },
        { 6, new[] { 0, 1, 7 } },
        { 7, new[] { 2, 6 } },
        { 8, new[] { 1, 3 } },
        { 9, new[] { 2, 4 } }
    };

    private const int MOD = 1000000007;

    public int KnightDialer(int N) {
         int[,] dp = new int[2, 10];        
        int sum = 0;
        
        for (int i = 0; i < N; i++) {
            for (int num = 0; num < 10; num++) {
                if (i == 0) { dp[1, num] = 1; continue; }

                foreach (int move in _moves[num]) {
                    dp[1, num] += dp[0, move]; 
                    dp[1, num] %= MOD;
                }
            }
            
            for (int num = 0; num < 10; num++) {
                dp[0, num] = dp[1, num];
                dp[1, num] = 0;
            }
        }
        
        for (int num = 0; num < 10; num++) {
            sum += dp[0, num];   
            sum %= MOD;
        }
        
        return sum;
    }
}