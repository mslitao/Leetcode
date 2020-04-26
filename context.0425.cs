using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution0425
{
    public int MaxScore(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        int[] dp1 = new int[s.Length];
        int[] dp2 = new int[s.Length];
        
        int zeros = 0;
        int ones = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] == '0')
            {
                zeros++;
            }
            dp1[i] = zeros;

            if(s[s.Length - i - 1] == '1')
            {
                ones++;
            }
            dp2[s.Length - i - 1] = ones;
        }
        int result = 0;
        for(int i = 0; i < s.Length - 1; ++i)
        {
            if(dp1[i] + dp2[i + 1] > result)
                result = dp1[i] + dp2[i + 1];
        }

        return result;
     }

    public int MaxScore(int[] cardPoints, int k) {
        if(cardPoints == null || cardPoints.Length == 0 || k <= 0) return 0;
        int l = cardPoints.Length - k;
        
        int start = 0;
        int end = 0;
        int sum = 0;
        int minValue = int.MaxValue;
        int total = 0; 
        while(end < cardPoints.Length)
        {
            total += cardPoints[end];
            sum += cardPoints[end ++];

            if(end - start > l)
            {
                sum -= cardPoints[start];
                start ++;
            }

            if(end - start == l )
            {
                minValue = Math.Min(minValue, sum);
            }
        }
        
        if(minValue == int.MaxValue)
        {
            minValue = 0;
        }

        return total - minValue;
    }

    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        List<int> results = new List<int>();
        if(nums == null || nums.Count == 0 ) return results.ToArray();
        int m = nums.Count;
        int[] visited = new int[m];
        int i = 0;
        int j = 0;
        
        for(i = 0; i < m; ++i)
        {
            int next = i; 
            j = 0;
            while(next >= 0)
            {
                if(j < nums[next].Count)
                {
                    visited[next] = j;
                    results.Add(nums[next][j]);
                }
                next --;
                j ++;
            }
        }

        for(int k = m -1; k >=0; --k)
        {
            j = visited[k] + 1;
            while(j < nums[k].Count)
            {
                int next = k;
                int nextj = j;
                while(next >= 0)
                {
                    if(nextj < nums[next].Count)
                    {
                        visited[next] = nextj;
                        results.Add(nums[next][nextj]);
                    }
                    next --;
                    nextj ++;
                }
                ++j;
            }
        }

        return results.ToArray();
    }

    public int[] FindDiagonalOrderQueue(IList<IList<int>> nums) {
        Queue<int> queueR = new Queue<int>();
        Queue<int> queueC = new Queue<int>();

        queueR.Enqueue(0);
        queueC.Enqueue(0);
        List<int> results = new List<int>();
        while(queueR.Any())
        {
            var r = queueR.Dequeue();
            var c = queueC.Dequeue();
            results.Add(nums[r][c]);

            if(c == 0 && r+ 1 < nums.Count)
            {
                queueR.Enqueue(r + 1);
                queueC.Enqueue(c);
            }
            if(c + 1 < nums[r].Count)
            {
                queueR.Enqueue(r);
                queueC.Enqueue(c+ 1);
            }
        }

        return results.ToArray();
    }
}

