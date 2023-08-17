class Solution:
    def minDistance(self, word1: str, word2: str) -> int:
        return self.dpMinDistance(word1, word2, len(word1), len(word2))

    def dpMinDistance2(self, word1, word2, m, n) -> int:
        dp = [[0] * (n + 1) for i in range(m + 1)] 
        for i in range(m + 1):
            for j in range(n + 1):
                if i == 0:
                    dp[i][j] = j
                elif j == 0:
                    dp[i][j] = i
                elif word1[i - 1] == word2[j - 1]:
                    dp[i][j] = dp[i-1][j-1]
                else:
                    dp[i][j] = 1 + min( dp[i-1][j], 
                                        dp[i][j-1], 
                                        dp[i-1][j-1])
        return dp[m][n]


    def dpMinDistance(self, word1, word2, m, n) -> int:
        if m == 0:
            return n
        if n ==0:
            return m
        
        if(word1[m - 1] == word2[n - 1]):
            return self.dpMinDistance(word1, word2, m-1, n-1)
        
        return 1+ min(self.dpMinDistance(word1, word2, m, n-1),
                    self.dpMinDistance(word1, word2, m-1, n),
                    self.dpMinDistance(word1, word2, m-1, n-1)
                    )