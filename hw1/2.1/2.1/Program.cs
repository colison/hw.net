using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入指定数据");
            int s = Int32.Parse(Console.ReadLine());
            int a ;
            Console.WriteLine("输出的质因数：");
            for (a=2; a <= s; a++)
            {
                if (s % a == 0)
                {
                    Console.WriteLine(a+" ");
                    while(s%a==0)
                        s = s / a;
                }
            }
        }
    }
}
