int[] A = new int[5];
int[] B = new int[5];
int[] product = new int[5];

Console.WriteLine("Enter 5 numbers for array A:");
for (int i = 0; i < A.Length; i++) {
    try{
        Console.Write($"Enter number {i + 1}: ");
        A[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException) {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
    }
}

Console.WriteLine("Enter 5 numbers for array B:");
for (int i = 0; i < B.Length; i++) {
    try{
        Console.Write($"Enter number {i + 1}: ");
        B[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException) {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
    }
}

for (int i = 0; i < A.Length; i++) {
    product[i] = A[i] * B[i];
}

for (int i = 0; i < product.Length; i++) {
    Console.WriteLine($"Product of A[{i}] and B[{i}] is: {product[i]}");
}