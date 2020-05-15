// A Query system
// query word: string
// Write a function to return the top K most frequently queried words. 
// Tie breaker: most recently queried
// E.g.,
// Q: "a"
// Q: "b"
// top(1): "b"
// Q: "c"
// Q: "b"
// top(2): "b", "c"

/*
Step 1: Statis for each query
query - Freq, LastTime
Step 2: 
OrderBy(Freq).ThenBy(LastTime) 

Service:
Freq - 


    
//Storage & Data strcture

<Query, Freq, Time, Index>  

QueryMap| Key: Query - Value:  Statistics 
FreqMap|Key: Freq - Value: List of Query (Sort by time)  (Last one is the latest one)

1. Update(string query) 
    a. find query with the staistics
    b. update the freq and time
    c. rerank
    
    Query : q 
    - Look up in the QueryMap
        - Exist: Update: Query, Freq+1, Time = time
        - else: Create: Query, Freq = 1, Time = time
        
        Freq, NewFreq
    - Look up in the FreqMap
        - Update the Recored on key of Freq
            - Must Exist 
            - Delete the record in the list O(avg(cnt per freq)) -> O(1)
            ()
        - Update the record on key of NewFreq
            - Exist: Add to the last 
            - Else: If the list is NULL, create a new list. Add to the last.
        
        return the index 
    - Update the index back to the query stats
    
2. TopK(int k) - Heavy more efficent 
    a. Return top k results


L1: Rank by frequency of query ()
L2: Rank by time on frequency
Sort: Quick Sort 

*/