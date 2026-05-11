double[] notas = new double[8];

double suma = 0;
int reprobados = 0;

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Ingrese la nota del estudiante #{i + 1}: ");
    double.TryParse(Console.ReadLine(), out notas[i]);

    suma += notas[i];

    if (notas[i] < 60)
    {
        reprobados++;
    }
}

Console.WriteLine("\nNotas aprobadas:");

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine(notas[i]);
    }
}

double promedio = suma / notas.Length;

Console.WriteLine($"\nCantidad de estudiantes reprobados: {reprobados}");
Console.WriteLine($"Promedio general del grupo: {promedio}");