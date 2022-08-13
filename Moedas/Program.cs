using System.Globalization;
decimal valor = 10.25m;
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(Math.Round(valor));
Console.WriteLine(Math.Ceiling(valor)); //Arredonda para cima 
Console.WriteLine(Math.Floor(valor)); // Arrendo para baixo