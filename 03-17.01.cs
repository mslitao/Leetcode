using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

public class Position
{
    public int X;
    public int Y;
    
    public Position(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

class Solution030701
{
    static void Main(string[] args)
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello, World");
        }
        
        Position start = new Position(0, 2);
        Position end = new Position(3, 0);
        
        
        TestComputePath(start, end);
    }
    
    public static void TestComputePath(Position start, Position end)
    {
        var resultPath = ComputePath(start, end);
        
        Console.WriteLine(String.Join(" ", resultPath));
        
    }
    
    public static List<char> ComputePath(Position start, Position end)
    {
        int xGap = end.X - start.X;
        char xDir = xGap > 0 ? 'W':'E'; 
        
        int yGap = end.Y - start.Y;
        char yDir = yGap > 0? 'S': 'N';
        
        Console.WriteLine(xGap);
        Console.WriteLine(yGap);
        
        List<char> path = new List<char>();
        for(int i = 0; i < Math.Abs(xGap); ++i)
        {
            path.Add(xDir);
        }
        
        for(int i = 0; i < Math.Abs(yGap); ++i)
        {
            path.Add(yDir);
        }
        
        return path;
    }
}


/*
Given an matrix with 0, S, and E, write a function to print out the path.

For example:

S: start (2, 0)
E: end (0, 3)

Rows: Negative diff means north
2 -> 0 Two North 
Columns
0 -> 3 Three West


[
 [0, 0, 100,   E],
 [0. 0, 100,  10],
 [S, 0, 100,  10],
 [10,10, 10   10],
]

W S W W N N N

[i,j] 

Memorized Recursive DP solution.
DPFun(i, j)
{
    if(DP[i, j] >0)) return dp[i, j];
    
    DP[i, j] = Math.Min(DPFun(i-1, j), DPFun(i, j -1)) + Cost(i, j);
    
    return DP[i, j];
}

Min Cost
[
 [0, 0, 10,  E],
 [0+0 , 0 +1 = 1,  1,  1],
 [S(0), 5+0=5, 20,  0],
 [0, 0,  8   0],
]

Previous direction
[
 [0, 0, 10,  N],
 [N, W,  W,  W],
 [ , W, 20,  0],
 [0, 0,  8   0],
]



Print "W W W N N"


DP Solution:
1. 2 dims arrary to store the min of cost from start to this position(i j)
2. dp[i,j] = min(dp[i-1, j], dp[i, j-1]) + cost[i, j]
            
   

Return dp[end.i, end.j]



Graph Search
BFS: 
DFS: Stack

Others:


*/