using System;

namespace C_Task_1._7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arry1 = { 7, 8, 3, 4, 5, 6 };
            Console.WriteLine("please enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Class1.argss(Arry1, a));
        }
    }
}
