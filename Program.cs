using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В двумерном массиве порядка M на N поменяйте местами заданные столбцы.*/

            //1.Ввод данных
            Console.Write(" Размер массива N = : ");
            int sizeA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Размер массива M = : ");
            int sizeB = Convert.ToInt32(Console.ReadLine());

            //2.Проверка условий ввода данных
            if (sizeA < 0) sizeA *= -1;
            if (sizeB < 0) sizeB *= -1;
            if (sizeA == 0 || sizeB == 0)
            {
                Console.WriteLine($" Вы выбрали массив порядка {sizeA} x {sizeB}. \n " +
                                    $" Массива автоматически изменен до 3 х 4. \n");
                sizeA = 3;
                sizeB = 4;
            }

            //3.Созлание и заполнение массива
            int[,] arrRandom = new int[sizeA,sizeB];
            int[,] newArr = new int[sizeB, sizeA];
            Random rand = new Random(); //Для заполнения массива произвольными значениями
            Console.WriteLine("\n Исходный массив: \n");
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    arrRandom[i,j] = rand.Next(0, 10);
                    Console.Write(" " + arrRandom[i,j]);
                }
                Console.WriteLine("\n");
            }

            //4.Созлание второго массива и заполнение его данными первого массива
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    newArr[j, i] = arrRandom[i, j];
                }
            }

            //5.Вывод результата на экран
            Console.WriteLine("\n Перевернутый массив: \n");
            for (int i = 0; i < sizeB; i++)
            {
                for (int j = 0; j < sizeA; j++)
                {
                    Console.Write(" " + newArr[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
