var arr = new int[3];


try
{
    for (int i = 0; i <= arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("N encontrei o index");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("OPS algo deu errado");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new Exception("O texto n pode ser nulo ou vazio");
    }
}
