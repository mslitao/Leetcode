class Solution:
    
    def uniquePaths(self, m: int, n: int) -> int:
        # DP
        table = [[0]*n for i in range(m)]
        table[0] = [1]*n

        for i in range(1, m):
            for j in range(n):
                table[i][j] = table[i-1][j]
                if j > 0:
                    table[i][j] += table[i][j-1]
        
        return table[m-1][n-1]


instance = Solution()
print(instance.uniquePaths(3,7))