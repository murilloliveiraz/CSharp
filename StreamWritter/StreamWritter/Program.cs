using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWritter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file1.txt";
            string targetPath = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
