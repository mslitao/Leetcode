from typing import List


class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        # print(matrix)

        m = len(matrix)
        if m == 0: return matrix
        n = len(matrix[0])
        if n == 0: return matrix

        for i in range(m):
            for j in range(n):
                if matrix[i][j] == 0:
                    print(str(i) + str(j))
                    for k in range(n):
                        if matrix[i][k] != 0:
                            matrix[i][k] = float('inf')
                    for k in range(m):
                        if matrix[k][j] != 0:
                            matrix[k][j] = float('inf')
        # print(matrix)
        for i in range(m):
            for j in range(n):
                if matrix[i][j] == float('inf'):
                    matrix[i][j] = 0

        print(matrix)


instance = Solution()
instance.setZeroes([[1,1,1],[1,0,1],[1,1,1]])

[[0,1,2,0],[3,4,5,2],[1,3,1,5]]

            