using System;
using System.Collections.Generic;
using System.Linq;

public class Solution3 
{
    public int LengthOfLongestSubstring(string s) {
        int maxLength =1;
        if(s == null || s.Length == 0)
            return 0;
            
        Dictionary<char, int> charPosition = new Dictionary<char, int>();
        int start = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            if(charPosition.ContainsKey(s[i]) )
            {
                if(charPosition[s[i]]>= start)
                {
                    if(i - start > maxLength)
                        maxLength = i- start;
                    start = charPosition[s[i]]+1;
                }
                                        
                charPosition[s[i]] = i;
            }
            else
            {
                charPosition.Add(s[i], i);
            }
        }
        
        if(s.Length - start > maxLength)
            maxLength = s.Length- start;

        return maxLength;
    }

    public int LengthOfLongestSubstring_SlidWindow(string s) 
    {
        int left =0; 
        int right = 0;
        int size =0;
        int maxCnt =0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(var c in s)
        {
            map[c] =0;
        }

        while(right < s.Length)
        {
            while(right < s.Length && map[s[right++]]++ ==0) size++;
            maxCnt = Math.Max(maxCnt, size);

            while(size >0 )
            {
                if(map[s[left++]]-- > 1)
                    break;
                size --;
            }
        }

        return maxCnt;
    }
}