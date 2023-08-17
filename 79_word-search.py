from typing import List


class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        if not board or not word: return False
        m = len(board)
        if m == 0: return False
        n = len(board[0])
        if n ==0: return False
        k = len(word)
        if k == 0: return True

        boardDic = {}
        for i in range(len(board)):
            for j in range(len(board[0])):
                if board[i][j] in boardDic:
                    boardDic[board[i][j]] += 1
                else:
                    boardDic[board[i][j]] = 1

        # Count number of letters in word
        # Check if board has all the letters in the word and they are atleast same count from word
        wordDic = {}
        for c in word:
            if c in wordDic:
                wordDic[c] +=1
            else:
                wordDic[c] =1
    
        for c in wordDic:
            if c not in boardDic or boardDic[c] < wordDic[c]:
                return False


        for i in range(m):
            for j in range(n):
                visited = {}
                results = []

                if self.dfsSearch(word, 0,
                                board, m, n, i, j,
                                visited, results): 
                    return True
        
        return False
    
    # DFS Search

    def dfsSearch(self, word, idx, board, m, n, i, j, visited, results):
        if i <0 or i >= m or j < 0 or j>= n: return False
        # if len(results) > 0: return True
        if str(i) + '|' + str(j) in visited: return False
        if board[i][j] != word[idx]: return False
        
        if idx == (len(word) -1): 
            results.append(str(i) + '|' + str(j))
            return True
        
        visited[str(i) + '|' + str(j)] = 1
        nextI = [0, 0, 1, -1]
        nextJ = [1, -1, 0, 0] 
        for nextIdx in range(4):
            if self.dfsSearch(word, idx + 1, 
                            board, m, n, i + nextI[nextIdx], j + nextJ[nextIdx],
                            visited, results):
                return True
        
        visited.pop(str(i) + '|' + str(j))
        return False


instance = Solution()
print(instance.exist(board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"))
print(instance.exist(board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"))
print(instance.exist(board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"))