using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution91
{
    public int NumDecodings(string s) 
    {
        int len = s.Length;
        
        if(len <1) return 0;
        if(s[0] == '0') return 0;

        int[] decodingArrary = new int[len + 1];
        decodingArrary[0] = 1;
        decodingArrary[1] = 1;
        int lastNum = s[0] - '0';
        for(int i =2; i <= len; ++i)
        {
            var uniNum = s[i - 1] - '0';
            var biNum = lastNum * 10 + uniNum; 
            
            if(uniNum > 0)
            {
                decodingArrary[i] =  decodingArrary[i - 1];
            }
            
            if (biNum >=10 && biNum <=26)
            {
                decodingArrary[i] =  decodingArrary[i] + decodingArrary[i -2];
            }

            lastNum =uniNum;
        }
        return decodingArrary[len];
    }
}