using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorterings_algoritmer
{
    class Algoritmer
    {
        public static void Bubblesort(List<int> data)
        {
            int max = data.Count - 1;

            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;

                for (int j = 0; j < nrLeft; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        public static void Selectionsort(List<int> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int minima = data[i];
                int mindex = i;
                int temp;

                for (int j = i + 1; j < data.Count; j++)
                {
                    if (data[j] < minima)
                    { minima = data[j]; mindex = j; }
                }

                if (data[mindex] != data[i])
                {
                    temp = data[i];
                    data[i] = data[mindex];
                    data[mindex] = temp;
                }

            }
        }
        public static List<int> Mergesort(List<int> data)
        {
            if (data.Count <= 1)
                return data;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = data.Count / 2;

            for (int i = 0; i < middle; i++)
                left.Add(data[i]);
            for (int i = middle; i < data.Count; i++)
                right.Add(data[i]);


            left = Mergesort(left);
            right = Mergesort(right);

            return Merge(left, right);
        }
        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }

            }
            return result;
        }
        public static void Quicksort(List<int> data, int min, int max)
        {

            int pivot = data[(min + max) / 2];
            int minHold = min;
            int maxHold = max;

            while (minHold < maxHold)
            {

                while ((data[minHold] < pivot) && (minHold <= maxHold))
                    minHold++;
                while ((data[maxHold] > pivot) && (maxHold >= minHold))
                    maxHold--;

                if (minHold < maxHold)
                {
                    int temp = data[minHold];
                    data[minHold] = data[maxHold];
                    data[maxHold] = temp;

                    if (data[minHold] == pivot && data[maxHold] == pivot)
                        minHold++;
                }
            }

            if (min < minHold - 1)
                Quicksort(data, min, minHold - 1);
            if (max > maxHold + 1)
                Quicksort(data, maxHold + 1, max);
        }
    }
}
