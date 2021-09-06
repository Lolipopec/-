using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double[] mass = mathcl(i, "Sum");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"X:\Дергач\ConsoleApp\bin\Debug\Sum.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.WriteLine("Итог:" + MathCl.Sum(mass) + "\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double[] mass = mathcl(i, "Mul");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"X:\Дергач\ConsoleApp\bin\Debug\Mul.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.WriteLine("Итог:" + MathCl.Mul(mass) + "\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double[] mass = mathcl(i, "Average");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"X:\Дергач\ConsoleApp\bin\Debug\Average.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.WriteLine("Итог:" + MathCl.Average(mass) + "\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double[] mass = mathcl(i, "GeomAverage");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"X:\Дергач\ConsoleApp\bin\Debug\GeomAverage.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.WriteLine("Итог:" + MathCl.GeomAverage(mass) + "\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
        }
        public static double[] mathcl(int i, string str)
        {
            Random r = new Random();
            double[] mass = new double[r.Next(0, 10)];
            using (StreamWriter sw = new StreamWriter(File.Open(@"X:\Дергач\ConsoleApp\bin\Debug\" + str + ".txt", FileMode.Append)))
            {
                sw.Write("" + (i + 1) + " :");
                for (int j = 0; j < mass.Length; j++)
                {
                    mass[j] = Math.Round((r.NextDouble() * 200 - 100), 2);
                    sw.Write(mass[j] + ";");
                }
            }
            return mass;
        }
    }

}

