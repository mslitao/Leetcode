using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5414
{
    public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies) {
        Dictionary<string, HashSet<int>> map = new Dictionary<string, HashSet<int>>();

        
        for(int i = 0; i < favoriteCompanies.Count; ++i)
        {
            foreach(var fc in favoriteCompanies[i])
            {
                if(!map.ContainsKey(fc))
                {
                    map.Add(fc, new HashSet<int>());
                }

                map[fc].Add(i);
            }
        }

        HashSet<int> results = new HashSet<int>();
        for(int i = 0; i < favoriteCompanies.Count; ++i)
        {
            var bc = map[favoriteCompanies[i][0]];

            foreach(var idx in bc)
            {
                if(idx == i) continue;
                bool match = true;
                foreach(var company in favoriteCompanies[i])
                {
                    if(!map[company].Contains(idx))
                    {
                        match = false;
                        break;
                    }
                }

                if(match)
                {
                    results.Add(i);
                    break;
                }
            }
        }

        var left = new List<int>();
        
        for(int i = 0; i < favoriteCompanies.Count; ++i)
        {
            if(!results.Contains(i))
            {
                left.Add(i);
            }
        }
        return left;


    }
}