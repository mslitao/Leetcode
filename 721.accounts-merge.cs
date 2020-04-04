using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution721
{
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) 
    {
        IList<IList<string>> results = new List<IList<string>>();
        Dictionary<string, List<IList<string>>> accountsByName = new Dictionary<string, List<IList<string>>>();

        foreach(var account in accounts)
        {
            if(account.Count <=1) 
            {
                //results.Add(account);
                continue;
            }
            
            //Console.WriteLine(account[0]);
            if(!accountsByName.ContainsKey(account[0]))
            {
                accountsByName.Add(account[0], new List<IList<string>>());
            }
            var tmp = accountsByName[account[0]];
            
            var name = account[0];
            account.RemoveAt(0);
            tmp.Add(account);
            
            accountsByName[name] = tmp;
        }
        //Console.WriteLine("------------------");
        foreach(var item in accountsByName)
        {
            //Console.WriteLine(item.Key);
            
            int n = item.Value.Count;
            Dictionary<int, HashSet<string>> emailsByCluster = new Dictionary<int, HashSet<string>>();
            
            Dictionary<string, HashSet<int>> indexByEmail = new Dictionary<string, HashSet<int>>();
            for(int i =0 ; i < n; ++ i)
            {
                foreach(var email in item.Value[i])
                {
                    if(!indexByEmail.ContainsKey(email))
                    {
                        indexByEmail.Add(email, new HashSet<int>());
                    }

                    var tmp = indexByEmail[email];
                    tmp.Add(i);
                    indexByEmail[email] = tmp;
                }
            }
            HashSet<int> visited = new HashSet<int>();
            for(int i =0 ; i < n; ++ i)
            {
                HashSet<string> groupResults = new HashSet<string>();
                DFSGroup(item.Value, indexByEmail, groupResults, i, visited);

                if(groupResults.Count > 0)
                {
                    var newAccount = groupResults.ToList();
                    var ordCmp = StringComparer.Ordinal;
                    newAccount.Sort(ordCmp);
                    newAccount.Insert(0, item.Key);

                    results.Add(newAccount);
                }
            }
        }
        
        return results;
    }
    
    public void DFSGroup(List<IList<string>> emails, Dictionary<string, HashSet<int>> indexByEmail,  HashSet<string> results, int i, HashSet<int> visited)
    {
        if(visited.Contains(i)) return;
        visited.Add(i);

        foreach(var email in emails[i])
        {
            results.Add(email);
            foreach(var next in indexByEmail[email])
            {
                DFSGroup(emails, indexByEmail, results, next, visited);
            }
        }

        return;
    }
}