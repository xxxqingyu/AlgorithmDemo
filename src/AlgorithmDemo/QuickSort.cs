using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class QuickSort
    {
        public static void Sort(int[] array)
        {
            RecSort1(array, 0, array.Length - 1);
        }

        //快速排序  
        public static void RecSort1(int[] array, int first, int last)
        {
            if (first < last)
            {
                int i = first, j = last, x = array[first];
                while (i < j)
                {
                    while (i < j && array[j] >= x) 
                        j--;
                    if (i < j)
                        array[i++] = array[j];

                    while (i < j && array[i] < x) 
                        i++;
                    if (i < j)
                        array[j--] = array[i];
                }
                array[i] = x;
                RecSort1(array, first, i - 1);
                RecSort1(array, i + 1, last);
            }
        }

        public static void RecSort2(int[] array, int first, int last)
        {
            if (first < last)
            {
                int i = first, j = last, x = array[first];
                while (i < j)
                {
                    while (i < j && array[j] >= x)
                        j--;
                    if(i < j)
                        array[i++] = array[j];

                    while (i < j && array[j] < x)
                        i++;
                    if (i < j)
                        array[j--] = array[i];
                }
                array[i] = x;
                RecSort2(array, first, i - 1);
                RecSort2(array, i + 1, last);
            }
        }
    }
}
