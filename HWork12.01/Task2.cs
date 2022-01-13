using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWork12._01
{
    class Task2
    {
       public static double Task()
        {
            Console.WriteLine("Введите N(Длинная массива) \n K и L(Интервал)");
             int N = Convert.ToInt32(Console.ReadLine());
             int K = Convert.ToInt32(Console.ReadLine());
             int L = Convert.ToInt32(Console.ReadLine());
            int result = 0;
             

            if (K < 1)
            {
                Console.WriteLine($"Не верное условие! \n К={K} меньше 1 ");
                K = Convert.ToInt32(Console.ReadLine());
            }
            else if (L > N && K > L)
            {

                Console.WriteLine($"Не верное условие! \n L={L} должно быть больше К={K}, и меньше N={N} ");
                L = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Условие соблюдены");
            }


            int[] array = new int[N];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(1, 9);
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + "\t");
            }

            for (int i = K; i < L; i++)
            {
                result += array[i];
            }

            Console.WriteLine();
            Console.Write("Результат:");
            return result;
        }
    }
}
