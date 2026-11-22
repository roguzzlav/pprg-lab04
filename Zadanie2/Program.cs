Dictionary<string, int> dict = new Dictionary<string, int>
{
    {"Miecz", 100},
    {"Tarcza", 75},
    {"Mikstura", 20}
};

Console.WriteLine("Wszystkie przedmioty i ich ceny: ");
foreach (KeyValuePair<string, int> para in dict)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}

string nazwa = "";
do
{    
    Console.WriteLine("Podaj nazwę przedmiotu, który chcesz dodać:");
    string nameAdd = Console.ReadLine();

    if(nameAdd.IsWhiteSpace())
    {
        Console.WriteLine("Nieprawdiłowa nazwa przedmoitu");
    }
    else if(dict.ContainsKey(nameAdd))
    {
        Console.WriteLine("Taki przedmiot już się znajduje w słowniku");
    }
    else
    {
        nazwa = nameAdd;
    }
}while(nazwa.IsWhiteSpace());


int cena = -1;
do
{
    Console.WriteLine("Podaj cenę twojego przedmiotu:");
    int.TryParse(Console.ReadLine(), out int priceCheck);
    if(priceCheck<0)
    {
        Console.WriteLine("Nieprawdiłowa cena");
    }
    else
    {
        cena = priceCheck;
    }
}
while(cena<0);

dict.Add(nazwa, cena);

Console.WriteLine("Podaj nazwę przedmiotu do sprawdzenia: ");
string nameToCheck = Console.ReadLine();

if (dict.ContainsKey(nameToCheck))
{
    Console.WriteLine("Cena tego przedmiotu to: "+dict[nameToCheck]);
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu");
}

Console.WriteLine("Cały cennik po dodaniu: ");
foreach (KeyValuePair<string, int> para in dict)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}