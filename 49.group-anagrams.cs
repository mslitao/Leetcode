using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution49 {

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            // String.Concat
            // Str.OrderBy
            var sorted = String.Concat(str.OrderBy(c => c));
            if (dict.ContainsKey(sorted))
            {
                var list = dict[sorted];
                list.Add(str);
                dict[sorted] = list;
            }
            else
            {
                var list = new List<string>();
                list.Add(str);
                dict[sorted] = list;
            }
        }

        IList<IList<string>> results = new List<IList<string>>();
        foreach (var item in dict)
        {
            results.Add(item.Value);
        }
        return results;
    }
}