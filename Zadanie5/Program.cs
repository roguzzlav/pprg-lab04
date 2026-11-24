int[] artefakty = { 104, 208, 315, 421, 512, 630, 745, 890, 950 };
Console.WriteLine("Podaj indentyfikator do wyszukania: ");
int idGiven;
while(!int.TryParse(Console.ReadLine(), out idGiven))
{
    Console.WriteLine("Nieprawdiłowy indentyfikator.");
}

int left = 0;
int right = artefakty.Length - 1;
int apperanceIndex = -1;

while(left <= right)
{
    int mid = left + (right - left) / 2;
    if(idGiven == artefakty[mid])
    {
        apperanceIndex = mid;
        break;
    }

    if(artefakty[mid]<idGiven)
        left = mid +1;
    else
        right = mid - 1;
}

if (apperanceIndex == -1)
    Console.WriteLine("Artefakt nie został znaleziony");
else
    Console.WriteLine($"Artefakt został znaleziony!\nJego indeks to: {apperanceIndex}");
