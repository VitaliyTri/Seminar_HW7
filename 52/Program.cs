// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}
double sumj0 = 0;
double sumj1 = 0;
double sumj2 = 0;
double sumj3 = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == 0) sumj0 += matrix[i, j];
        if (j == 1) sumj1 += matrix[i, j];
        if (j == 2) sumj2 += matrix[i, j];
        if (j == 3) sumj3 += matrix[i, j];
    }
}
Console.WriteLine($"Среднее арифметическое каждого столбца - {Math.Round(sumj0 / 3,1)}; {Math.Round(sumj1 / 3,1)}; {Math.Round(sumj2 / 3,1)}; {Math.Round(sumj3 / 3,1)}");