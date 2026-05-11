int[] puntajes = new int[6];

for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine($"Ingrese el puntaje #{i + 1}:");
    int.TryParse(Console.ReadLine(), out puntajes[i]);
}


int cuenta = 0;


Array.Sort(puntajes);
int highest = puntajes[puntajes.Length - 1];
int lowest = puntajes[0];

for (int i = 0; i < puntajes.Length; i++)
{
    if (puntajes[i] > 500)
    {
        cuenta++;
    }
}

Console.WriteLine($"El puntaje más alto es: {highest}");
Console.WriteLine($"El puntaje más bajo es: {lowest}");
Console.WriteLine($"La cantidad de puntajes mayores a 500 es: {cuenta}");
