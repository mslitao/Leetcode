
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1004
{
    public int LongestOnes(int[] A, int K) {
        int start =0; 
        int end = 0;
        int cnt0 = 0;
        int result = 0;
        
        while(end < A.Length)
        {
            if(A[end] == 0)
            {
                cnt0++;
            }

            while(cnt0 > K)
            {
                if(A[start] == 0)
                {
                    cnt0 --;
                }
                start ++;
            }

            result = Math.Max(result, end - start + 1);
            end ++;
        }

        return result;
    }
}