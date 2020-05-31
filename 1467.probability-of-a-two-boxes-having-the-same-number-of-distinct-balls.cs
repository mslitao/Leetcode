using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1467
{
    public double GetProbability(int[] balls) {
        long all = allCases(balls, 0, 0, 0);
        long target = targetCases(balls, 0, 0, 0,0, 0);

        return 1.0*target/all;
    }

    public long allCases(int[] balls, int pos, int f, int s)
    {
        if(pos == balls.Length) 
        {
            return f == s? 1:0;
        }

        long cnt = 0;
        for(int i = 0; i <= balls[pos]; ++i)
        {
            cnt+=allCases(balls, pos+1, f+ i, s+balls[pos] - i)
                 * nCr(balls[pos], i);
        }

        return cnt;
    }

    public long targetCases(int[] balls, int pos, int f, int s, int disF, int disS)
    {
        if(pos == balls.Length) 
        {
            return f == s && disF == disS? 1:0;
        }

        long cnt = 0;
        for(int i = 0; i <= balls[pos]; ++i)
        {
            cnt+=targetCases(balls, pos+1, f+ i, s+balls[pos] - i, disF + (i == 0? 0: 1), disS + (balls[pos] == i? 0:1)) 
                 * nCr(balls[pos], i);
        }

        return cnt;
    }

    long nCr(long n, long r) { 
        if(r ==0 || n == r) return 1;
        return fact(n) / (fact(r) * fact(n - r)); 
    } 
    
    long fact(long n) { 
        long res = 1; 
        for (int i = 2; i <= n; i++) 
            res = res * i; 
        return res; 
    } 
}