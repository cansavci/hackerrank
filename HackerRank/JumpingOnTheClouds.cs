namespace HackerRank
{
    public static class JumpingOnTheClouds
    {
        public static int solution(int[] c)
        {
            int jumpsCount = 0;
            int sizeOfC = c.Length;
            for (int i = 0; i < sizeOfC; i++)
            {
                if (i == sizeOfC - 1)
                {
                    jumpsCount++;
                }
                else if (c[i + 2] == 0)
                {
                    i++;
                    jumpsCount++;
                }
                else
                {
                    jumpsCount++;
                }
            }
            return jumpsCount;
        }
    }
}
