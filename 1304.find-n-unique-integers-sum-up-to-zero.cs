public class Solution1304 
{
    public int[] SumZero(int n) {            
        int[] results = new int[n];
        for (int i = 0; i < n / 2; i++) {
            results[i] = n - i;
            results[n - i - 1] = - (n - i);
        }
        return results;
    }
}