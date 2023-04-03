/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4. */

void PrintArr (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArr (double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next (0,10);
        }
    }
}

double[,] array = new double[3, 4];
FillArr (array);
PrintArr (array);