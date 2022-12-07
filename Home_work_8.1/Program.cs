/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
void GetSortRows(int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {

                    int t = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = t;
                }

            }
        }    
    }

}
Console.WriteLine("Задайте число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число столбцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, colomns);
PrintArray(array);
Console.WriteLine("=============");
GetSortRows(array);
PrintArray(array);