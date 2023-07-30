using System;
using System.Collections.Generic;

namespace Array_Programming_1
{
    internal class MergeTwoArray
    {
        public static void SortedArray(int[] a, int[] b,int n, int m)
        {
            SortedDictionary<int, bool> mp = new SortedDictionary<int, bool>();
            for(int i = 0; i < n; i++)
            {
                mp.Add(a[i], true);
            }
            for(int j = 0; j < m; j++)
            {
                mp.Add(b[j], true);
            }
           //printing the array values
           foreach(KeyValuePair<int,bool> me in mp)
            {
                Console.WriteLine(me.Key + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 8 };
            int[] b = { 1, 6, 7 };
            int size1 = a.Length;
            int size2 = b.Length;
            SortedArray(a, b, size1, size2);
        }
    }
}
