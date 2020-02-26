using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution720
{
    public string LongestWord(string[] words) 
    {
        Dictionary<int, HashSet<string>> wordsByLen = new Dictionary<int, HashSet<string>>();

        foreach(var wrd in words)
        {
            if(!wordsByLen.ContainsKey(wrd.Length))
            {
                wordsByLen.Add(wrd.Length, new HashSet<string>());
            }

            var hs = wordsByLen[wrd.Length];
            hs.Add(wrd);
            wordsByLen[wrd.Length] = hs;
        }

        
        string res = string.Empty;
        if(!wordsByLen.ContainsKey(1)) return string.Empty;
        HashSet<string> validResults = wordsByLen[1];
        int len = 2;
        while(true)
        {
            if(wordsByLen.ContainsKey(len))
            {
                HashSet<string> nextResults = new HashSet<string>();
                
                foreach(var wrd in wordsByLen[len])
                {
                    if(validResults.Contains(wrd.Substring(0, wrd.Length -1)))
                    {
                        nextResults.Add(wrd);
                    }
                }
                
                if(nextResults.Count == 0)
                    break;
                else
                    validResults = nextResults;
            }
            else
            {
                break;
            }
            len ++;
        }
        
        return validResults.Count ==0? "": validResults.OrderBy(q => q).ToList().FirstOrDefault();
    }
}