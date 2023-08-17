from typing import List


class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        candidates.sort()
        results = []
        self.backtraceCombinationSum(results, target, candidates, 0, 0, [])

        return results

    def backtraceCombinationSum(self, results, target, candidates, curIdx, curSum, curSet):
        if curSum == target:
            results.append(curSet[:])
            return
        
        if curSum > target:
            return
        
        for i in range(curIdx, len(candidates)):
            if i > curIdx and candidates[i] == candidates[i-1]: continue

            curSet.append(candidates[i])
            self.backtraceCombinationSum(results, target, candidates, i+1, curSum + candidates[i], curSet)
            curSet.pop()
        
        return