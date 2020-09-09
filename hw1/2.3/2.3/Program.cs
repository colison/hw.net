using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 2;
            int []num = new int[100];
            for (int i = 0; i < 100; i++)
                num[i] = i + 1;
            for(index = 2; index <= 100; index++)
            {
                for(int i = 0; i < 100; i++)
                {
                    if (num[i]!=index && num[i] % index == 0)
                        num[i] = 0;
                }
            }
            for(int i = 0; i < 100; i++)
            {
                if (num[i] != 0)
                    Console.WriteLine(num[i]);
            }
        }
    }
}
