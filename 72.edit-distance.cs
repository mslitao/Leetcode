using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution72
{
    /*
    Solition 1: Traditional DP solution with 2d DP array
    */
    public int MinDistance(string word1, string word2) {
        int pos1 = word1.Length;
        int pos2 = word2.Length;

        return DPMinDistance(word1, word2, pos1, pos2);
    }
        
    public int DPMinDistance(string word1, string word2, int len1, int len2)
    {
        if(len1 ==0) return len2;
        if(len2 == 0) return len1;

        int[,] distanceArray = new int[len1 + 1, len2 + 1];
        
        for(int i =0; i <= len1; i++)
        {
            distanceArray[i, 0] = i;
        }

        for(int i =0; i <= len2; i++)
        {
            distanceArray[0, i] = i;
        }

        for(int i =1; i <= len1; i++)
        {
            for(int j=1; j<= len2; j++)
            {
                if(word1[i -1 ] == word2[j - 1])
                {
                    distanceArray[i,j] = distanceArray[i-1,j-1];
                }
                else
                {
                    distanceArray[i,j] = Math.Min(distanceArray[i-1,j-1],Math.Min(distanceArray[i-1, j],distanceArray[i, j-1])) +1;
                }
            }
        }

        return distanceArray[len1,len2];
    }

    // Solution 2: Recursive way.
    public int RecursiveEditDist(String str1 , String str2 , int m ,int n) 
    { 
        // If first string is empty, the only option is to 
        // insert all characters of second string into first 
        if (m == 0) return n; 
        
        // If second string is empty, the only option is to 
        // remove all characters of first string 
        if (n == 0) return m; 
        
        // If last characters of two strings are same, nothing 
        // much to do. Ignore last characters and get count for 
        // remaining strings. 
        if (str1[m - 1] == str2[n - 1]) 
            return RecursiveEditDist(str1, str2, m - 1, n - 1); 
        
        // If last characters are not same, consider all three 
        // operations on last character of first string, recursively 
        // compute minimum cost for all three operations and take 
        // minimum of three values. 
        return 1 + Math.Min ( RecursiveEditDist(str1, str2, m, n - 1), // Insert 
                        Math.Min(RecursiveEditDist(str1, str2, m - 1, n), // Remove 
                        RecursiveEditDist(str1, str2, m - 1, n - 1) // Replace  
                        )                    
                    ); 
    } 

    public int RecurMinDistance(string word1, string word2, int pos1, int pos2)
    {
        if(pos1 ==0) return pos2;
        if(pos2 == 0) return pos1;

        if(word1[pos1-1] == word2[pos2-1])
            return RecurMinDistance(word1, word2, pos1-1, pos2-1);
        
        return Math.Min(RecurMinDistance(word1, word2, pos1, pos2 - 1), // Insert
                        Math.Min(RecurMinDistance(word1, word2, pos1 - 1, pos2 - 1), //Replace
                                RecurMinDistance(word1, word2, pos1 - 1, pos2)))  // Delete
                + 1;
    }
}
