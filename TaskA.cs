using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2CSharp_function_tabulation
    {
        internal class PartA
        {
            public static void Tabulation()
            {
                Console.Write("Enter a step of tabulation: "); // by condition 0,02
                double h = double.Parse(Console.ReadLine());
                Console.Write("Enter the first number of interval: "); //by condition 0,5
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter the last number of interval: "); // by condition 0,9
                double b = double.Parse(Console.ReadLine());

                double result;

                for (double x = a; x <= b; x += h)
                {
                    if (x < 0.6)
                    {
                        result = Math.Cos(Math.Sqrt(x));
                        Console.WriteLine("The result of the COS calculation is: " + result);
                    }
                    else if (x >= 0.6 && x < 0.7)
                    {
                        result = Math.Cos(Math.Pow(x, 2)) / Math.Sin(Math.Pow(x, 2));
                        Console.WriteLine("The result of the Ctg calculation is: " + result);
                    }
                    else
                    {
                        result = Math.Atan(Math.Pow(x, 3));
                        Console.WriteLine("The result of the arctg calculation is: " + result);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();


            }
        }
    
}

