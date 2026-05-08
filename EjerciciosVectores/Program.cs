using System.Numerics;

int[] A = new int[5];
int[] B = new int[5];
int[] vectorSuma = new int[5];

Console.WriteLine("Ingrese los valores del primer vector: ");
for (int i = 0; i < A.Length; i++)
{
    try
    {
        Console.Write($"Valor {i+1}: ");
        A[i] = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Entrada Invalida, ingrese unicamente numeros enteros.");
        Console.ResetColor();
    }

}
Console.WriteLine("Ingrese los valores del segundo vector: ");
for (int i = 0; i < B.Length; i++)
{
    try
    {
        Console.Write($"Valor {i+1}: ");
        B[i] = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        i--;
        Console.WriteLine("Entrada Invalida, ingrese unicamente numeros enteros.");
        Console.ResetColor();
    }
}

for (int i = 0; i < B.Length; i++)
{
    vectorSuma[i] = A[i] + B[i];
}
Console.WriteLine("Suma de los vectores: ");
for (int i = 0; i<vectorSuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Valor {i + 1}: {vectorSuma[i]}");
    Console.ResetColor();
}