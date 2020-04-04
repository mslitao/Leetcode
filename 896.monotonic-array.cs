
using System;
using System.Collections.Generic;
using System.Linq;


public class Solution896 {
    public bool IsMonotonic(int[] A) {
        if(A == null) return false;
        if(A.Length <= 2) return true;

        int order = 0;
        for(int i = 1; i < A.Length; ++i)
        {
            if(order == 0 && A[i] > A[i -1])
            {
                order = 1;
            } 
            else if (order == 0 && A[i] < A[i -1])
            {
                order = -1;
            }
            else if(order == 1 && A[i] < A[i -1])
            {
                return false;
            }
            else if(order == -1 && A[i] > A[i-1])
            {
                return false;
            }

        }

        return true;
    }
}