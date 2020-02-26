using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution760
{
    public int[] AnagramMappings(int[] A, int[] B) {
        int len = A.Length;
        int[] mapping = new int[len];
        for (int i = 0; i < len; ++i)
        {
            for (int j = 0; j < len; ++j)
            {
                if (B[j] == A[i])
                {
                    mapping[i] = j;
                }
            }
        }

        return mapping;
    }
}