using System;
using System.Collections.Generic;
using System.Linq;

public class Solution290
{
    public bool WordPattern(string pattern, string str) 
    {
        var items = str.Split(' ');
        if(items.Length != pattern.Length) return false;

        Dictionary<char, string> patternMap = new Dictionary<char, string>();
        HashSet<string> values = new HashSet<string>();
        for(int i =0; i< items.Length; ++i)
        {
            if(patternMap.ContainsKey(pattern[i]))
            {
                if( patternMap[pattern[i]] != items[i])
                return false;
            }
            else if(values.Contains(items[i]))
            {
                return false;
            }
            else
            {
                patternMap.Add(pattern[i], items[i]);
                values.Add(items[i]);
            }
        }

        return true;
    }
}