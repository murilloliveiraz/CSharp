
using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\david.soares\OneDrive - Cobreflex\Área de Trabalho\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            /*
                StreamReader sr = null;
                try {
                    sr = File.OpenText(path);
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e) {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally {
                    if (sr != null) sr.Close();
                }
             */
        }
    }
}
