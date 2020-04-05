using System;
using System.Collections.Generic;
using System.Linq;


public class Solution825
{
    public int NumFriendRequests(int[] ages) {
        int[] ageMap = new int[121];
        for(int i =0; i< ages.Length; ++i)
        {
            ageMap[ages[i]]++;
        }

        int result = 0;
        /*Console.WriteLine(ageMap[16]);
        Console.WriteLine(ageMap[17]);
        Console.WriteLine(ageMap[18]);*/
        for(int i = 120; i >0; --i)
        {
            if(ageMap[i] == 0)
                continue;
            
            for(int j = i - 1; j > (i*0.5 + 7); --j)
            {
                if(ageMap[j] == 0)
                    continue;
                //Console.WriteLine(string.Format("{0}-{1}", i, j));
                result += ageMap[j]*ageMap[i];
            }
            if(ageMap[i] > 1 && i > (i*0.5 + 7))
            {
                
                //Console.WriteLine(i);
                int tmp = 1;
                for(int k = 1; k <= ageMap[i]; ++k)
                    tmp = tmp* k;
                result += tmp;
            }
            
        }

        return result;
    }
}