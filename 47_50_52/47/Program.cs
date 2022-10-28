/*
Задача 47. Задайте двумерный массив размером m×n, \
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
fillArray(array);
printArray(array);

void fillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void printArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+ " ");
        }
                Console.WriteLine("");
    }
}