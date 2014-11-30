using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Sort
{
    public class MergeSort : IAlgo<IInput<int[]>, int[]>
    {
        const int RECURESION_CUTOFF = 32;
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
            array.CopyTo(left,0);

            Array.Copy(array, left, n);
            Array.Copy(array, n, right, 0, length - n);

            return Combine(Sort(left), Sort(right));
        }

        private int[] Combine(int[] array1, int[] array2)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
