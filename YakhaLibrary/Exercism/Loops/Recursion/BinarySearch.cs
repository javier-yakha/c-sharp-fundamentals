using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Loops.Recursion
{
    public static class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            int start = 0;
            int mid;
            int end = input.Length - 1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (input[mid] == value) return mid;
                else if (input[mid] < value) start = mid + 1;
                else end = mid - 1;
            }
            return -1;
        }
        public static int FindR(int[] input, int value, int lo, int hi)
        {
            if (lo > hi) return -1;

            int mid = lo + (hi - lo) / 2;

            if (input[mid] == value) return mid;
            else if (input[mid] > value) return FindR(input, value, lo, mid - 1);
            else return FindR(input, value, mid + 1, hi);
        }
    }
}
