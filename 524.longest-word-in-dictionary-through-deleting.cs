using System;
using System.Collections.Generic;
using System.Linq;

public class Solution524
{
    public string FindLongestWord(string s, IList<string> d) {
        string result = string.Empty;

        foreach(var str in d)
        {
            if(str.Length < result.Length ) continue;
            
            int i = 0;
            foreach(var c in s)
            {
                if(i< str.Length && c == str[i]) i++;
            }
            
            if(i == str.Length && str.Length >result.Length)
            {
                result = str;
            }
            else if (i == str.Length && str.Length == result.Length && string.Compare(str, result) < 0)
            {
                result = str;
            }
        }

        return result;
    }
}