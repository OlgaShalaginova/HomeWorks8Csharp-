// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите число строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];

void FillMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = new int[m, n];
void MultiplicationMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(0); k++)
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

FillMatrix(firstMatrix);
FillMatrix(secondMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
MultiplicationMatrix(resultMatrix);
PrintMatrix(resultMatrix);