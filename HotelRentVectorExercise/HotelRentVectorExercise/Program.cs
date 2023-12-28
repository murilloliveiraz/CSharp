using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRentVectorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRents = int.Parse(Console.ReadLine());
            Rent[] vet = new Rent[10];

            for(int i = 0; i < numberOfRents; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto (0 a 9): ");
                int room = int.Parse(Console.ReadLine());
                vet[room] = new Rent { Name = name, Email = email, Room = room };
            }

            for(int i = 0;i < vet.Length; i++) {
                if(vet[i] != null)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
