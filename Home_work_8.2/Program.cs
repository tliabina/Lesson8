/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7*/



int[,] GetArray(int rows, int colomns)
{
    int[,] array = new int[rows, colomns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }

    return array;
}

void PrintRow(int[] row)
{
    Console.WriteLine(string.Join(" ", row));
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}

int FindMinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }

    return minIndex;
}

int[] ExtractRow(int[,] array, int rowIndex)
{
    int[] result = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        result[i] = array[rowIndex, i];
    }

    return result;
}

int[] FindMinSumRow(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumColumns = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumColumns += array[i, j];
        }
        arraySum[i] = sumColumns;
    }

    int rowIndex = FindMinIndex(arraySum);

    return ExtractRow(array, rowIndex);
}


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, colomns);
PrintArray(array);
Console.WriteLine("==============");

int[] minSumRow = FindMinSumRow(array);
PrintRow(minSumRow);
