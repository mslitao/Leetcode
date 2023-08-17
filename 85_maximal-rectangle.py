from typing import List


class Solution:
    def maximalRectangle(self, matrix: List[List[str]]) -> int:
        res = 0
        if not matrix: return res
        m = len(matrix)
        if m == 0:  return res
        n = len(matrix[0])
        if n == 0: return res

        dp = [[0]*(n+1) for i in range(m)]
        for i in range(m):
            for j in range(1, n+1):
                if matrix[i][j-1] == '1': 
                    dp[i][j] = dp[i][j-1] + 1

        
        for i in range(m):
            for j in range(1, n+1):
                if matrix[i][j-1] == '0':
                    continue

                width = float('inf')
                height = 0
                area = 0
                k = i
                while k >=0:
                    width = min(width, dp[k][j])
                    height +=1
                    if height == 0: 
                        break
                    area = max(area, height*width)
                    
                    k -=1

                
                res = max(res, area)

        return res
            
