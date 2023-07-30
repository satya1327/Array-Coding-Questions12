using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Programming_1
{
    public class Array_duplicate_removed
    {
        public static int Array_Duplicate(int[] arr, int size)
        {
            if (size == 0 || size == 1)
            {
                return size;
            }
            int[] temp = new int[size];
            int j = 0;
            for (int i = 0; i < size - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                }
            }
            temp[j++] = arr[size - 1];
            for(int i = 0; i < j; i++)
            {
                arr[i] = temp[i];
            }
            return j;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 10, 20, 30, 40, 40, 50 };
            int size = arr.Length;
            int len=Array_Duplicate(arr, size);
            for(int i = 0; i < len; i++)
            {
                Console.Write(arr[i]+ " ");
            }

            
        }
    }
}
