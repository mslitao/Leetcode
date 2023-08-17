from typing import List


class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        m =  len(grid)
        if m == 0: return 0
        n = len(grid[0])
        if n == 0: return 0
        # table = [[float('inf')]*n for i in range(m)]
        table = [[0]*n for i in range(m)]
        table[0][0] = grid[0][0]
        for j in range(1,n):
            table[0][j] = table[0][j-1] + grid[0][j]

        for i in range(1, m):
            table[i][0] = table[i-1][0] + grid[i][0]

            for j in range(1, n):
                table[i][j] = min(table[i-1][j], table[i][j-1]) + grid[i][j]
        
        return table[-1][-1]
instance = Solution()
print(instance.minPathSum([[1,3,1],[1,5,1],[4,2,1]]))

print(instance.minPathSum([[1,2,3],[4,5,6]]))
