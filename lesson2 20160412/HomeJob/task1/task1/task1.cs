﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_hometask1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Заполнить массив длиной N случайными числами. Ввести с консоли число A. 
            //Вывести Yes, если число A есть в массиве, No - в противном случае.

            Console.WriteLine("Введите длину массива N ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число А ");
            int A = Convert.ToInt32(Console.ReadLine());


            Random rand = new Random();
            Int32[] mass = new Int32[N];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(100); //ограничился 100
            }


            bool printYes = false;

            foreach (int ii in mass)
            {

                if (ii == A)
                {
                    printYes = true;

                    break;
                }

            }

            if (printYes)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}

