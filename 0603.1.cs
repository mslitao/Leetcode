/*arr = [1, 3, 1, 2, 3, 4]

arr = [1, 3, 0, 2]

 X
 X X
XX X



     X
 XooXX
 XoXXX
XXXXXX

1 + 2 = 3 
    


f(arr) -> volOfWater = 1

Problem: get max number of water being stored in the container based on the edges of the container
Input: array of interger 
Output: interger 

Solution:
- Rolling/moving windows
- Count the waters in the between
1, 3, 1, 2
    
Start: 0
End: 0 -> Length-1

Decide a pos to count water in the window [start, end]
Update the new start

Stack 
*/

using System;
using System.Collections.Generic;

//1, 3, 2, 2, 3, 4
//1, 4, 2, 3, 5 -> 1 + 2= 3
/*
arr[j]  +1*1
        +1*2
         3
    
    +1
    +1*2 
    3
    
*/


public int GetWaterInTheContainer(List<int> arr)
{
    if(arr==null || arr.Length <= 2)  return 0;
    
    int n = arr.Length;
    int sumOfWater = 0;
    
    for(int i = 0; i < n; ++ i)
    {
        if(i >= 2 && arr[i] > arr[i -1])
        {
            for(int j = i -1; j > 0 && arr[j] < arr[i]; j --)
            {
                int top = Math.Min(arr[j -1], arr[i]);
                
                // Square : height * width
                sumOfWater += (top - arr[j]) * (i - j);
                
                // Update the number
                arr[j] = top;
            }
        }
    }
    
    return sumOfWater;
}

