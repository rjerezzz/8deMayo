



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