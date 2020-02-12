using System;
using System.Collections.Generic;
using System.Linq;

public class Solution932
{
    public int[] BeautifulArray(int N) {
        List<int> results = new List<int>();
        results.Add(1);
        //start with single element in the array 1
        //Expand the elements by doubling the size and put odd first and even later.
        // 1-> 2-> 4-> 8
        while(results.Count < N)
        {
            List<int> tmp = new List<int>();
            foreach(var res in results)
            {
                tmp.Add(2*res-1);
            }
            foreach(var res in results)
            {
                tmp.Add(2*res);
            }
        }

        // keep the current position, and remove number below the N.
        return results.Where(n => n<= N).ToArray();
    }
}