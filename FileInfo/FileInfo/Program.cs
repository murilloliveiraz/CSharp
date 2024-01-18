using System;
using System.IO;

namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file1.txt";
            string targetPath = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
