using System;
using System.Collections.Generic;
using System.Linq;


public class Solution1309 
{
    public string FreqAlphabets(string s) 
    {
        
        if(string.IsNullOrEmpty(s)) return s;
        List<char> results = new List<char>();
        int i = s.Length -1;
        while(i>=0)
        {
            var num = 0;
            if(s[i] == '#')
            {
                num = 10*(s[i-2] - '0') + (s[i-1] - '0');
                i = i - 3;
            }
            else
            {
                num = s[i] - '0';
                i --;
            }
            results.Add(Convert.ToChar('a'+num - 1));
        }

        results.Reverse();
        return string.Join("", results);
    }
}