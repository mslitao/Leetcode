using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5383
{
    public int NumOfWays(int n) {
        int[] colorsInLastRow = new int[]{0, 0, 0};
        int[] colorsInCurrentRow = new int[]{0, 0, 0};

        int cnt = 0;
        colorsInLastRow = new int[]{0, 0, 0};
        colorsInCurrentRow = new int[]{1, 0, 0};
        Paint(0,0, n, colorsInLastRow, colorsInCurrentRow, 1, ref cnt);
        
        return cnt * 3;
    }

    public void Paint(int i, int j, int n,
                      int[] colorsInLastRow, int[] colorsInCurrentRow,
                      int color, ref int cnt)
    {
        if(i == n -1 && j == 2)
        {
            cnt ++;
            return;
        }

        if(j < 2)
        {
            ++j;
            for(int c = 1; c <= 3; ++c)
            {
                if(c != color && c!= colorsInLastRow[j])
                {
                    int[] arr1 = new int[] {colorsInLastRow[0],colorsInLastRow[1],colorsInLastRow[2]};
                    int[] arr2 = new int[] {colorsInCurrentRow[0],colorsInCurrentRow[1],colorsInCurrentRow[2]};
                    arr2[j] = c;
                    Paint(i, j, n, arr1, arr2, c, ref cnt);
                }
            }
        }
        else
        {
            j =0;
            i++;
            int[] arr1 = new int[] {colorsInCurrentRow[0],colorsInCurrentRow[1],colorsInCurrentRow[2]};
            for(int c = 1; c <= 3; ++c)
            {
                if(c!= arr1[j])
                {
                    int[] arr2 = new int[] {c,0,0};
                    Paint(i, j, n, arr1, arr2, c, ref cnt);
                }
            }
        }
    }
}