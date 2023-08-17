from typing import List


class Solution:
    def combine(self, n: int, k: int) -> List[List[int]]:
        resList = []
        if n <= 0 or k <= 0 or k > n: return resList

        res = []
        self.backtrackCombine(n, k, resList, res, -1)
        return resList

    
    def backtrackCombine(self, n, k, resList, current, idx):
        if len(current) == k:
            resList.append(current[:])
            return
        
        for i in range(idx + 1, n):
            current.append(i + 1)
            self.backtrackCombine(n, k, resList, current, i)
            current.pop()

instance = Solution()
print(instance.combine(4,2))