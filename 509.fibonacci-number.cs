using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution509
{
    public int Fib(int N) {
        if (N <= 1) return N;
        return Fib(N - 1) + Fib(N - 2);
    }
}