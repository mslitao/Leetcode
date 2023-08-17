class Solution:
    

    def climbStairs(self, n: int) -> int:
        if n < 1: return 0
        return self.backtrackClimb(n, 1, 1) + self.backtrackClimb(n, 2, 1)

    def dpClimb(self, n: int) -> int:
        if n <= 1: return n
        dp = [0]*(n+1)
        dp[0] = 1
        dp[1] = 1
        for i in range(2, n +1):
            dp[i]= dp[i-1] + dp[i-2]

        return dp[-1]

    def backtrackClimb(self, n: int, current:int, steps: int) -> int:
        if current == n:
            return 1
        if current > n:
            return 0
        
        return self.backtrackClimb(n, current + 1, steps + 1) + self.backtrackClimb(n, current + 2, steps + 1)

instance = Solution()
print(instance.climbStairs(2))
print(instance.dpClimb(2))
print(instance.climbStairs(3))
print(instance.dpClimb(3))

# second solution: DP
        
        