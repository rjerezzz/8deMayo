<<<<<<< HEAD
﻿int[] ventas = new int[7];
int total = 0;
int dias = 0;

for (int i = 0; i < ventas.Length; i++)
{
    Console.Write($"Ingrese el total de las ventas del dia #{i+1}: ");
    int.TryParse(Console.ReadLine(), out ventas[i]);
}

int minimo = ventas[0];

for (int i = 0; i < ventas.Length; i++)
{
    total += ventas[i];
    if (ventas[i] >= 150)
    {
        dias++;
    }
    if (ventas[i] < minimo)
    {
        minimo = ventas[i];
    }

}

Console.WriteLine($"\n\nEl total de las ventas es: {total}");
Console.WriteLine($"El promedio de las ventas es: {total / ventas.Length}");
Console.WriteLine($"El numero de dias con ventas mayores o iguales a 150 es: {dias}");
Console.WriteLine($"La venta mas baja fue: {minimo}");

=======
﻿



using System.Numerics;

int[] A = new int[5];
int[] B = new int[5];
int[] vectorResta = new int[5];

Console.WriteLine("Ingrese los valores del primer vector: ");
for (int i = 0; i < A.Length; i++)
{
    bool correcto = false;
    while (!correcto)
    {
        Console.Write($"Valor {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out A[i]))
        {
            correcto = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada Invalida");
            Console.ResetColor();
        }
    }
}

Console.WriteLine("Ingrese los valores del segundo vector: ");
for (int i = 0; i < B.Length; i++)
{
    bool correcto = false;
    while (!correcto)
    {
        Console.Write($"Valor {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out B[i]))
        {
            correcto = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada Invalida");
            Console.ResetColor();
        }
    }
}

for (int i = 0; i < vectorResta.Length; i++)
{
    vectorResta[i] = A[i] - B[i];
}

Console.WriteLine("La resta de los vectores es: ");
for (int i = 0; i < vectorResta.Length; i++)
{
    Console.WriteLine($"Valor {i + 1}: {A[i] - B[i]}");
}
>>>>>>> 19534c5d68c501c5e465c1a8e5d4a776bceb4e6a
