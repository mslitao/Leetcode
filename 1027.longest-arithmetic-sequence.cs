using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1027
{
    public int LongestArithSeqLength(int[] A) {

        return DPHelper(A);
        //return Math.Max(Helper(A), Helper(A.Reverse().ToArray()));
    }

    public int DPHelper(int[] A) {
        List<Dictionary<int, int>> mapList = new List<Dictionary<int, int>>();

        int result = 0;
        for(int i =0; i < A.Length; ++i)
        {
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            for(int j = 0; j < i; ++j)
            {
                var diff = A[i] - A[j];
                int cnt = (mapList[j].ContainsKey(diff) ? mapList[j][diff]: 1)  + 1;

                if(!tmp.ContainsKey(diff))
                {
                    tmp.Add(diff, cnt);
                }
                else
                {
                    tmp[diff] = Math.Max(tmp[diff], cnt);
                }

                result = Math.Max(result, cnt);
            }

            mapList.Add(tmp);
        }

        return result;
    }

    // This DP solution works, but as we stat with k from 1 to (max - min), this may increase the time 
    // complexity to max- min >> n
    public int Helper(int[] A) {
        int min = A.Min();
        int max = A.Max();
        int result  = 0;
        for(int k = 1; k <= max - min; ++k)
        {
            int[] dp =  new int[A.Length];

            Dictionary<int, int> map = new Dictionary<int, int>();
            
            foreach(int a in A)
            {
                int cnt = 1;
                if(map.ContainsKey(a - k))
                {
                    cnt += map[a-k];
                }

                result = Math.Max(result, cnt);
                map[a] = cnt;
            }
        }

        return result;
    }
}