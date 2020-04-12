using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5380
{
    public IList<string> StringMatching(string[] words) 
    {
        List<string> results = new List<string>();
        if(words == null || words.Length <= 1)
        {
            return results;
        }

        HashSet<int> visited = new HashSet<int>();
        for(int i = 0; i < words.Length - 1; ++ i)
        {
            for(int j = i + 1; j < words.Length; ++j)
            {
                if(words[i].Contains(words[j]))
                {
                    visited.Add(j);
                }

                if(words[j].Contains(words[i]))
                {
                    visited.Add(i);
                }
            }
        }

        foreach(var i in visited)
        {
            results.Add(words[i]);
        }
        return results;
    }
}