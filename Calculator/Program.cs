
// Limpando o console

Soma();
Subtracao();

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
}


