int[] zlotoWTurach = {5, 12, 0, 8, 15};

Console.WriteLine("RAPORT \n-------------------");
Console.Write("Liczba tur: ");
int tury = zlotoWTurach.Length;
Console.Write(tury);
int sumaZlota = 0;
int zlotoNad10 = 0;
Console.Write("\nZawartość tablicy: ");
for(int i = 0; i<tury; i++)
{
    Console.Write(zlotoWTurach[i]+" ");
    if(zlotoWTurach[i] >= 10)
    {
        zlotoNad10++;
    }
}

foreach (int item in zlotoWTurach)
{
    sumaZlota+=item;
}

Console.WriteLine($"\nŁączna ilość zdobytego złota: {sumaZlota}");

double sredniaZlota = sumaZlota / tury;

Console.WriteLine($"Średnia ilość złota na turę: {sredniaZlota}");
Console.WriteLine($"Co najmniej 10 sztuk złota zdobyto w {zlotoNad10} turach");
Console.Write("Wyniki w odwrotnej kolejności: ");
for(int i=tury-1; i>0; i--)
    Console.Write(zlotoWTurach[i] + " ");