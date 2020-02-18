using System;
using System.Collections.Generic;
using System.Linq;

public class Solution151 {
    public string ReverseWords(string s) 
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> results = new List<string>();
        foreach(var word in words)
        {
            results.Add(word);
        }
        results.Reverse();
        return string.Join(' ',results).Trim();
    }
}