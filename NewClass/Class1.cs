using System;

namespace NewClass
{
    public class Class1
    {
        public static int argss(int[] Arry1, int a)
        {
            for (int i = 0; i < Arry1.Length; i++)
            {
                if (a == Arry1[i])
                {
                    Console.WriteLine($"{a}");

                }
            }
            return a;
        }
    }
}
