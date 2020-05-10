using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution5405
{
    public int CountTriplets(int[] arr) {
        int n = arr.Length;
        int result = 0;
        for(int j = 1; j< n; ++j)
        {
            Dictionary<int, List<int>> mapi = new Dictionary<int, List<int>>();
            int tmp = 0;
            for(int i = j-1; i >=0; i --)
            {
                tmp = tmp ^ arr[i];

                if(!mapi.ContainsKey(tmp))
                {
                    mapi.Add(tmp, new List<int>());
                }

                mapi[tmp].Add(i);
            }

            Dictionary<int, List<int>> mapj = new Dictionary<int, List<int>>();
            tmp = 0;
            for(int k = j; k < n; ++k)  
            {
                tmp = tmp ^ arr[k];

                if(!mapi.ContainsKey(tmp))
                {
                    continue;
                }

                if(!mapj.ContainsKey(tmp))
                {
                    mapj.Add(tmp, new List<int>());
                }

                mapj[tmp].Add(k);
            }
            
            foreach(var pj in mapj)
            {
                result += pj.Value.Count * mapi[pj.Key].Count;
            }
        }

        return result;
    }
}