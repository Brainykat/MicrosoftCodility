using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MicrosoftCodility
{
    public class Class1
    {
        //Practise
        public int solution(int[] A)
        {
            //HashSet<int> B = new HashSet<int>();
            //// write your code in C# 6.0 with .NET 4.5 (Mono)
            //var max = A.ToList().Max();
            //if (max <= 0) return 1;
            //var min = A.ToList().Min();
            //if (min <= 0) min = 1;
            //A = A.OrderBy(x => x).ToArray();
            //for (var i = 1; i <= max; i++)
            //{
            //    if (!A.ToList().Any(s => s == i)) return i;
            //}
            //return max + 1;
            var i = 0;
            return A.Where(a => a > 0).Distinct().OrderBy(a => a).Any(a => a != (i = i + 1)) ? i : i + 1;
        }
        //Q1
        public int solution2(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var digits = Math.Floor(Math.Log10(N) );
            return (int) Math.Pow( 10 , (int)digits);
        }
        //Q2
        public int solution3(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //Console.WriteLine(S);
            //var i = Convert.ToUInt64(S.Trim(), 2);
            //Console.WriteLine(i);
            BigInteger res = 0;
            foreach (char c in S)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }
            var i = res;
            if (i <= 0) return 0;
            int counter = 0;
            while (i > 0)
            {
                if (i % 2 == 0) { i = i / 2; }
                else { i = i - 1; }
                counter = counter + 1;
            }
            return counter;
        }
        //Q3
        public int solution4(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int len = A.Length;
            int count = 0;

            for (int j = 0; j < len - 1; j++)
            {
                for (int i = j + 1; i < len; i++)
                {
                    if (A[i] == A[j])
                        count++;
                }
            }
            return count;
        }
    }
}
/*
 This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
     */
