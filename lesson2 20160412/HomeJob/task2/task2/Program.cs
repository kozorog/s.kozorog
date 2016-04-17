using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный элемент, занести его в массив. 
            //Отсортировать полученный массив и вывести его значения в обратном порядке.

            Console.WriteLine("Введите размерность N матрицы (NxM)");
            int N = 0;
            int M = 0;
            N = Convert.ToInt32(Console.ReadLine()); // число строк
            M = Convert.ToInt32(Console.ReadLine()); // число столбцов
            Random rand = new Random();

            Int32[,] mass = new Int32[N, M]; //создаем матрицу
            //заполняем матрицу
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mass[i, j] = rand.Next(1000); //ограничился 1000 
                }

            }

            //Опционально выводим на консоль  массив
            Console.WriteLine("Матрица");


            for (int i = 0; i < N; i++, Console.WriteLine(""))
            {
                for (int j = 0; j < M; j++)

                {
                    Console.Write(mass[i, j] + "\t");

                }
            }

            // создаем итоговый массив  
            int[] OneMass = new int[N];
            //заполняем его минимальными значениями из строк


            for (int i = 0; i < N; i++)
            {
                OneMass[i] = mass[i, 0];

                for (int j = 1; j < M; j++)
                {
                    if (mass[i, j] < OneMass[i])
                        OneMass[i] = mass[i, j];
                }

                //Console.WriteLine("minelement = " + OneMass[i]);
            }


            Array.Sort(OneMass);
            Console.WriteLine("Отсортированная в обратном порядке массив мин. значений:");
            for (int i = N - 1; i >= 0; i--)

            {
                Console.WriteLine(OneMass[i]);
            }



        }
    }
}
