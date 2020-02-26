using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution676
{
    public class MagicDictionary
    {

        Dictionary<string, List<char>> sets = new Dictionary<string, List<char>>();
        /** Initialize your data structure here. */
        public MagicDictionary()
        {
            this.sets = new Dictionary<string, List<char>>();

        }

        /** Build a dictionary through a list of words */
        public void BuildDict(string[] dict)
        {
            foreach(var word in dict)
            {
                for (int i = 0; i < word.Length; ++i)
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb[i] = '*';
                    var tmp = sb.ToString();
                    if(sets.ContainsKey(tmp))
                    {
                        var list = sets[tmp];
                        list.Add(word[i]);
                        sets[tmp] = list;
                    }
                    else
                    {
                        sets.Add(tmp, new List<char>() { word[i] });
                    }
                };
            }
        }

        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            for (int i = 0; i < word.Length; ++i)
            {
                StringBuilder sb = new StringBuilder(word);
                sb[i] = '*';
                if (this.sets.ContainsKey(sb.ToString()))
                {
                    var list = sets[sb.ToString()];
                    if (list.Count > 1 || list[0] != word[i])
                        return true;
                }
            }

            return false;
        }
    }
}
