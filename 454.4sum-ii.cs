using System;
using System.Collections.Generic;
using System.Linq;

public class Solution454
{
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        Dictionary<int, int> sumMap = new Dictionary<int, int>();
        for(int i = 0; i < A.Length; ++i)
            for(int j =0; j < B.Length; ++j)
            {
                var sum = A[i] + B[j];
                if(!sumMap.ContainsKey(sum))
                {
                    sumMap.Add(sum, 1);
                }
                else
                {
                    sumMap[sum] = sumMap[sum] + 1;
                }
            }

        int result = 0;
        for(int i = 0; i < C.Length; ++i)
            for(int j =0; j < D.Length; ++j)
            {
                var sum = -1*(C[i] + D[j]);
                if(sumMap.ContainsKey(sum))
                {
                    result = result + sumMap[sum];
                }
            }
        
        return result;
    }
}