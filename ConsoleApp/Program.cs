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
            callmathcl();
            callArranges();
        }
        public static void callmathcl()
        {
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double[] mass = mathcl(i, "Sum");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"Sum.txt", FileMode.Append)))
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
                using (StreamWriter sw = new StreamWriter(File.Open(@"Mul.txt", FileMode.Append)))
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
                using (StreamWriter sw = new StreamWriter(File.Open(@"Average.txt", FileMode.Append)))
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
                using (StreamWriter sw = new StreamWriter(File.Open(@"GeomAverage.txt", FileMode.Append)))
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
        public static void callArranges()
        {
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                bool f = r.Next(0, 2) > 0 ? true : false;
                double[] mass = mathcl(i, "ArrSort");
                mass = Arranges.ArrSort(mass,f);
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"ArrSort.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.Write("\nИтог ("+f+"):");
                        for (int j = 0; j < mass.Length; j++)
                        {
                            sw.Write(mass[j] + "; ");
                        }
                        sw.Write("\n");
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
                bool f = r.Next(0, 2) > 0 ? true : false;
                double[] mass = mathcl(i, "ArrFind");
               
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"ArrFind.txt", FileMode.Append)))
                {
                    try
                    {
                        mass = Arranges.ArrFind(mass, f);
                        sw.Write("\nИтог (" + f + "):");
                        for (int j = 0; j < mass.Length; j++)
                        {
                            sw.Write(mass[j] + "; ");
                        }
                        sw.Write("\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                double[,] mass = doublemas2(i, "ArrDet");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"ArrDet.txt", FileMode.Append)))
                {
                    try
                    {
                        sw.WriteLine("Итог:" + Arranges.ArrDet(mass) + "\n");
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                double[,] mass = doublemas2(i, "MatrixSum");
                double[,] mass2 = doublemas2(i, "MatrixSum");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"MatrixSum.txt", FileMode.Append)))
                {
                    try
                    {
                        mass = Arranges.MatrixSum(mass,mass2);
                        sw.Write("\nИтог:");
                        for (int j = 0; j < mass.GetLength(0); j++)
                        {
                            for (int k = 0; k < mass.GetLength(1); k++)
                            {
                                sw.Write(mass[j, k] + "; ");
                            }
                            sw.WriteLine("\n");
                        }
                    }
                    catch
                    {
                        sw.WriteLine("Итог: ошибка");
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                double[,] mass = doublemas2(i, "MatrixMul");
                double[,] mass2 = doublemas2(i, "MatrixMul");
                System.Threading.Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(File.Open(@"MatrixMul.txt", FileMode.Append)))
                {
                    try
                    {
                        mass = Arranges.MatrixSum(mass, mass2);
                        sw.Write("\nИтог:");
                        for (int j = 0; j < mass.GetLength(0); j++)
                        {
                            for (int k = 0; k < mass.GetLength(1); k++)
                            {
                                sw.Write(mass[j, k] + "; ");
                            }
                            sw.WriteLine("\n");
                        }
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
            using (StreamWriter sw = new StreamWriter(File.Open(@"" + str + ".txt", FileMode.Append)))
            {
                sw.Write("\n" + (i + 1) + " :");
                for (int j = 0; j < mass.Length; j++)
                {
                    mass[j] = Math.Round((r.NextDouble() * 200 - 100), 2);
                    sw.Write(mass[j] + "; ");
                }
            }
            return mass;
        }
        public static double[,] doublemas(int i, string str,bool f)
        {
            Random r = new Random();
            int a = r.Next(0, 5), b = r.Next(0, 5);
            
            double[,] mass = new double[a, b];
            using (StreamWriter sw = new StreamWriter(File.Open(@"" + str + ".txt", FileMode.Append)))
            {
                sw.WriteLine("" + (i + 1) + " ("+a+";"+b+";"+f+"):\n");
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    for (int k = 0; k < mass.GetLength(1); k++)
                    {
                        mass[j, k] = Math.Round((r.NextDouble() * 200 - 100), 2);
                        sw.Write(mass[j, k] + "; ");
                    }
                    sw.Write("\n");
                }
            }
            return mass;
        }
         public static double[,] doublemas2(int i, string str)
        {
            Random r = new Random();
            int a = r.Next(0, 5), b = r.Next(0, 5);

            double[,] mass = new double[a, b];
            using (StreamWriter sw = new StreamWriter(File.Open(@"" + str + ".txt", FileMode.Append)))
            {
                sw.WriteLine("" + (i + 1) + " (" + a + ";" + b +"):\n");
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    for (int k = 0; k < mass.GetLength(1); k++)
                    {
                        mass[j, k] = Math.Round((r.NextDouble() * 200 - 100), 2);
                        sw.Write(mass[j, k] + "; ");
                    }
                    sw.Write("\n");
                }
            }
            return mass;
        }
    }

}

