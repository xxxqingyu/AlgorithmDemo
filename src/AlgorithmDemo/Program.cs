using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var array = new int[] { 5, 2, 3, 6, 4, 7 };//Tools.GetInputArray();

            Console.WriteLine("快速排序：");
            var copyArray1 = Tools.CopeArray(array);
            Tools.Print("原始数组：", copyArray1);
            QuickSort.Sort(copyArray1); 
            Tools.Print("快速排序1：",copyArray1);

            Console.Read();
        }
    }
}
