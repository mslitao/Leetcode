using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution211
{

}

public class WordDictionary
{
    public class TrieNode
    {
        public TrieNode[] Next;
        public bool IsWord;

        public TrieNode()
        {
            this.Next = new TrieNode[26];
            this.IsWord = false;
        }
    }

    TrieNode trie;
    /** Initialize your data structure here. */
    public WordDictionary() {
        this.trie = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        TrieNode current = this.trie;
        int i = 0;
        for(; i < word.Length && current.Next[word[i] - 'a'] != null; ++i)
        {
            current = current.Next[word[i] - 'a'];
        }

        for(; i < word.Length; ++i)
        {
            current.Next[word[i] - 'a'] = new TrieNode();
            current = current.Next[word[i] - 'a'];
        }
        current.IsWord = true;
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        //return SearchBFS(word);

        return SearchDFS(word, 0, this.trie);
    }

    public bool SearchDFS(string word, int idx,  TrieNode node)
    {
        if(idx == word.Length)
        {
            return node != null && node.IsWord;
        }

        if(word[idx] == '.')
        {
            bool found = false;
            foreach(var next in node.Next)
            {
                if(next != null && SearchDFS(word, idx +1 , next))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
        else
        {
            var next = node.Next[word[idx] - 'a'];
            if(next != null && SearchDFS(word, idx +1 , next))
            {
                return true;
            }
            return false;
        }
    }

    public bool SearchBFS(string word) {
        Queue<TrieNode> queue = new Queue<TrieNode>();
        queue.Enqueue(this.trie);

        for(int index = 0; index < word.Length && queue.Any(); ++ index)
        {
            int cnt = queue.Count;
            for(int i =0; i < cnt; ++i)
            {
                TrieNode node = queue.Dequeue();
                if(word[index] == '.')
                {
                    foreach(var next in node.Next)
                    {
                        if(next != null)
                            queue.Enqueue(next);
                    }
                }
                else
                {
                    if(node.Next[word[index] - 'a'] != null)
                    {
                        queue.Enqueue(node.Next[word[index] - 'a']);
                    }
                }
            }
        }
        
        while(queue.Any())
            if(queue.Dequeue().IsWord) return true;
        
        return false;
    }
}