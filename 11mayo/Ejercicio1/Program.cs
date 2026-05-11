double[] temperaturas = new double[7];
double suma = 0;

for (int i = 0; i < temperaturas.Length; i++)
{
    Console.Write($"Ingrese la temperatura del dia #{i + 1} (En decimales): ");
    double.TryParse(Console.ReadLine(), out temperaturas[i]);

    suma += temperaturas[i];
}

double maximo = temperaturas[0];
double minimo = temperaturas[0];

for (int i = 0; i < temperaturas.Length; i++)
{
    Console.WriteLine($"El dia #{i + 1} hubo una temperatura de: {temperaturas[i]} grados");

    if (temperaturas[i] > maximo)
    {
        maximo = temperaturas[i];
    }

    if (temperaturas[i] < minimo)
    {
        minimo = temperaturas[i];
    }
}

double avg = Math.Round(suma / temperaturas.Length, 1);



Console.WriteLine($"\n\nLa temperatura promedio de la semana fue: {avg}");
Console.WriteLine($"La temperatura mas alta fue {maximo}");
Console.WriteLine($"La temperatura mas baja fue {minimo}");

