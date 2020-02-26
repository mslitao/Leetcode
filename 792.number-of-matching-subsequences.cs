using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution792 
{
    public int NumMatchingSubseq(string S, string[] words) 
    {
        // a list of strings for each letter in the alphabet
        List<string>[] arr = new List<string>[26];
        
        // for each letter in the alphabet, we'll have a list of strings from words array that start with that letter
        // For example: 'a': {'a', 'acd', 'ace'}
        foreach(string word in words)
        {
        // note: a lower case char - 'a' will give you an int in the range [0, 25]
            if(arr[word[0] - 'a'] == null)
                arr[word[0] - 'a'] = new List<string>();
            arr[word[0] - 'a'].Add(word);
        }
        
        for(int i = 0; i < S.Length; i++)
        {
            // current character
            char curr = S[i];
            
            // pull the list of words with this character from the array
            List<string> waiting = arr[curr - 'a'];
            if(waiting == null || waiting.Count == 0) continue;
            
            // clear the current character's list
            arr[curr - 'a'] = null;
            
            // construct a new list, removing the current character from each
            // word since we're no longer waiting for this character
            List<string> newList = new List<string>();
            foreach(string word in waiting)
                if(word.Length > 1)
                newList.Add(word.Substring(1));  
            
            // loop thru the new list and assign each of the words 
            // to the appropriate bucket
            foreach(string n in newList)
            {
                char first = n[0];
                if(arr[first - 'a'] == null)
                    arr[first - 'a'] = new List<string>();
                arr[first - 'a'].Add(n);
            }   
        }
        
        // the result is the number of full words from the words array that we processed
        int remaining = 0;
        for(int i = 0; i < 26; i++)
            if(arr[i] != null)
                remaining += arr[i].Count;
        
        return words.Length - remaining;
    }
}