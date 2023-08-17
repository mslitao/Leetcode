from typing import List


class Solution:
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        # DP
        m = len(obstacleGrid)
        if m ==0: return 0
        n = len(obstacleGrid[0])
        if n == 0: return 0

        table = [[0]*n for i in range(m)]
        for j in range(n):
            if obstacleGrid[0][j] == 1 or (table[0][j-1] ==0 and j > 0):
                table[0][j] = 0
            else:
                table[0][j] = 1

        for i in range(1, m):
            for j in range(n):
                if(obstacleGrid[i][j] == 1):
                    table[i][j] = 0
                    continue    
                table[i][j] = table[i-1][j]
                if j > 0:
                    table[i][j] += table[i][j-1]
        # print(table)        
        return table[m-1][n-1]

instance = Solution()
print(instance.uniquePathsWithObstacles([[0,0,0],[0,1,0],[0,0,0]]))

print(instance.uniquePathsWithObstacles([[0,1],[0,0]]))