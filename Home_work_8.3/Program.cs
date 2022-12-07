/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] GetArray(int rows, int colomns)
{
    int[,] array = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}

int[,] PowerArray(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int colomns = array1.GetLength(1);

    int[,] result = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            int res = 0;

            for (int k = 0; k < rows; k++)
            {
                res += array1[i, k] * array2[k, j];
            }

            result[i, j] = res;
        }
    }

    return result;
}

Console.Write("Задайте размер массивов: ");
int n = Convert.ToInt32(Console.ReadLine());

var array1 = GetArray(n, n);
var array2 = GetArray(n, n);

//int[,] array1 = { { 2, 4 }, { 3, 2 } };
//int[,] array2 = { { 3, 4 }, { 3, 3 } };

PrintArray(array1);
Console.WriteLine("==============");
PrintArray(array2);
Console.WriteLine("==============");

var matrix = PowerArray(array1, array2);
PrintArray(matrix);
