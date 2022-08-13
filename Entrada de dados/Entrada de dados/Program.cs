using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    internal class Program
    {

        struct Pessoa
         {
            public string nome;
            public string sobrenome;
            public int idade;
            public float peso;
            public float altura;
         }
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            
            Console.WriteLine("Digite o seu nome");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome");
            pessoa1.sobrenome = Console.ReadLine();

            Console.WriteLine($"Nome:{pessoa1.nome} \n Sobrenome: {pessoa1.sobrenome}");

            Console.ReadKey();
        }
    }
}
