/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void PrintArr (double [,] arr)
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

void FillArr (double [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next (0,10);
        }
    }
}

double Average (double [,] mass)
{
    double s = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 0)
            {
                s = (mass [i, j] + mass [1, j] + mass [2, j]) / 3;
            }
        }  
    }
    return s;
}

double Average1 (double [,] mass)
{
    double s = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 1)
            {
                s = (mass [i, j] + mass [1, j] + mass [2, j]) / 3;
            }
        }  
    }
    return s;
}

double Average2 (double [,] mass)
{
    double s = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 2)
            {
                s = (mass [i, j] + mass [1, j] + mass [2, j]) / 3;
            }
        }  
    }
    return s;
}

double [,] array = new double [3 , 3];
FillArr (array);
PrintArr (array);
Console.WriteLine();

Console.WriteLine ("Среднее арифметическое 1го столбца = " + Math.Round(Average (array), 1));
Console.WriteLine ("Среднее арифметическое 2го столбца = " + Math.Round(Average1 (array), 1));
Console.WriteLine ("Среднее арифметическое 3го столбца = " + Math.Round(Average2 (array), 1));

