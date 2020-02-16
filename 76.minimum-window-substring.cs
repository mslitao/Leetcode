using System;
using System.Collections.Generic;
using System.Linq;

public class Solution76
{
    public string MinWindow(string s, string t) 
    {        
        if(s.Length == 0 || t.Length == 0) return string.Empty;
        
        var target = new Dictionary<char,int>();
        foreach(char c in t)
        {
            if(!target.ContainsKey(c)) target.Add(c, 0);
            target[c] += 1;
        }
        
        int minLength = Int32.MaxValue;
        string ans = string.Empty;

        int begin = 0;
        bool bEndMoved = true;
        int end = 0;
        
        var source = new Dictionary<char, int>();
        
        while(end < s.Length)
        {
            int len = (end-begin)+1;
            
            if(bEndMoved)
            {
                if(!source.ContainsKey(s[end])) source.Add(s[end], 0);
                source[s[end]] += 1;
            }
                      
            if(len < t.Length || !IsValidWindow(source, target))
            {
                bEndMoved = true;
                end++;
            }
            else
            {
                if(len < minLength) 
                {
                    ans = s.Substring(begin, len);
                    minLength = len;
                }
                
                // now try to be ambitious and squeeze down the window. 
                source[s[begin]] -= 1;
                if(source[s[begin]] == 0) source.Remove(s[begin]);
                
                begin++;
                bEndMoved = false;
            }  
        }
        
        return ans;
    }
    
    private bool IsValidWindow(Dictionary<char,int> source, Dictionary<char,int> target)
    {        
        foreach(char c in target.Keys)
        {
            if(!source.ContainsKey(c) || source[c] < target[c]) 
            {
                return false;
            }
        }
        
        return true;
    }    
}