using System;
using System.Collections.Generic;
using System.Linq;

public class Solution733
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        var oldColor = image[sr][sc];
        int m = image.Length;
        int n = image[0].Length;
        Queue<int> qr = new Queue<int>();
        Queue<int> qc = new Queue<int>();
        qr.Enqueue(sr);
        qc.Enqueue(sc);

        int[] dr = new int[]{0, 0, 1, -1};
        int[] dc = new int[]{-1, 1, 0, 0};
        while(qr.Any())
        {
            var tr = qr.Dequeue();
            var tc = qc.Dequeue();
            image[tr][tc] = -1;

            for(int k = 0; k < 4; ++k)
            {
                var nr = tr + dr[k];
                var nc = tc + dc[k];

                if(nr>=0 && nr< m && nc >=0 && nc< n && image[nr][nc] == oldColor)
                {
                    qr.Enqueue(nr);
                    qc.Enqueue(nc);
                }
            }
        }

        for(int i = 0; i< m; ++i)
            for(int j = 0; j < n; ++j)
            {
                if(image[i][j] == -1)
                {
                    image[i][j] = newColor;
                }
            }
        return image;
    }
}