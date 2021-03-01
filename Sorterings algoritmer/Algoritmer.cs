using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorterings_algoritmer
{
    class Algoritmer
    {
        public static void Bubblesort(List<int> list)
        {
            int max = list.Count - 1;

            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;

                for (int j = 0; j < nrLeft; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public static void Selectionsort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int minima = list[i];
                int mindex = i;
                int temp;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < minima)
                    { minima = list[j]; mindex = j; }
                }

                if (list[mindex] != list[i])
                {
                    temp = list[i];
                    list[i] = list[mindex];
                    list[mindex] = temp;
                }

            }
        }
        public static List<int> Mergesort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;

            for (int i = 0; i < middle; i++)
                left.Add(list[i]);
            for (int i = middle; i < list.Count; i++)
                right.Add(list[i]);


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
