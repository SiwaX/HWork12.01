using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWork12._01
{
    class Task3
    {

        public static int Task()
        {
            int _rows = int.Parse(Console.ReadLine());
            int _collums = int.Parse(Console.ReadLine());
            int _result = 0;

            Random rnd = new Random();

            int[,] array = new int[_rows, _collums];
            int[] tmpArray = new int[_collums];

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _collums; j++)
                {
                    array[i, j] = rnd.Next(1, 9);
                }
            }

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _collums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int j = 0; j < _collums; j++)
            {
                int tmp = int.MinValue;
                for (int i = 0; i < _rows; i++)
                {
                    if (array[i, j] > tmp)
                    {
                        tmp = array[i,j];
                        
                    }

                }
                Console.Write(tmp + "\t");
                tmpArray[j] = tmp;
            }

            int _min = tmpArray[0];
            Console.WriteLine();
            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (_min >= tmpArray[i])
                {
                    _min = tmpArray[i];
                    _result = _min;
                }

            }
            return _result;
        }

    }
}
