using System;
using System.Collections.Generic;
using System.Linq;


public class Solution299
{
    public string GetHint(string secret, string guess) 
    {
        var bulls = 0;
        var len = secret.Length;
        int[] s = new int[10];
        int[] g = new int[10];
        for(int i = 0; i< len; ++i)
        {
            if(secret[i] == guess[i])
            {
                bulls++;
            }
            else
            {
                s[secret[i]-'0'] =s[secret[i]-'0'] +1;
                g[guess[i]-'0'] =g[guess[i]-'0'] +1;
            }
        }


        var cows =0;
        for(int i =0; i< 10; ++i)
        {
            cows=cows+ Math.Min(s[i], g[i]);
        }

        return bulls.ToString()+"A"+cows.ToString()+"B"; 
    }
}