using System;

namespace HWork12._01
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task());
            Console.WriteLine(Task2.Task());
            Console.WriteLine(Task3.Task());
        }

        static double Task()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            double result = (Math.Log10(2 * c) + d - 52) / ((a / 4) + 1);

            return result;
        }
    }
}
