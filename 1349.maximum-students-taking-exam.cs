using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1349
{
    // This is the contest probelem. Need to revisit again.
    public int MaxStudents(char[][] seats) {
        var m = seats.Length;
        int n = seats[0].Length;

        int[,] map  = new int[m, n];
        for(int i =0; i < m; ++i)
            for(int j =0; j < n; ++j)
            {
                if(seats[i][j] == '#')
                    map[i, j] = -1;
                else
                {   int cnt = 0;
                    if(j -1 >=0 && seats[i][j-1] == '.') cnt ++;
                    if(j +1 < n && seats[i][j+1] == '.') cnt ++;
                    if(j -1 >=0 && i - 1 >=0 && seats[i-1][j-1] == '.') cnt ++;
                    if(j +1 < n && i - 1 >=0 && seats[i-1][j+1] == '.') cnt ++;

                    map[i, j] = cnt;
                }
            }
        while(true)
        {
            int ki =0;
            int kj =0;
            int maxSeen = 0;
            for(int i =0; i < m; ++i)
                for(int j =0; j < n; ++j)
                {
                    if(map[i, j] > maxSeen)
                    {
                        ki = i;
                        kj = j;
                        maxSeen = map[i, j];
                    }
                }
            if(maxSeen ==0)
                break;
            
            map[ki, kj] = -1;
            if(kj -1 >=0 && map[ki,kj-1] >0) map[ki,kj-1] = map[ki,kj-1] -1;
            if(kj +1 < n  && map[ki,kj+1] >0) map[ki,kj+1] = map[ki,kj+1] -1;
            if(kj -1 >=0 && ki +1 <m  && map[ki +1 ,kj-1] >0) map[ki+1,kj-1] = map[ki+1,kj-1] -1;
            if(kj +1 < n && ki +1 <m  && map[ki +1 ,kj+1] >0) map[ki+1,kj+1] = map[ki+1,kj+1] -1;
        }

        int result = 0;
        for(int i =0; i < m; ++i)
            for(int j =0; j < n; ++j)
            {
                if(map[i, j] == 0)
                {
                    result ++;
                }
            }
        return result;
    }
}