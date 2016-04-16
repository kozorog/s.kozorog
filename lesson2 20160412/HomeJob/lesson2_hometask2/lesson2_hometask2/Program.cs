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
            int N = Convert.ToInt32(Console.ReadLine()); // число строк
            int M = Convert.ToInt32(Console.ReadLine()); // число столбцов
            Random rand = new Random();
            
            Int32[,] mass = new Int32[N, M]; //создаем матрицу
            //заполняем матрицу
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mass[i, j] = rand.Next(1000); //ограничился 1000 
                }

            }

            //Опционально выводим на консоль  массив
            Console.WriteLine("Матрица");


            for (int i = 0; i < N; i++, Console.WriteLine(""))
            {
                for (int j = 0; j < N; j++)

                {
                    Console.Write(mass[i, j] + "\t");

                }
            }

            // создаем итоговый массив  
            Int32[] OneMass = new Int32[N];   
              
            //заполняем его минимальными значениями из строк
            /*
           for (int i = 0; i < N; i++)
            {
                Int32[,] massmin = new Int32[i, 0];
                for (int j = 0; j < M; j++)
                {
                    Console.Write(massmin[i, j]);
                    //if (mass[i, j]  massmin( ) ;
                    //    min = massiv[i][j];//вот он!!!
                }
            }

            */




          

            /*
            Console.WriteLine(""); // вывод на консоль итоговой матрицы
            Console.WriteLine("Результат сложения двух массивов");


            for (int i = 0; i < N; i++, Console.WriteLine(""))
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(SumMatr[i, j] + "\t");

                }
            }

    */

            //--------------
        }
    }
}
