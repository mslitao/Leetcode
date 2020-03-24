using System;
using System.Collections.Generic;
using System.Linq;

public class Solution904 {
    public int TotalFruit(int[] tree) {

        if(tree == null || tree.Length ==0) return 0;

        Dictionary<int, int> dict = new Dictionary<int, int>();

        int start =0;
        int end = 0;
        int result = 0;
        while(end < tree.Length)
        {
            if(!dict.ContainsKey(tree[end]))
            {
                dict.Add(tree[end], 0);
            }
            dict[tree[end]] = dict[tree[end]] + 1;

            end++;
            while(dict.Count >2)
            {
                dict[tree[start]] = dict[tree[start]]  - 1;

                if(dict[tree[start]] ==0)
                    dict.Remove(tree[start]);

                start++;
            }

            result = Math.Max(result, end - start);
        }

        return result;
    }
}