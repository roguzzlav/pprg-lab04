List<string> lista = new List<string>
{
   "Miecz",
   "Mikstura",
   "Mapa" 
};

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("Liczba przedmiotów: "+lista.Count());

string nameToAdd = "";

do
{
    Console.WriteLine("Podaj nazwę przedmiotu, który chcesz dodać: ");
    string nameCheck = Console.ReadLine();

    if(nameCheck.IsWhiteSpace())
        Console.WriteLine("Nieprawdiłowa nazwa");
    else if(lista.Contains(nameCheck))
        Console.WriteLine("Taki przedmiot już znajduje się na liście");
    else
        nameToAdd = nameCheck;
}while(nameToAdd.IsWhiteSpace());

lista.Add(nameToAdd);

string nameToRemove = "";

do
{
    Console.WriteLine("Podaj nazwę przedmiotu, który chcesz usunąć: ");
    string nameCheck = Console.ReadLine();

    if(nameCheck.IsWhiteSpace())
        Console.WriteLine("Nieprawdiłowa nazwa");
    else if(lista.Contains(nameCheck))
    {
        nameToRemove = nameCheck;
    }
    else
    {
        Console.WriteLine("Podany przedmiot nie znajduje się na liście \n -------------------------");
    }
}while(nameToRemove.IsWhiteSpace());

bool deletionResult = lista.Remove(nameToRemove);
if(deletionResult)
{    
    Console.WriteLine($"Usunięto przedmiot {nameToRemove}");
    Console.WriteLine("-------------------------");
}
else
{
    Console.WriteLine("Nie udało usunąć się przedmiotu");
}

Console.WriteLine("Zaktualizowana lista: ");
foreach (string item in lista)
{
    Console.WriteLine(item);
}