using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string appData = @"C:\Users\gmalta\source\repos\FileReader\FileReader\App_Data\";

            string fileName = GenerateFile(appData, 1_000_000);

            Console.WriteLine("##########");
            Console.WriteLine("Try to find a row in a large file");
            string path = Path.Combine(appData, fileName);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool contains = File.ReadLines(path).Contains("91820988163");
            stopwatch.Stop();
            Console.WriteLine("Time elipsed to try find a value: {0}", stopwatch.ElapsedMilliseconds);
            Console.WriteLine($"Find something: {0}", contains);
        }

        private static string GenerateFile(string rootPath, int numRows)
        {
            string filename = $"file_{numRows}_rows.txt";
            string path = Path.Combine(rootPath, filename);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            string[] lista = new string[numRows];

            for (int i = 0; i < numRows; i++)
            {
                lista[i] = CpfUtils.GerarCpf();
            }

            File.WriteAllLines(path, lista);

            stopwatch.Stop();

            Console.WriteLine("Time elipsed to generate test file: {0}", stopwatch.ElapsedMilliseconds);

            return filename;
        }
    }
    public static class CpfUtils
    {
        public static string GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente += resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente += resto;
            return semente;
        }
    }
}
