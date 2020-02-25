using System;
using System.Collections.Generic;

public class Solution394
{
    public string DecodeString(string s) {
        int start = 0;

        return RecurseDecodeString(s, ref start);
    }

    public string RecurseDecodeString(string s, ref int index)
    {
        string result = string.Empty;

        while(index < s.Length && s[index] != ']')
        {
            if(char.IsLetter(s[index]))
            {
                result += s[index];
                index ++;
            }
            else {
                int num = 0;
                while(index < s.Length && char.IsNumber(s[index]))
                {
                    num = num * 10 + s[index] - '0';
                    index ++;
                }
                //Console.WriteLine(num);
                ++ index; //[
                string str = RecurseDecodeString(s, ref index);
                ++ index; //]
                while(num > 0)
                {
                    result += str;
                    num --;
                }
            }
        }

        return result;
    }
}