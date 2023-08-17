from typing import List
from copy import copy, deepcopy

class Solution:
    def solveNQueens(self, n: int) -> List[List[str]]: 
        results = []
        board = []
        for i in range(n):
            board.append(['.']*n)
        for i in range(n):
            self.backtrackNQueens(n, results, board, 0, i)
            board[0][i] = '.'

        return results

    def backtrackNQueens(self, n, results, board, rowIdx, colIdx):
        isValid = True
        for i in range(colIdx):
            if board[rowIdx][i] == 'Q':
                isValid = False
                break
        for i in range(rowIdx):
            if board[i][colIdx] == 'Q':
                isValid = False
                break
        i,j = rowIdx, colIdx
        while i >=0 and i < n and j>=0 and j< n:
            if board[i][j] == 'Q':
                isValid = False
                break
            i-=1
            j-=1
        
        i,j = rowIdx, colIdx
        while i >=0 and i < n and j>=0 and j< n:
            if board[i][j] == 'Q':
                isValid = False
                break
            i-=1
            j+=1
        
        if not isValid: 
            return

        board[rowIdx][colIdx] = 'Q'
        if rowIdx == n -1:
            results.append([''.join(board[i]) for i in range(n)])
            return
        
        for i in range(n):
            self.backtrackNQueens(n, results, board, rowIdx +1, i)
            board[rowIdx+1][i] = '.'
        return

instance = Solution()
print(instance.solveNQueens(4))
