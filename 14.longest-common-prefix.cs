using System;
using System.Collections.Generic;
using System.Linq;

public class Solution14
{
    public string LongestCommonPrefix(string[] strs) {
        string result = string.Empty;
        if(strs ==null || strs.Length ==0)
        {
            return result;
        }

        // start with first string.
        for(int i =0; i < strs[0].Length; ++i)
        {
            char x = strs[0][i];
            bool match = true;
            // try to match each string on this position
            foreach(var str in strs)
            {
                // if the str is short or not match on this position, return false and stop.
                if(i>= str.Length || str[i]!= x)
                {
                    match =false;
                    break;
                }
            }
            
            if(match == true)
            {
                result = result + x;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}