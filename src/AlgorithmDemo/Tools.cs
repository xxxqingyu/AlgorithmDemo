using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class Tools
    {
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static int[] GetInputArray()
        {
            Console.Write("请输入数组:");
            var items = Console.ReadLine().Split(",， ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return items.Select(n => int.Parse(n)).ToArray();
        }

        public static int[] CopeArray(int[] array)
        {
            int[] bArray = new int[array.Length];
            Array.Copy(array, bArray, array.Length);
            return bArray;
        }

        public static void Print(string title,int[] array)
        {
            Console.Write("{0}", title);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0,3} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
