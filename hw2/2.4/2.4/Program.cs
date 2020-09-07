using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            int[,] a = { { 1, 2, 3, 6}, { 5, 1, 2, 3 } , { 9, 5, 1, 2 }  };
            for(int  i = 0; i < a.GetLength(0); i++)
       
                for(int j = 0; j < a.GetLength(1); j++)

                    if ((i + 1) < a.GetLength(0) && (j + 1) < a.GetLength(1) && a[i, j] != a[i + 1, j + 1])
                        flag = false;
          
            Console.WriteLine(flag);
        }
    }
}
