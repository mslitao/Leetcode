using System;
using System.Collections.Generic;

public class Solution17 {

    public IList<string> LetterCombinations(string digits) {
        IList<string> results = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return results;
        }
        String[] mapping = new String[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        Queue<string> q = new Queue<string>();
        q.Enqueue("");
        for (int i = 0; i < digits.Length; ++i)
        {
            string str = mapping[digits[i] - '0'];
            while (q.Peek().Length == i)
            {
                var s = q.Dequeue();

                foreach (var c in str)
                {
                    q.Enqueue(s + c);
                }
            }
        }

        
        while(q.Count >0)
        {
            results.Add(q.Dequeue());
        }
        return results;
    }

    public IList<string> LetterCombinations2(string digits) {
        IList<string> results = new List<string>();
        if(string.IsNullOrEmpty(digits)) return results;

        // Can also use Backtracking to solve this by track the current stringbuilder.

        return results;
    }
}