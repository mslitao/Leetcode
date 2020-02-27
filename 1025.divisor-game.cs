
public class Solution1025 {
    public bool DivisorGame(int N) 
    {
        int x = 1;
        bool alice = true;
        while(N > 0)
        {
            while(x < N && N % x != 0)
            {
                x ++;
            }

            N = N -x;
            alice = !alice;
        }

        return alice;
    }
}