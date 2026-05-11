string[] categorias = new string[5];
int[] ventas = new int[5];

int total = 0;

for (int i = 0; i < categorias.Length; i++)
{
    Console.Write($"Ingrese el nombre de la categoría #{i + 1}: ");
    categorias[i] = Console.ReadLine();

    Console.Write($"Ingrese la cantidad de libros vendidos en {categorias[i]}: ");
    int.TryParse(Console.ReadLine(), out ventas[i]);

    total += ventas[i];
}

int mayor = ventas[0];
int posicionMayor = 0;

for (int i = 1; i < ventas.Length; i++)
{
    if (ventas[i] > mayor)
    {
        mayor = ventas[i];
        posicionMayor = i;
    }
}

// Calcular promedio
double avg = (double)total / ventas.Length;

// Mostrar resultados
Console.WriteLine($"\nTotal de libros vendidos: {total}");

Console.WriteLine(
    $"La categoría con más ventas fue {categorias[posicionMayor]} " +
    $"con {mayor} libros vendidos"
);

Console.WriteLine($"Promedio de ventas: {avg}");