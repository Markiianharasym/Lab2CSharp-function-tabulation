﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp_function_tabulation
    {
        internal class PartB
        {
            public static void TabulationTwo()
            {
                Console.Write("Enter a step of tabulation: "); // by condition 0,05
                double h = double.Parse(Console.ReadLine());
                Console.Write("Enter the first number of interval: "); //by condition 0,5
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter the last number of interval: "); // by condition 1
                double b = double.Parse(Console.ReadLine());


                int N = 1000;
                double result;
                double sum = 0;
                Console.WriteLine("Tabulation results:");
                Console.WriteLine("x\t\tResult");


                for (double x = a; x < b; x += h)
                {
                    sum = 0;
                    for (int k = 1; k <= N; k++)
                    {
                        result = x / ((2 * k + 1) * (2 * k + 2)) * Math.Sin(k + 1);
                        sum += result;
                    }
                    Console.WriteLine($"{x:F2}\t\t Sum:{sum}");

                }

            }
        }
    }


