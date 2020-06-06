/*
Write a function

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns the number of distinct values in array A.

For example, given array A consisting of six elements such that:

 A[0] = 2    A[1] = 1    A[2] = 1
 A[3] = 2    A[4] = 3    A[5] = 1
the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
*/

using System;

namespace Codility06._1
{
    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;
            Array.Sort(A);
            int s = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                    s++;
            }
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] A = { 2, 1, 1, 2, 3, 1 };
            int s = sol.solution(A);
            Console.WriteLine("Solution: " + s);
        }
    }
}
