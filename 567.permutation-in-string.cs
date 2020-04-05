
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution567
{
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Contains(s1)) return true;
        Dictionary<char, int> map1 = new Dictionary<char, int>();
        Dictionary<char, int> map2 = new Dictionary<char, int>();
        foreach(var c in s1)
        {
            if(!map1.ContainsKey(c)) 
            {
                map1.Add(c, 1);
                map2.Add(c, 0);
            }
            else
            {
                map1[c]++;
            }
        }

        int len = s1.Length;
        
        int start =0;
        int end =0;
        while(end < s2.Length)
        {
            if(map2.ContainsKey(s2[end]))
            {
                map2[s2[end]] ++;
                if(map2[s2[end]]  <= map1[s2[end]] ) len--;
            }
            end ++;
            //Console.Write(len);
            if(end - start > s1.Length)
            {
                if(map2.ContainsKey(s2[start]))
                {
                    map2[s2[start]] --;
                    if(map2[s2[start]]  < map1[s2[start]] ) len++;
                }
                start ++;
            }
            
            //Console.WriteLine(len);
            if(len == 0)
            {
                return true;
            }
        }

        return false;
    }
}