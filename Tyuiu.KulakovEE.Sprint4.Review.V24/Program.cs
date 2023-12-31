﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint4.Review.V24.Lib;

namespace Tyuiu.KulakovEE.Sprint4.Review.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "СпринтРевью #4 | Выполнил: Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Вариант #24                                                              *");
            Console.WriteLine("*Выполнил: Кулаков Е.Е. | АСОиУб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("651827384219648                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Матрица:");
            string str = "651827384219648";
            int[,] matrix = new int[5, 3];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[count]);
                    if (j == 2)
                    {
                        Console.Write($"{str[count]} \n");
                    }
                    else
                    {
                        Console.Write($"{str[count]} \t");
                    }
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(service1.Calculate(5, 3, str));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}