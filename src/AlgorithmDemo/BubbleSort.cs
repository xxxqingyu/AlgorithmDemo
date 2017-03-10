using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    /// <summary>
    /// 最差时间分析:O(n2)
    /// 平均时间复杂度:O(n2)
    /// 稳定度:稳定
    /// 空间复杂度:O(1)
    /// </summary>
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Tools.Swap(array, j - 1, j);
                    }
                }
            }
        }
    }
}
