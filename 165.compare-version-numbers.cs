using System;
using System.Collections.Generic;
using System.Linq;

public class Solution165
{
        public int CompareVersion(string version1, string version2) {
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');

        for(int i =0; i < v1.Length || i< v2.Length;++i)
        {
            int i1 = i>=v1.Length?0: int.Parse(v1[i]);
            int i2 = i>=v2.Length?0: int.Parse(v2[i]);

            if(i1> i2) return 1;
            else if(i1 < i2) return -1;
        }
        return 0;
    }
}