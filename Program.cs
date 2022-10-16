// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите колличество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество рядов: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

Console.WriteLine("Задан массив: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-9, 9);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

Console.WriteLine("Преобразованный массив: ");

for (int i = 0; i < matrix.GetLength(1); i++)
    {
    SortMatrix(matrix, i);
    }
PrintMatrix(matrix);

void SortMatrix(int[,] matrix, int rowIndex)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, i] < matrix [rowIndex, j])
            {
                int temp = matrix[rowIndex, i];
                matrix[rowIndex, i] = matrix[rowIndex, j];
                matrix[rowIndex, j] = temp;
            }  
        }
    }
}

void PrintMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}
