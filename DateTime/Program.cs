using System.Globalization;
var data = DateTime.Now;

// Y para exibir ano
// M para mes
// D dia
// h hora
// s segundos
/*
var dtFormatada = String.Format("{0:yyyy}", data);
var dtFormatada2 = String.Format("{0:dd/MM/yyyy HH:mm:ss}", data);
*/

//Somando datas

Console.Clear();

Console.WriteLine(data.AddDays(12));
Console.WriteLine(data.AddMonths(1));
Console.WriteLine(data.AddHours(2));


// Comparando datas

if (data.Date == DateTime.Now.Date)
{
    Console.WriteLine("É igual");
}
Console.WriteLine(data);


// Culture Info
var pt = new CultureInfo("pt-BR");
Console.WriteLine(DateTime.Now.ToString("D", pt));

// Timezone
var dataLocal = DateTime.UtcNow;
Console.WriteLine(dataLocal);

//Timezone
var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanoSegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanoSegundos);

var timeSpanHoMinutoraSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine(timeSpanHoMinutoraSegundo);

