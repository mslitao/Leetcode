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
            
            for(int j = i; j > (i*0.5 + 7); --j)
            {
                if(ageMap[j] == 0)
                    continue;
                
                if(j == i) result += ageMap[i] * (ageMap[i] - 1);
                else result += ageMap[j]*ageMap[i];
            }
        }

        return result;
    }
}