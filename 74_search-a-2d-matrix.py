from typing import List


class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        # Quick sort (Binary Search)
        m = len(matrix)
        if m == 0: return False
        n = len(matrix[0])
        if n == 0: return False

        return self.binarySearchMatrics(matrix, target, m, n, 0, n-1)

    def binarySearchMatrics(self, matrix, target, m, n, i, j):
        if i < 0 or i>=m or j <0 or j>= n: return False
        
        if matrix[i][j] == target: return True

        if matrix[i][j] > target:
            return self.binarySearchMatrics(matrix, target,  m, n, i, j -1)
        else:
            return self.binarySearchMatrics(matrix, target, m, n, i+1, j)

instance = Solution()
print(instance.searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]], 3))