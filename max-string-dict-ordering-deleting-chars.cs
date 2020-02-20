using System;
using System.Collections.Generic;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution0219
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi how are you!");
        
        Console.WriteLine(FindMaxString("toutiao"));
        Console.WriteLine(FindMaxString(""));
        Console.WriteLine(FindMaxString(null));
        Console.WriteLine(FindMaxString("a"));
        Console.WriteLine(FindMaxString("abcde"));
        Console.WriteLine(FindMaxString("abcda"));
        Console.WriteLine(FindMaxString("abcdab"));
    }
    
    public static bool Test(string input,string expected)
    {
        return FindMaxString(input) == expected;
    }
        
    public static string FindMaxStringUsingStack(string str)
    {
        if(string.IsNullOrEmpty(str)) return str;
        
        Stack<char> stack = new Stack<char>();
        foreach(var c in str)
        {
            while(stack.Any() && stack.Peek() < c)
            {
                stack.Pop();
            }
            stack.Push(c);
        }
        
        return string.Join("",stack.Reverse());
    }

    public static string FindMaxString(string str)
    {
        if(string.IsNullOrEmpty(str)) return str;
        
        Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
        
        // Step 1: cache the positions for each character.
        for(int i =0;  i < str.Length; ++i)
        {
            var c  = str[i];
            
            if(!dict.ContainsKey(c))
            {
                var newList =new List<int>();
                newList.Add(i);
                dict.Add(c, newList);
            }
            else
            {
                var posList = dict[c];
                posList.Add(i);
                dict[c] = posList;
            }
        }
        
        /*foreach(var item in dict)
        {
            Console.WriteLine(item.Key.ToString() );
            Console.WriteLine(string.Join('-', item.Value));
        }*/
            
        var lastPos = -1;
        string result = "";
        while(true)
        {
            bool foundNextChar= false;
            // z to a
            for(int i = 25; i >=0; --i)
            {
                var c = (char)('a' + i);
                if(dict.ContainsKey(c) && dict[c].Last() > lastPos)
                {
                    //Update the result, append new char
                    result += c;
                    
                    // update the position
                    lastPos = dict[c].Last();
                    
                    // update the dictionary 
                    // 1. remove the index  of the char
                    // 2. update the lsit for the c in the dictionary
                    var posList = dict[c];
                    posList.RemoveAt(dict[c].Count -1);
                    if(posList.Count ==0)
                        dict.Remove(c);
                    else
                        dict[c] = posList;
                    
                    foundNextChar = true;
                    break;
                }
            }
            if(!foundNextChar) break;
        }
        
        return result;
    }
}

/*
Question:
对一个字符串，删除若干个字符使删除后的字符串字典序最大。

Example:

Input: toutiao
Output: uto

*/