using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution282
{
    public IList<string> AddOperators(string num, int target) {
        List<string> results = new List<string>();

        helper(num, target, 0, 0, "",  results);

        return results;
    }

    public void helper(string num, int target, long diff, long current,  string expression, List<string> results)
    {
        if(string.IsNullOrEmpty(num))
        {
            if(current == target)
                results.Add(expression);
            return;
        }
        
        for(int i = 1; i <= num.Length; ++i)
        {
            string cur = num.Substring(0, i);
            if(cur.Length > 1 && cur[0] == '0') return;
            string next = num.Substring(i);

            long curNum = long.Parse(cur);
            if(expression.Length > 0)
            {
                helper(next, target, curNum, current + curNum, expression + "+" + cur, results);
                helper(next, target, -curNum, current - curNum, expression + "-" + cur, results);
                helper(next, target, diff*curNum, (current - diff) + diff*curNum, expression + "*" + cur, results);
            }
            else
            {
                helper(next, target, curNum, curNum, cur, results);
            }
        }
    }

    // Devide and merge
    // Use a dictionary to help cache the result of i, j
    // <i,j>: [r1, r2, r3]
    Dictionary<Tuple<int, int>, List<int>> resultsByRange = new Dictionary<Tuple<int, int>, List<int>>();
}