using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution916
{
    public IList<string> WordSubsets(string[] A, string[] B) 
    {
        List<int[]> charCountInA = new List<int[]>();
        //List<int[]> charCountInB = new List<int[]>();

        int[] charMaxCountInB = new int[26];
        

        foreach(var str in A)
        {
            charCountInA.Add(Str2CharCount(str));
        }

        foreach(var str in B)
        {
            var charCount = Str2CharCount(str);
            for(int i =0; i < 26; i++)
            {
                if(charCount[i] > charMaxCountInB[i])
                {
                    charMaxCountInB[i] = charCount[i];
                }
            }
        }

        

        IList<string> results = new List<string>();
        for(int i=0; i< A.Length; ++i)
        {
            int[] a = charCountInA[i];

            if(IsWordSubset(a, charMaxCountInB))
            {
                results.Add(A[i]);
            }
        }

        return results;
    }

    public bool IsWordSubset(int[] charCountInA, int[] charCountInB)
    {
        for(int i = 0 ; i < 26; i++)
        {
            if(charCountInA[i]< charCountInB[i])
                return false;
        }

        return true;
    }

    public int[] Str2CharCount(string str)
    {
        int[] charCount = new int[26];

        foreach(var c in str)
        {
            charCount[c-'a'] =  charCount[c-'a'] +1;
        }

        return charCount;
    }
}