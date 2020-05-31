using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionMock0522 {
    public int BulbSwitch(int n) {
        return (int)Math.Sqrt(n);
        /*
        bool[] bulbs = new bool[n];
        Array.Fill(bulbs, true);

        for(int start = 1; start < n; ++ start)
        {
            for(int j = start; j < n ; j = j + start + 1)
            {
                bulbs[j] = !bulbs[j];
            }
        }

        int result = 0;
        for(int i = 0; i < n; ++ i)
        {
            if(bulbs[i]) result ++;
        }

        return result;*/
    }
}