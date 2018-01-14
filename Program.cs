using System;

namespace SherlockAndCost
{
    class Sherlock
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                Console.WriteLine(cost(arr));
            }
        }

        public static int cost(int[] B)
        {
            int[] S = new int[2];
            int[] oS = new int[2];
            for(int i = 1; i < B.Length; i++)
            {
                S[0] = Math.Max(oS[0] + Math.Abs(B[i] - B[i - 1]), oS[1] + Math.Abs(B[i] - 1));
                S[1] = Math.Max(oS[0] + Math.Abs(B[i - 1] - 1), oS[1]);
                oS[0] = S[0];
                oS[1] = S[1];
            }
            return Math.Max(S[0], S[1]);
        }
    }
}
