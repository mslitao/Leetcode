using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1249
{
    public string MinRemoveToMakeValid(string s) {
        if(string.IsNullOrEmpty(s)) return s;
        var charArray = s.ToCharArray();
        charArray = MinRemoveToMakeValid(charArray, '(', ')');
        Array.Reverse(charArray);
        charArray = MinRemoveToMakeValid(charArray, ')', '(');
        Array.Reverse(charArray);

        return new string(charArray);
    }
    public char[] MinRemoveToMakeValid(char[] charArray, char open, char close)
    {
        var result = new List<char>();
        int cnt =0;
        for(int i = 0; i < charArray.Length; ++ i)
        {
            char c = charArray[i];
            if(c == open) cnt ++;
            else if (c == close)
            {
                // skip this close if no enough open in the left
                if(cnt ==0) continue;
                cnt --;
            }
            result.Add(c);
        }

        return result.ToArray();
    }
}