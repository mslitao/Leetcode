using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5417
{
    public int MaxVowels(string s, int k) {
        HashSet<char> csets = new HashSet<char>(){'a','e', 'i','o','u'};

        int start = 0;
        Dictionary<char, int> map =new Dictionary<char, int>();
        int end = 0;
        int len = 0;
        int sum = 0;
        while(end < s.Length)
        {
            if(csets.Contains(s[end]))
            {
                sum++;
            }

            while(end - start  + 1 > k)
            {
                if(csets.Contains(s[start]))
                {
                    sum--;
                }
                start ++;
            }

            if(end - start + 1 == k && sum > len)
            {
                len = sum;
            }

            end ++;
        }

        return len;
    }
}