using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TrieNode
{
    public char C;
    List<TrieNode> Nodes = new List<TrieNode>();
    public bool IsWord = false;
    
    public TrieNode(char c)
    {
        this.C = c;
        this.Nodes = new List<TrieNode>();
        for(int i =0; i < 26; ++i)
        {
            this.Nodes.Add(null);
        }
        this.IsWord = false;
    }
    
    public void Insert(String str)
    {
        if(!str.StartsWith(this.C))
        {
            return;
        }
        
        if(str.Length == 1)
        {
            this.IsWord = true;
            return;
        }
        else
        {
            var next = this.Nodes[str[1] - 'a'];
            if(next == null)
            {
                next = new TrieNode(str[1]);
            }
            next.Insert(str.Substring(1));
            this.Nodes[str[1] - 'a'] = next;
        }
    }
    
    public bool Search(string str)
    {
        if(str.Length == 1)
        {
            return this.IsWord;
        }
        else
        {
            var next = this.Nodes[str[1] - 'a'];
            
            return next != null && next.Search(str.Substring(1));
        }
    }
    
    public bool StartsWith(string str)
    {
        if(str.Length == 1)
        {
            return true;
        }
        else
        {
            var next = this.Nodes[str[1] - 'a'];
            
            return next != null && next.StartsWith(str.Substring(1));
        }
    }
}
public class Trie {
    
    List<TrieNode> TrieNodeList = new List<TrieNode>();

    /** Initialize your data structure here. */
    public Trie() {
        for(int i =0; i < 26; ++i)
        {
            TrieNodeList.Add(null);
        }
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        if(string.IsNullOrEmpty(word))
        {
            return;
        }
        
        var node = TrieNodeList[word[0] - 'a'];
        if(node == null)
        {
            node = new TrieNode(word[0]);
        }
        node.Insert(word);
        TrieNodeList[word[0] - 'a'] = node;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        if(string.IsNullOrEmpty(word))
        {
            return false;
        }
        
        var node = TrieNodeList[word[0] - 'a'];
        return node != null && node.Search(word);
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        if(string.IsNullOrEmpty(prefix))
        {
            return false;
        }
        
        var node = TrieNodeList[prefix[0] - 'a'];
        return node != null && node.StartsWith(prefix);
    }
}