using System;
using System.Collections.Generic;
using System.Linq;

public class Solution338
{
    public int[] CountBits(int num) 
    {
        List<int> bits = new List<int>();
        List<int> results = new List<int>();
        
        results.Add(0);
        bits.Add(0);
        if(num == 0)
        {
            return results.ToArray();
        }
    
        int i =1;
        while(i <= num)
        {
            i ++;

            var add = 1; 
            int cnt =0;
            var size = bits.Count;
            for(int j =0; j<size; ++j)
            {
                var bit = bits[j];
                if(bit ==0 && add ==0)
                {
                    continue;
                }
                else if(bit ==0 && add ==1)
                {
                    cnt++;
                    bits[j] =1;
                    add =0;
                }
                else if(bit ==1 && add ==0)
                {
                    cnt++;
                }
                else
                {
                    bits[j] =0;
                    add =1;
                }
            }

            if(add == 1)
            {
                bits.Add(1);
                cnt++;
            }

            results.Add(cnt);
        }

        return results.ToArray();
    }
}