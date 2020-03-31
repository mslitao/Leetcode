using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1394 {
    public int FindLucky(int[] arr) 
    {
        if(arr == null || arr.Length ==0) return -1;

        Dictionary<int, int> numFreq = new Dictionary<int, int>();

        foreach(var num in arr)
        {
            if(!numFreq.ContainsKey(num)) 
            {
                numFreq.Add(num, 1);
            }
            else
            {
                numFreq[num] = numFreq[num] + 1;
            }
        }
        
        int result = -1;
        foreach(var item in numFreq)
        {
            if(item.Key > result && item.Value == item.Key)
            {
                result = item.Key;
            }
        }

        return result;
    }
}