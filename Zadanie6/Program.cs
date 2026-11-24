int[,] mapa = {

    { 5,  0, 12,  3 },

    { 8, 15,  2,  0 },

    { 4,  7, 20,  6 }

};

int sum = 0;
int maximum = 0;
int maximumRow = 0, maximumCol = 0;

for(int i = 0; i < mapa.GetLength(0); i++)
{
    for(int j = 0; j < mapa.GetLength(1); j++)
    {
        Console.Write($"{mapa[i,j]} | ");
        sum+=mapa[i,j];
        if(maximum<mapa[i,j])
        {
            maximum = mapa[i,j];
            maximumRow = i;
            maximumCol = j;
        }
    }
    Console.Write("\n");
    Console.WriteLine("-----------------");
}

Console.WriteLine($"Liczba wierszy: {mapa.GetLength(0)}");
Console.WriteLine($"Liczba kolumn: {mapa.GetLength(1)}");
Console.WriteLine($"Łączna ilość złota: {sum}");
Console.WriteLine($"Pozycja największej wartości: Wiersz {maximumRow+1}, Kolumna {maximumCol+1}");