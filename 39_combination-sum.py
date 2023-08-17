from typing import List


class Solution:
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
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
            curSet.append(candidates[i])
            self.backtraceCombinationSum(results, target, candidates, i, curSum + candidates[i], curSet)
            curSet.pop()
        
        return

    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        resSets = [[]]
        resSums = [0]

        results = []
        resultsDict = {}
        while len(resSets) > 0:
            tmpSize = len(resSets)
            for i in range(tmpSize):
                curSet = resSets.pop(0)
                curSum = resSums.pop(0)
                for can in candidates:
                    newSet = curSet[:]
                    newSet.append(can)
                    newSum = curSum + can
                    if newSum == target:
                        newSet.sort()
                        resultKey = ''.join([str(x) for x in newSet])
                        if resultKey not in resultsDict:
                            results.append(newSet)
                            resultsDict[resultKey] =1
                    elif newSum < target:
                        resSets.append(newSet)
                        resSums.append(newSum)

        return results

instance = Solution()
print(instance.combinationSum([2,3,6,7], 7))


