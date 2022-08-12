var meuArray = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine(meuArray[0]);
meuArray[0] = 12;



// Uma maneira de percorrer um array
for (int i = 0; i < meuArray.Length; i++)
{
    Console.WriteLine(meuArray[i]);
}


//Outra maneira
foreach (var item in meuArray)
{
    Console.WriteLine(item);
}