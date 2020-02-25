using System;
using System.Collections.Generic;

public class Solution389 {
    public Dictionary<char, int> ConvertStrToDict(string str)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, 1);
            }
            else {
                dict[c] = dict[c] + 1;
            }
        }

        return dict;
    }

    public char FindTheDifference(string s, string t)
    {
        var dict1 = ConvertStrToDict(s);
        var dict2 = ConvertStrToDict(t);

        foreach (var item in dict2)
        {
            if (!dict1.ContainsKey(item.Key) || dict1[item.Key] < item.Value)
            {
                return item.Key;
            }
        }

        return ' ';
    }
}