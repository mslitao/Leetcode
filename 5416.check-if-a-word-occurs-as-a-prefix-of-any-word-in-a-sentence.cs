using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5416
{
    public int IsPrefixOfWord(string sentence, string searchWord) {
        if(string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(searchWord)) return -1;
        var items = sentence.Split(' ');
        int idx = 0;
        foreach(var str in items)
        {
            idx++;
            if(str.Length >= searchWord.Length && str.StartsWith(searchWord)) return idx;
        }

        return -1;
    }
}