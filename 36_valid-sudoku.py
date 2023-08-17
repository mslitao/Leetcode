from typing import List


class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for r in board:
            for c in r:
                print(c,end = " ")
            print()

        for i in range(9):
            if not self.isValid(board[i]): 
                print(board[i])
                return False

            columns = []
            for j in range(9):
                columns.append(board[j][i])
            if not self.isValid(columns): 
                print(columns)
                return False
            
            if not self.isValid(self.getSubset(board, 0, 0)): return False
            if not self.isValid(self.getSubset(board, 0, 3)): return False
            if not self.isValid(self.getSubset(board, 0, 6)): return False
            if not self.isValid(self.getSubset(board, 3, 0)): return False
            if not self.isValid(self.getSubset(board, 3, 3)): return False
            if not self.isValid(self.getSubset(board, 3, 6)): return False
            if not self.isValid(self.getSubset(board, 6, 0)): return False
            if not self.isValid(self.getSubset(board, 6, 3)): return False
            if not self.isValid(self.getSubset(board, 6, 6)): return False
        
        return True
    
    def getSubset(self, board: List[List[str]], i: int, j: int) -> List[str]:
        
        nums = [board[i][j], board[i][j+1], board[i][j+2], 
                board[i+1][j], board[i+1][j+1], board[i+1][j+2],
                board[i+2][j], board[i+2][j+1], board[i+2][j+2]
                ]
        
        return nums

    def isValid(self, nums: List[str]) -> bool:
        visited = []
        for i in range(9):
            if nums[i] == '.':
                continue
            elif (nums[i] >= '1' and nums[i] <= '9' ):
                if nums[i] in visited:
                    return False
                else:
                    visited.append(nums[i])
            else: return False
        
        return True
    

instance = Solution()
print(instance.isValidSudoku([[".",".","4",".",".",".","6","3","."],[".",".",".",".",".",".",".",".","."],["5",".",".",".",".",".",".","9","."],[".",".",".","5","6",".",".",".","."],["4",".","3",".",".",".",".",".","1"],[".",".",".","7",".",".",".",".","."],[".",".",".","5",".",".",".",".","."],[".",".",".",".",".",".",".",".","."],[".",".",".",".",".",".",".",".","."]]))