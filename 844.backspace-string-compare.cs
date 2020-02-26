using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution844
{
    // Form the string first and do the comparision 
    // When form the string, it's better to  use Stack.
    public bool BackspaceCompare(string S, string T) {
        if(string.IsNullOrEmpty(S) && string.IsNullOrEmpty(T))
        {
            return true;
        }
        else if(S == null || T == null)
        {
            return false;
        }

        List<char> l1 = new List<char>();
        int i1 = S.Length -1;
        int g1 = 0;
        while(i1 >=0)
        {
            if(S[i1] == '#')
            {
                g1++;
            }
            else if(g1 ==0)
            {
                l1.Add(S[i1]);
            }
            else
            {
                g1--;
            }

            i1--;
        }

        List<char> l2 = new List<char>();
        int i2 = T.Length -1;
        int g2 = 0;
        while(i2 >=0)
        {
            if(T[i2] == '#')
            {
                g2++;
            }
            else if(g2 ==0)
            {
                l2.Add(T[i2]);
            }
            else
            {
                g2--;
            }

            i2--;
        }

        //Console.WriteLine(string.Join("", l1) );
        //Console.WriteLine(string.Join("", l2) );
        return string.Join("", l1) == string.Join("",l2);
    }
}