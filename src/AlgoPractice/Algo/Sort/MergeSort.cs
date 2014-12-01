using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Sort
{
    public class MergeSort : IAlgo<IInput<int[]>, int[]>
    {
        const int RECURESION_CUTOFF = 8;
        #region IAlgo<IInput<string[]>,string[]> Members

        public int[] Compute(IInput<int[]> input)
        {
            return Sort(input.Input);
        }
        private int[] Sort(int[] input)
        {
            var array = input;
            int length = array.Length;
            if (length <= RECURESION_CUTOFF)
            {
                Array.Sort(array);
                return array;
            }

            int n = (length + 1) / 2;
            int[] left = new int[n];
            int[] right = new int[length - n];

            Array.Copy(array, left, n);
            Array.Copy(array, n, right, 0, length - n);

            return Combine(Sort(left), Sort(right));
        }

        private int[] Combine(int[] array1, int[] array2)
        {
            int length = array1.Length + array2.Length;
            int[] result = new int[length];

            int i = 0, j = 0, k = 0;

            while (k < length)
            {
                if (i == array1.Length)
                {
                    result[k] = array2[j];
                    j++;
                }
                else if (j == array2.Length)
                {
                    result[k] = array1[i];
                    i++;
                }
                else if ((array1[i] <= array2[j]))
                {
                    result[k] = array1[i];
                    i++;
                }
                else
                {
                    result[k] = array2[j];
                    j++;
                }
                k++;
            }

            return result;
        }

        #endregion
    }
}
