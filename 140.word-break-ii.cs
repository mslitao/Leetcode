using System;
using System.Collections.Generic;
using System.Linq;

public class Solution140
{
    // Backtracking
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        IList<string> results = new List<string>();
        HashSet<string> wordSets = new HashSet<string>();
        int maxSize = 0;
        foreach(var word in wordDict)
        {
            maxSize = Math.Max(maxSize, word.Length);
            wordSets.Add(word);
        }

        List<string> current = new List<string>();
        BPWordBreak(current, s, maxSize, wordSets, results);

        return results;
    }

    public void BPWordBreak(List<string> current, string s, int maxSize, HashSet<string> words, IList<string> results)
    {
        if(string.IsNullOrEmpty(s))
        {
            results.Add(string.Join(" ", current));
            return;
        }

        for(int i =1; i <= maxSize; ++i)
        {
            if(i > s.Length) continue;

            var prefix = s.Substring(0, i);
            if(words.Contains(prefix))
            {
                int pos = current.Count;
                current.Add(prefix);
                BPWordBreak(current, i == s.Length? "": s.Substring(i), maxSize, words, results);
                current.RemoveAt(pos);
            }
        }
    }

    public void BPWordBreak(List<string> current, string s, int maxSize, List<string> words, IList<string> results)
    {
        if(string.IsNullOrEmpty(s))
        {
            results.Add(string.Join(" ", current));
            return;
        }

        foreach(var word in words)
        {
            if(s.StartsWith(word))
            {
                int pos = current.Count;
                current.Add(word);
                BPWordBreak(current, word == s? "": s.Substring(word.Length), maxSize, words, results);
                current.RemoveAt(pos);
            }
        }
    }
}