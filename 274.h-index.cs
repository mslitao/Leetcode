using System;
using System.Collections.Generic;
using System.Linq;

public class Solution274
{
    public int HIndex(int[] citations) 
    {
        if(citations.Length < 1)
        {
            return 0;
        }
        var length = citations.Length;

        int[] data = new int[length+1];

        foreach(var citation in citations)
        {
            if(citation >= length)
            {
                data[length] = data[length] + 1;
            }
            else
            {
                data[citation] = data[citation] + 1;
            }
        }

        var hindex = 0;
        for(int i = length ; i>=0; --i)
        {
            hindex = hindex + data[i];
            if(hindex >=i)
            {
                return i;
            }
        }

        return hindex;
    }
}