using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution796
{
    public bool RotateString(string A, string B) {
        if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B) || A.Length != B.Length)
            return false;

        A = A + A;
        return A.Contains(B);
    }
}