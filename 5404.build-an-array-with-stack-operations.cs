using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution5404 
{
    public IList<string> BuildArray(int[] target, int n) {
        List<string> results = new List<string>();
        int start = 0;
        for(int i = 1; i <= n && start < target.Length; ++i)
        {
            if(i == target[start])
            {
                results.Add("Push");
                start ++;
            }
            else
            {
                results.Add("Push");
                results.Add("Pop");
            }
        }

        return results;
    }
}