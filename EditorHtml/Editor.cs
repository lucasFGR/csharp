using System;
public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------");
        Start();


    }

    public static void Start()
    {
        var file = new System.Text.StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-----------");
        Console.WriteLine("  Deseja salvar o arquvivo ? (S/N)");
        Viewer.Show(file.ToString());
        //string choice = Console.ReadLine().ToLower();
        /*
        if (choice == "s")
        {
            Salvar(file.ToString());
            Viewer.Show(file.ToString());
            Console.ReadLine();

        }
        else
        {
            Menu.Show();
        }
        */



    }

    public static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Digie o caminho que você deseja salvar o arquivo");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso");

    }
}