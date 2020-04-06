using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution767 {
    public string ReorganizeString(string S) {
        if(string.IsNullOrEmpty(S)) return S;

        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(var c in S)
        {
            if(!map.ContainsKey(c))
            {
                map.Add(c, 1);
            }
            else
            {
                map[c] ++;
            }
        }

        StringBuilder sb = new StringBuilder();
        
        char lastC = ' ';
        while(true)
        {
            var sortedItems =  map.OrderByDescending(n=>n.Value);
            bool next = false;
            foreach(var item in sortedItems)
            {
                if(sb.Length ==0 || item.Key != lastC)
                {
                    lastC = item.Key;
                    map[item.Key]--;
                    if(map[item.Key] == 0)
                    {
                        map.Remove(item.Key);
                    }
                    next = true;
                    break;
                }
            }

            if(!next) break;

            sb.Append(lastC);

            if(map.Count ==0)
                break;
        }

        return map.Count == 0? sb.ToString():string.Empty;
    }
}