using System;
using System.Collections.Generic;
using System.Linq;

public class Solution22
{
    // Anytime, when meet the problem of generating something
    // The backtracking is a good way to solve the problem.
    public IList<string> GenerateParenthesis(int n) {
        List<char> chars = new List<char>();
       
        int open =0;
        int close =0;
        List<char> current = new List<char>();
        for(int i =0; i < n; ++i)
        {
            current.Add('-');
            current.Add('-');
        }
        HashSet<string> solutions = new  HashSet<string>();
        
        current[0] = '(';
        BacktrackGenerateParenthesis(current, open + 1, close, n,  solutions);
        return solutions.ToList();
    }

    // In most case, backtracking is a void function with the parameter of 3 parts.
    // Part 1: Current or incomplete value
    // Part 2. State parameters to log the current status
    // Part 3. Results and other resources
    public void BacktrackGenerateParenthesis(List<char> current, int open, int close, int n, HashSet<string> solutions)
    {
        // Step 1: Check if it reached a success match or wrong match 
        // In this problem, we use a both open and close to count the parenthesis pair
        if(open == n && close == n)
        {
            solutions.Add(string.Join("", current));
            return;
        }
        
        if(open >n || close > open)
        {
            return;
        }
        else
        {
            // Try all the combinations. 
            current[open + close] = '(';
            BacktrackGenerateParenthesis(current, open +1, close, n, solutions);

            current[open + close] = ')';
            BacktrackGenerateParenthesis(current, open, close +1, n, solutions);
            current[open + close] = ' ';

            // Backtracking need to reset or clear the state when you return
        }
    }
}