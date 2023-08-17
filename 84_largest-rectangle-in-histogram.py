from typing import List


class Solution:
    def largestRectangleArea(self, heights: List[int]) -> int:
        heights.append(0)
        ans = 0
        stack = [-1]
        for i in range(len(heights)):
            while heights[i] < heights[stack[-1]]:
                print(stack[-1])
                h = heights[stack.pop()]
                w = i - stack[-1] -1
                ans = max(ans, h * w)
                print('i:' + str(i) +
                    ' start: ' + str(stack[-1]) +' end: ' +str(i) + ' w: ' + str(w) + ' h: ' + str(h) + ' ans: ' + str(ans) )
            
            stack.append(i)
            print(stack)

        heights.pop()
        return ans

    def bfLargestRectangleArea(self, heights):
        # brute force solution with time complexity of O(n^2)

        n = len(heights)
        if n == 0 : return 0
        res = 0
        for i in range(n):
            j = i
            h = heights[i]
            while j >= 0:
                h = min(h, heights[j])
                j -=1
                res = max(res, h*(i-j))
        return res
instance = Solution()
print(instance.largestRectangleArea([2,1,5,6,2,3]))

# print(instance.largestRectangleArea([2, 4]))

# print(instance.largestRectangleArea([2, 4, 5, 2, 3, 2]))


