/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет 
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

void PrintArr(int[,] arr)
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

void FillArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

int Mas (int[,] arr)
{
    int find = new Random().Next(0,10);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == find)
            {
            Console.WriteLine ("Число " + find + " присутсвует в массиве");
            break;
            }
            if (arr[i, j] != find)
            {
                Console.WriteLine ("Число " + find + " не присутсвует в массиве");
            break;
            }

        }
    }
    return find;
}

int[,] array = new int[3, 4];
FillArr(array);
PrintArr(array);
Console.WriteLine();
Console.WriteLine(Mas(array));


