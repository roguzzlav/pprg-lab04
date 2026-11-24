int[] artefakty = { 104, 208, 315, 104, 421, 512, 208, 630 };

Console.WriteLine("Podaj identyfikator artefaktu: ");
int idGiven;

while(!int.TryParse(Console.ReadLine(), out idGiven))
{
    Console.WriteLine("Niepoprawny identyfikator. \nPodaj identyfikator artefaktu:");
}

int firstAppearance = -1;
int totalAppearance = 0;

for(int i=0; i<artefakty.Length; i++)
{
    if(idGiven == artefakty[i])
    {
        if(totalAppearance == 0)
            firstAppearance = i;
        totalAppearance++;
    }
}

if(totalAppearance > 0)
{
    Console.WriteLine($"Artefakt znaleziony!\nIndeks pierwszego wystąpienia: {firstAppearance}\nLiczba wystąpień: {totalAppearance}");
}
else
{
    Console.WriteLine("Artefakt nie został znaleziony.");
}