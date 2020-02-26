using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution848
{
    public string ShiftingLetters(string S, int[] shifts) {
        if(string.IsNullOrEmpty(S) || shifts == null || S.Length != shifts.Length)
            return S;
            
        for(int i = shifts.Length -1; i>=0; --i)
        {
            if(i == (shifts.Length -1)) 
            {
                shifts[i] = shifts[i] % 26;
            }
            else
            {
                shifts[i] = (shifts[i] +shifts[i+1]) % 26;
            }
        }

        char[] charArray = new char[S.Length];
        for(int i =0; i < S.Length; ++i)
        {
            charArray[i] = (char)( (S[i] - 'a' + shifts[i]) % 26 + 'a');
        }

        return new string(charArray);
    }
}