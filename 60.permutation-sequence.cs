using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution60
{
    public string GetPermutation(int n, int k) {
        StringBuilder sb = new StringBuilder();
        string num = "123456789";
        int[] f = new int[n];
        Array.Fill(f, 1);

        for (int i = 1; i < n; ++i) f[i] = f[i - 1] * i;
        --k;
        for (int i = n; i >= 1; --i) {
            int j = k / f[i - 1];
            k %= f[i - 1];

            sb.Append(num[j]);
            num = num.Remove(j, 1);
        }

        return sb.ToString();
    }
}
