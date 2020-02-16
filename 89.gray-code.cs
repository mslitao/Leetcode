using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution89
{
    public IList<int> GrayCode(int n) {
        List<int> list = new List<int>();
        list.Add(0);
        int x = 0;
        for (int i = 1; i <= n; i++) {
            x = 1 << (i - 1); // Math.pow(2, i - 1)
            for (int j = x - 1; j >= 0; j--) {
                list.Add(list[j] | x);  // append 1 in front
            }
        }
        return list;
    }
}