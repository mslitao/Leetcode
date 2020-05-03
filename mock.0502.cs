using System;
using System.Collections.Generic;
using System.Linq;

public class Mock0502
{
    public void DuplicateZeros(int[] arr) {
        int cntZero = 0;
        for(int i = 0; i < arr.Length; ++i)
        {
            if(arr[i] == 0) cntZero ++;
        }
        int iindex = arr.Length + cntZero - 1;
        for(int i = arr.Length - 1; i >=0; --i)
        {
            if(arr[i] == 0)
            {
                if(iindex < arr.Length)
                {
                    arr[iindex] = 0;
                }
                iindex --;

                if(iindex < arr.Length)
                {
                    arr[iindex] = 0;
                }
                iindex --;
            }
            else
            {
                if(iindex < arr.Length)
                {
                    arr[iindex] = arr[i];
                }
                iindex --;
            }
        }
    }

    public int MinDominoRotations(int[] A, int[] B) {
        int result = int.MaxValue;

        for(int i = 1; i <= 6;++i)
        {
            var tmp = Helper(A, B, i);
            if( tmp!= -1 && tmp < result )
            {
                result = tmp;
            }
        }

        return result == int.MaxValue? -1: result;
    }

    public int Helper(int[] A, int[] B, int n) {
        int len = A.Length;
        int cntA = 0;
        int cntB = 0;
        int cntAB = 0;
        for(int i = 0; i < A.Length; ++i)
        {
            if(A[i] == n)
            {
                cntA ++;
            }

            if(B[i] == n)
            {
                cntB ++;
            }
            
            if(A[i] == n || B[i] == n)
            {
                cntAB ++;
            }
        }

        if(cntAB != A.Length) return -1;
        else return Math.Min(A.Length - cntA, A.Length - cntB);
    }
}