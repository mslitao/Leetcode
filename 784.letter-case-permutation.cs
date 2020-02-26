using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution784 {
    public IList<string> LetterCasePermutation(string S) {
        int step =0;
        int n = S.Length;
        IList<string> results = new List<string>();
        string current =  "";

        BacktrackLetterCasePermutation(current, step, n, S, results);
        return results;
    }

    public void BacktrackLetterCasePermutation(string current, int step, int n, string S, IList<string> results)
    {
        if(step == n)
        {
            results.Add(current);
            return;
        }

        char nextChar = S[step];
        if(char.IsLetter(nextChar))
        {
            
            var str1 = new string(current) + char.ToLower(nextChar);
            BacktrackLetterCasePermutation(str1, step +1, n, S, results);

            var str2 = new string(current) + char.ToUpper(nextChar);
            BacktrackLetterCasePermutation(str2, step +1, n, S, results);
        }
        else
        {
            var str = new string(current) + nextChar;
            BacktrackLetterCasePermutation(str, step +1, n, S, results);
        }
    }
}