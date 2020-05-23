using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5413
{
    public string ArrangeWords(string text) {
        if(string.IsNullOrEmpty(text) || text.IndexOf(' ') == -1 ) return text;

        Dictionary<int, string> map = new Dictionary<int, string>();
        var items = text.ToLowerInvariant().Split(' ');
        foreach(var item in items)
        {
            if(!map.ContainsKey(item.Length))
            {
                map.Add(item.Length, item);
            }
            else
            {
                map[item.Length] = map[item.Length]  + " " + item;
            } 
        }

        var result = string.Join(' ', map.OrderBy(n=>n.Key).Select(n=>n.Value));


        return result[0].ToString().ToUpper() + result.Substring(1);

    }
}