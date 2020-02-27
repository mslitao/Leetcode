using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution887
{
    public int SuperEggDrop(int K, int N) 
    {
        if(N==1 || N ==0) return N;
        if(K ==1) return N;
        


        // using m moves and e eggs, how many floors can we check?
        int[,] opt= new int[N+1, K+1];
        for(int n =1; n <= N; n++)
        {
            opt[n, 0] = 0;
        }

        for(int k =1; k <=K; ++k)
        {
            opt[0, k] = 0;
        }

        for (int m = 1; m <= N; ++m) {
            for (int e = 1; e <= K; ++e) {
                opt[m,e] = opt[m-1, e-1] + opt[m-1, e] + 1;
                // have we checked all the floors?
                if (opt[m, e] >= N) {
                    return m;
                }
            }
        }
        return -1; // we'll never get here
    }
}