using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    /// <summary>
    /// 选择排序
    /// 最差时间分析:O(n2)
    /// 平均时间复杂度:O(n2)
    /// 稳定度:稳定
    /// 空间复杂度:O(1)
    /// </summary>
    public class SelectionSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        min = j;
                    }
                }
                Tools.Swap(array, min, i);
            }
        }
    }
}
