using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcao(18, "Murillo");
        }

        static void Funcao(int idade, string nome) {
            Console.WriteLine("Seu nome é" + nome+ "e a sua idade é" + idade);
            Console.ReadLine();
        }
    }
}
