using System;
using System.Collections.Generic;
using System.Linq;

public class Solution621
{
    public int LeastInterval2(char[] tasks, int n) {
    {
        int[] freqMap = new int[26];
        foreach(var c in tasks)
        {
            freqMap[c - 'A'] ++;
        }
        
        Array.Sort(freqMap);
        int time =0;
        while(freqMap[25] > 0)
        {
            int i = 0;
            while(i <= n)
            {
                if (freqMap[25] == 0)
                    break;
                
                if(25 - i >= 0 && freqMap[25 - i] > 0)
                {
                    freqMap[25 - i] --;
                }
                time ++;
                i++;
            }
            Array.Sort(freqMap);
        }

        return time;
    }
}

    public int LeastInterval(char[] tasks, int n)
    {
        int[] map = new int[26];
        foreach (char c in tasks)
            map[c - 'A']++;
        Array.Sort(map);
        int time = 0;
        while (map[25] > 0)
        {
            int i = 0;
            while (i <= n)
            {
                if (map[25] == 0)
                    break;
                if (i < 26 && map[25 - i] > 0)
                    map[25 - i]--;
                time++;
                i++;
            }
            Array.Sort(map);
        }
        return time;
    }
}