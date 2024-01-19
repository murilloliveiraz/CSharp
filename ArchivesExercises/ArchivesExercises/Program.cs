using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using ArchivesExercises.Entities;

namespace ArchivesExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file1.csv";
            string directory = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\out\";
            Directory.CreateDirectory(directory);
            string outPath = Path.Combine(directory + "summary.csv");
            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(outPath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(';');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);
                        Console.WriteLine(prod.total());
                        sw.WriteLine(prod.name + ";" +prod.total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                using (StreamReader sr = File.OpenText(outPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
