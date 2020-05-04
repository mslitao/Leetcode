using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1436
{
    public string DestCity(IList<IList<string>> paths) {
        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach(var path in paths)
        {
            if(!map.ContainsKey(path[1]))
            {
                map.Add(path[1], 0);
            }

            if(!map.ContainsKey(path[0]))
            {
                map.Add(path[0], 0);
            }

            map[path[0]] ++;
        }
    }
}