
// Limpando o console

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();


        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------");
            Console.WriteLine("Selecione uma opção: ");
            short op = short.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");

            // Convertendo o valor que vem do ReadLine para float 
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");

            // Convertendo o valor que vem do ReadLine para float 
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtracao é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            float v1, v2;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            if (v1 <= 0)
            {
                Console.WriteLine("Digite um valor maior que 0");
                v1 = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            float divisao = v1 / v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é {divisao} ");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            float v1, v2;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O Resultado a multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}