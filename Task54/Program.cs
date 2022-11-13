// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите число строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

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

void FillMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
}

void SelectionSortRows (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                { 
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1]; 
                matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SelectionSortRows (matrix);
PrintMatrix(matrix);
