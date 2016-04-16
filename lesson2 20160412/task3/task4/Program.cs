using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить 2 матрицы размерности NxN случайными числами. Вывести на консоль. Сложить 2 матрицы. Вывести результат.
            Console.WriteLine("Введите размерность матриц N (NxN)");
            string str_N = Console.ReadLine();
            int N = Convert.ToInt32(str_N);
            Random rand = new Random();


            Int32[,] matr1 = new Int32[N, N];
            Int32[,] matr2 = new Int32[N, N];
            for (int i=0;i < N;i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matr1[i, j] = rand.Next(1000); //ограничился 1000 
                    matr2[i, j] = rand.Next(1000); //ограничился 1000 

                }
                
            }

            //Вывод на консоль
            Console.WriteLine("Матрица1");


            for (int i = 0; i < N; i++,Console.WriteLine (""))
            {for (int j = 0; j < N; j++)

                //{ Console.Write(matr1[i, j] +"\t") ;
                {
                    Console.Write(matr1[i, j] + "\t");

                }
            }



            Console.WriteLine("");
            Console.WriteLine("Матрица2");


            for (int i = 0; i < N; i++, Console.WriteLine(""))
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matr2[i, j]  +"\t");

                }
            }



            //сложение массивов 

            Int32[,] SumMatr = new Int32[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    SumMatr[i, j] = matr1[i, j] + matr2[i, j];

                }
            }

            Console.WriteLine(""); // вывод на консоль итоговой матрицы
            Console.WriteLine("Результат сложения двух массивов");


            for (int i = 0; i < N; i++, Console.WriteLine(""))
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(SumMatr[i, j] + "\t");

                }
            }




        }

    }
}
