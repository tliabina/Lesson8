/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/




int [,] GetArray(int rows, int colomns)
{
    int[,] array = new int[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(-1); j++)
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
        for (int j = 0; j < array.GetLength(-1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }

}

void PowerArray(int[,] array, int[,] matrix)
{


    int[,] arrays = new int[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                    int res = 0;
                    for(int k = 0; k<array.GetLength(0);k++)
                    {
                        res += array(i,k)*matrix(k,j);
                    }
                    
                Console.WriteLine(array[rows, colomns] + " ");

            }
        }
    }
    return arrays;
}

Console.WriteLine("Задайте размер массивов: ");
int n = Convert.ToInt32(Console.ReadLine());

int array = GetArray(n,n);
int matrix = GetArray(n,n);

PrintArray(GetArray(array));
Console.WriteLine("==============");
PrintArray(GetArray(matrix));
Console.WriteLine("==============");
PowerArray(array, matrix);
