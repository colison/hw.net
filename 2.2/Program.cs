using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= { 2,6,7,4,8};
            int sum = 0;
            for(int b = 0; b < a.Length; b++)
            {
                sum += a[b];
            }
            double s = sum * 1.0 / a.Length;
            Array.Sort(a);
            Console.WriteLine("总和:" + sum + "平均：" + s + "最大值：" + a[a.Length - 1] + "最小值：" + a[0]);
        }
    }
}
