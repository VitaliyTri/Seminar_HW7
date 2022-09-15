// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк масива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов масива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int h = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (k == i && h == j) Console.WriteLine($"Значение элемента [{k},{h}] равно '{matrix[i, j]}'");

    }
}
if (k > m - 1 || h > n - 1) Console.WriteLine($"Такого элемента нет");