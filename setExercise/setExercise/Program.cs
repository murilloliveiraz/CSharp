using setExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor alex = new Professor("Alex");
            string[] vet = { "A", "B", "C" };
            for (int i = 0; i< vet.Length; i++)
            {
                Console.Write($"How many students for course {vet[i]}? ");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    Student student = new Student(int.Parse(Console.ReadLine()));
                    alex.addStudent(student);
                }
            }
            Console.WriteLine("Total students:" + alex.totalStudents());
        }
    }
}
