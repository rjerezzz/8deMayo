int[] V = new int[5];

double suma = 0;

for (int i = 0; i < V.Length; i++)
{
    try
    {
        Console.Write($"Ingrese el Valor {i + 1}: ");
        V[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese una entrada válida");
        Console.ResetColor();
        i--;
    }
}

for (int i = 0; i < V.Length; i++)
{
    double elevado = Math.Pow(V[i], 2);
    suma += elevado;
}

double magnitud = Math.Sqrt(suma);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Magnitud del vector: {magnitud}");
Console.ResetColor();