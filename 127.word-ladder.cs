using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution127
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        HashSet<string> wordSet = new HashSet<string>();
        Dictionary<string, int> wordMap = new Dictionary<string, int>();
        foreach(var word in wordList)
        {
            wordSet.Add(word);
            if(!wordMap.ContainsKey(word)) wordMap.Add(word, -1);
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int res = 0;
        while(queue.Any())
        {
            res ++;
            
            int size = queue.Count;
            for(int i =0; i < size; ++i)
            {
                var word = queue.Dequeue();
                if(word == endWord) return res;
                for(var k =0; k < word.Length; ++k)
                {
                    var wordArray = word.ToCharArray();
                    for(var n =0; n < 25; ++n)
                    {
                        wordArray[k]= (char)('a' + n);
                        var newWord = new string(wordArray);

                        if(wordMap.ContainsKey(newWord) && wordMap[newWord]<0)
                        {
                            wordMap[newWord] = res + 1;
                            queue.Enqueue(newWord);
                        }
                    }
                }
            }
            
        }

        return 0;
    }
}