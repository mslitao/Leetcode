using System;
using System.Collections.Generic;
using System.Linq;

class SolutionMock0421
{
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> domainVisits = new Dictionary<string, int>();
        foreach(var item in cpdomains)
        {
            var items = item.Split(' ');
            var cnt = int.Parse(items[0]);
            var url = items[1];

            var chunks = url.Split('.');
            string domain = string.Empty;
            for(int i = chunks.Length - 1; i>=0; --i)
            {
                domain = string.IsNullOrEmpty(domain) ? chunks[i] : chunks[i] + "." + domain;

                if(!domainVisits.ContainsKey(domain))
                {
                    domainVisits.Add(domain, cnt);
                }
                else
                {
                    domainVisits[domain]+= cnt;
                }
            }
        }

        return domainVisits.Select(n => n.Value.ToString() + " " + n.Key).ToList();
    }

    public int RepeatedNTimes(int[] A) {
        if(A == null || A.Length == 0) return -1;

        HashSet<int> sets = new HashSet<int>();
        foreach(var a in A)
        {
            if(sets.Contains(a)) return a;
            sets.Add(a);
        }

        return -1;
    }

    public bool IsPowerOfFour(int num) {
        int tmp = 1;
        for(int i = 0; i < 16; ++i)
        {
            if(num == tmp) return true;
            tmp = tmp << 2;
        }

        return false;
    }

    public int[] ExclusiveTime(int n, IList<string> logs) {
        if(n <=0 || logs== null|| logs.Count == 0) return null;
        int[] duration = new int[n];
        
        Stack<int> stackId = new Stack<int>();
        int start = 0;
        foreach(var log in logs)
        {
            var items = log.Split(':');
            var id = int.Parse(items[0]);
            var state = items[1];
            int time = int.Parse(items[2]);

            if(state == "end")
            {
                stackId.Pop();
                duration[id] = duration[id] + time - start + 1;
                start = time + 1;
            }
            else
            {
                if(stackId.Any())
                    duration[stackId.Peek()] = duration[stackId.Peek()] + time - start;
                stackId.Push(id);
                start = time;
            }
        }

        return duration;
    }

    public IList<string> FullJustify(string[] words, int maxWidth) {
        string[] emptyMap = new string[maxWidth + 1];
        string tmp = "";
        for(int i = 0; i< maxWidth; ++i)
        {
            emptyMap[i] = tmp;
            tmp+=" ";
        }

        List<string> current = new List<string>();
        List<int> space = new List<int>();
        int len = 0;
        var str = "";
        List<string> results = new List<string>();
        for(int i = 0; i < words.Length; ++i)
        {
            var word = words[i];
            if(len == 0)
            {
                current.Add(word);
                space.Add(0);
                len = word.Length;
                continue;
            }
            
            if(len + 1 + word.Length > maxWidth)
            {
                if(current.Count == 1)
                {
                    results.Add(current[0] + emptyMap[maxWidth - len]);
                }
                else
                {
                    int k = 1;
                    while(len < maxWidth)
                    {
                        space[k++] ++;
                        len ++;
                    }

                    str = "";
                    for(k = 0;  k< current.Count; ++k)
                    {
                        str = str + emptyMap[space[k]] + current[k];
                    }
                    results.Add(str);
                }

                current.Clear();
                current.Add(word);
                space.Clear();
                space.Add(0);
                len = word.Length;
            }
            else
            {
                current.Add(word);
                space.Add(word.Length);
                len = len + 1 + word.Length;
            }
            
        }

        str = "";
        for(int k = 0;  k< current.Count; ++k)
        {
            str = str + emptyMap[space[k]] + current[k];
        }
        str = str + emptyMap[maxWidth - len];
        results.Add(str);

        return results;
    }
}