using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat03
{
    public static class PG2Sorting
    {
        public static void BubbleSort(List<string> A)
        {
            int n = A.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n-1; i++)
                {
                    if (A[i - 1].CompareTo(A[i]) > 0)
                    {
                        string temp = A[i - 1];
                        A[i - 1] = A[i];
                        A[i] = temp;
                        swapped = true;
                    }
                }
                --n;
            } while (swapped);
        }
    }
}
