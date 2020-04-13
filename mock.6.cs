using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Mock6
{
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> map = new Dictionary<string, int>();
        for(int i =0; i< list1.Length; ++i)
        {
            map.Add(list1[i], i);
        }

        Dictionary<string, int> results = new Dictionary<string, int>();
        for(int i =0; i < list2.Length; ++i)
        {
            if(!map.ContainsKey(list2[i])) continue;

            results.Add(list2[i], map[list2[i]] + i);
        }

        ;
        List<string> res = new List<string>();
        int minVal = -1;
        foreach(var item in results.OrderBy(n => n.Value))
        {
            if(res.Count == 0)
            {
                res.Add(item.Key);
                minVal = item.Value;
            }
            else if(item.Value == minVal)
            {
                res.Add(item.Key);
            }
            else
            {
                break;
            }
        }

        return res.ToArray();
    }

    public int MinScoreTriangulation(int[] A) {
        if(A == null || A.Length <= 2) return 0;
        if (A.Length == 3)
        {
            return A[0] * A[1] * A[2];
        }

        int[,] dp = new int[A.Length, A.Length];
        checked
        {
            for (int length = 2; length < A.Length; length++)
            {
                for (int start = 0; start < A.Length; start++)
                {
                    int end = start + length;

                    if (end >= A.Length)
                    {
                        break;
                    }

                    dp[start, end] = int.MaxValue;
                    for (int k = start + 1; k < end; k++)
                    {
                        dp[start, end] = Math.Min(dp[start, end], 
                                                dp[start,k] + dp[k, end] + A[start] * A[k] * A[end]);
                    }
                }
            }
            return dp[0, A.Length - 1];
        }
    }
}